using System.Reflection;
using System.Text.RegularExpressions;
using CaseExtensions;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;
using Scriban;

namespace Plaid.OpenApiParser;

internal static partial class Program
{
	private static void Main()
	{
		var basePath = GetBasePath();
		var reader = new OpenApiStringReader();
		var txt = File.ReadAllText(Path.Combine(basePath, "plaid-openapi", "2020-09-14.yml"));
		var doc = reader.Read(txt, out var diagnostic);

		if (diagnostic != null
			&& diagnostic.Errors != null
			&& diagnostic.Errors.Count != 0)
		{
			// supposedly yaml is invalid?
			throw new InvalidOperationException("Invalid plaid yaml file.");
		}

		ProcessUris(doc);
		ProcessAccountTypes(doc);

		var webhookMap = new Dictionary<(string type, string code), string>();
		ProcessWebhookTypes(doc, isProcessor: false, webhookMap);

		var processorWebhookMap = new Dictionary<(string type, string code), string>();
		ProcessWebhookTypes(doc, isProcessor: true, processorWebhookMap);

		var plaidSrcPath = Path.Combine(basePath, "src", "Plaid");
		SaveApis(plaidSrcPath);
		SaveSchemas(plaidSrcPath);
		SaveConverterMap(plaidSrcPath, isProcessor: false, webhookMap);
		SaveConverterMap(plaidSrcPath, isProcessor: true, processorWebhookMap);
	}

	private static string GetBasePath()
	{
		var path = Environment.CurrentDirectory;
		while (!Directory.Exists(Path.Combine(path, "plaid-openapi")))
			path = Path.GetDirectoryName(path)!;
		return path;
	}

	private static readonly List<ApiCall> s_apiCalls = [];
	private static readonly Dictionary<string, SchemaEntity> s_schemaEntities = [];
	private static readonly Dictionary<string, string> s_nameFixups = new()
	{
		["ACHClass"] = "AchClass",
		["APR"] = "Apr",
		["Consented Data Scope"] = "ConsentedDataScope",
		["ISOCurrencyCode"] = "IsoCurrencyCode",
		["ISO Currency Code"] = "WalletIsoCurrencyCode",
		["NumbersACH"] = "NumbersAch",
		["NumbersEFT"] = "NumbersEft",
		["NumbersBACS"] = "NumbersBacs",
		["Transaction Location"] = "Location",
		["Transaction Payment Channel"] = "PaymentChannel",
		["transaction_code"] = "TransactionCode",
		["YTDGrossIncomeSummaryFieldNumber"] = "YtdGrossIncomeSummaryFieldNumber",
		["YTDNetIncomeSummaryFieldNumber"] = "YtdNetIncomeSummaryFieldNumber",
		["Error"] = "PlaidError",
		["WebhookType"] = "SandboxItemFireWebhookRequestWebhookTypeEnum",
		["purpose"] = "TransferDocumentPurpose",
	};
	private static readonly string[] s_excludes =
	[
		"PlaidException",
		"Error",
		"PlaidError",
		"Cause",
		"AccountType",
		"OverrideAccountType",
		"StandaloneAccountType",
		"DepositoryAccountSubtype",
		"DepositoryAccountSubtypes",
		"CreditAccountSubtype",
		"CreditAccountSubtypes",
		"LoanAccountSubtype",
		"LoanAccountSubtypes",
		"InvestmentAccountSubtype",
		"InvestmentAccountSubtypes",
		"AccountSubtype",
	];
	private static readonly string[] s_excludeApis =
	[
		"/credit/asset_report/freddie_mac/get",
	];

	private static void ProcessUris(OpenApiDocument doc)
	{
		foreach (var (uri, item) in doc.Paths)
		{
			if (s_excludeApis.Contains(uri))
				continue;

			var basePath = uri[1..].Split('/')[0].ToPascalCase();

			if (!item.Operations.ContainsKey(OperationType.Post))
				continue;

			var op = item.Operations[OperationType.Post];

			if (!op.Responses["200"].Content.ContainsKey("application/json"))
				continue;

			if (op.Responses["200"].Content["application/json"].Schema == default)
				continue;

			var requestSchema = op.RequestBody.Content["application/json"].Schema;
			var requestType = $"{basePath}.{requestSchema.Reference.Id}";
			AddSchemaEntity(basePath, requestSchema.Reference.Id, BaseType.Request, requestSchema, SchemaType.Class);

			var responseSchema = op.Responses["200"].Content["application/json"].Schema;
			var responsePath = responseSchema.Reference.Id.EndsWith("Response", StringComparison.Ordinal) ? basePath : "Entity";
			var responseType = $"{responsePath}.{responseSchema.Reference.Id}";
			AddSchemaEntity(responsePath, responseSchema.Reference.Id, BaseType.Response, responseSchema, SchemaType.Record);

			s_apiCalls.Add(new(
				uri,
				basePath,
				string.Concat(uri[1..].Split('/').Select(s => s.ToPascalCase())),
				FixupDescription(op.Description ?? op.Summary),
				op.ExternalDocs?.Url?.ToString() ?? string.Empty,
				requestType,
				responseType));
		}
	}

	private static void AddSchemaEntity(string basePath, string name, BaseType baseType, OpenApiSchema schema, SchemaType type)
	{
		if (s_excludes.Contains(name)) return;

		if (s_schemaEntities.TryGetValue(name, out var value))
		{
			if (value.SchemaType == SchemaType.Record
				&& type == SchemaType.Class)
			{
				value.SchemaType = SchemaType.Class;
			}

			if (baseType == BaseType.Response && value.BaseType != BaseType.Response)
				value.BaseType = BaseType.Response;

			return;
		}

		if (type == SchemaType.Enum)
		{
			var (pd, ed) = ParseEnumDescription(schema.Description);

			static string GetEnumName(string name) =>
				$"{(char.IsDigit(name[0]) ? "_" : "")}{name.Replace(".", "_", StringComparison.Ordinal).ToLower(null).ToPascalCase()}";

			s_schemaEntities[name] = new()
			{
				SchemaType = type,
				BasePath = basePath,
				Name = name,
				Description = pd,
				Properties =
				[
					.. GetEnumValues(schema)
						.OfType<OpenApiString>()
						.Select(e => new Property(
							e.Value,
							string.Empty,
							GetEnumName(e.Value),
							ed.GetValueOrDefault(e.Value)
						))
				],
			};
		}
		else
		{
			var e = s_schemaEntities[name] = new()
			{
				SchemaType = type,
				BasePath = basePath,
				Name = name,
				Description = GetPropertyDescription(schema),
				BaseType = baseType,
			};

			var properties = schema.Properties.ToList();

			foreach (var s in schema.AllOf)
			{
				properties.AddRange(s.Properties);
			}

			e.Properties =
			[
				.. properties
					.Where(p => baseType switch
					{
						BaseType.Request => p.Key is not "client_id" and not "secret" and not "access_token",
						BaseType.Response => p.Key is not "request_id" and not "error",
						BaseType.Webhook or BaseType.ProcessorWebhook => p.Key is not "environment",
						BaseType.None => true,
						_ => true,
					})
					.Select(p =>
					{
						var propertyName = p.Key.ToLower(null).ToPascalCase();
						if (baseType is BaseType.Webhook or BaseType.ProcessorWebhook && p.Key is "webhook_type" or "webhook_code")
						{
							var code = p.Value.Description.Trim('`', '"');
							return new Property(code, propertyName, propertyName, code.ToLower(null).ToPascalCase());
						}

						var typeName = GetPropertyType(name, propertyName, p.Value, type);
						if (p.Value.Nullable
							|| p.Value is { AllOf: [{ Nullable: true }] }
							|| !schema.Required.Contains(p.Key))
						{
							typeName += "?";
						}

						return new Property(
							p.Key,
							typeName,
							propertyName,
							GetPropertyDescription(p.Value),
							IsDeprecated: p.Value.Deprecated
						);
					})
			];
		}
	}

	private static string PrefixPlaidUrl(string url) =>
		url.StartsWith('/')
			? "https://plaid.com" + url
			: url;

	[GeneratedRegex(@"\[([^]]+)\]\(([^)]+)\)")]
	private static partial Regex LinkBlockRegex();

	private static string FixLinkBlocks(string description) =>
		LinkBlockRegex().Replace(
			description,
			m => "<a href=\"" + PrefixPlaidUrl(m.Groups[2].Value) + "\">" + m.Groups[1].Value + "</a>");

	[GeneratedRegex(@"<(\w+)>")]
	private static partial Regex BracketRegex();

	private static string FixBrackets(string description) =>
		BracketRegex().Replace(
			description,
			m => m.Groups[1].Value == "em" ? "<em>" : $"&lt;{m.Groups[1].Value}&gt;");

	private static string FixAmpersands(string description) =>
		description.Replace("&", "&amp;", StringComparison.Ordinal);

	[GeneratedRegex(@"`([^`]+)`")]
	private static partial Regex CodeBlockRegex();

	private static string FixCodeBlocks(string description) =>
		CodeBlockRegex().Replace(
			description,
			"<c>$1</c>");

	private static string FixupDescription(string description) =>
		string.IsNullOrWhiteSpace(description) ? string.Empty :
		FixCodeBlocks(FixLinkBlocks(FixBrackets(FixAmpersands(description)))).TrimEnd();

	[GeneratedRegex("^`\"?(.+?)\"?:?`\\s*:?-?\\s*(.*)$")]
	private static partial Regex EnumDescriptionRegex();

	private static (string enumDescription, Dictionary<string, string> propertyDescription) ParseEnumDescription(string description)
	{
		if (string.IsNullOrWhiteSpace(description))
			return (string.Empty, new Dictionary<string, string>());
		if (description.StartsWith("The asynchronous event to be simulated.", StringComparison.OrdinalIgnoreCase))
			return (FixupDescription(description), new Dictionary<string, string>());

		var lines = description.Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

		if (lines.Length == 1)
			return (FixCodeBlocks(lines[0]), new Dictionary<string, string>());

		if (lines.Any(l => l.StartsWith('`')))
		{
			var ed = lines.FirstOrDefault(l => !l.StartsWith('`'))
				?? string.Empty;

			ed = FixupDescription(ed);

			var pd = lines
				.Where(l => l.StartsWith('`'))
				.Select(l => EnumDescriptionRegex().Match(l))
				.ToDictionary(
					m => m.Groups[1].Value,
					m => FixupDescription(m.Groups[2].Value));
			return (ed, pd);
		}
		else
			return (string.Empty, new Dictionary<string, string>());
	}

	private static string GetPropertyDescription(OpenApiSchema type)
	{
		var description = string.IsNullOrWhiteSpace(type.Description)
			? type.AllOf.LastOrDefault()?.Description ?? ""
			: type.Description;

		return type.Enum is { Count: > 0 }
			? ParseEnumDescription(description).enumDescription
			: FixupDescription(description);
	}

	private static string GetPropertyType(string className, string propertyName, OpenApiSchema schema, SchemaType type)
	{
		if (schema.Type == "array")
			return $"IReadOnlyList<{GetPropertyType(className, propertyName, schema.Items, type)}>";

		if (schema.Type == "boolean")
			return "bool";
		if (schema.Type == "numeric")
			return "decimal";
		if (schema.Type == "number")
			return "decimal";
		if (schema.Type == "integer")
			return "int";

		if (schema.Format == "date-time")
			return "DateTimeOffset";

		if (schema.Format == "date")
			return "DateOnly";

		if (!string.IsNullOrWhiteSpace(schema.Description))
		{
			if (schema.Description.Contains("YYYY-MM-DD", StringComparison.OrdinalIgnoreCase))
				return "DateOnly";
			if (schema.Description.Contains("ISO8601", StringComparison.OrdinalIgnoreCase)
				|| schema.Description.Contains("ISO 8601", StringComparison.OrdinalIgnoreCase))
			{
				return "DateTimeOffset";
			}
		}

		if (schema.AllOf.FirstOrDefault(s => s.Enum is { Count: > 0 }) is { } enumSchema)
			return GetPropertyType(className, propertyName, enumSchema, type);

		var entityType = schema.Enum is { Count: > 0 } ? SchemaType.Enum : type;
		if (schema.Type is "string" && entityType != SchemaType.Enum)
			return "string";

		if (schema.AllOf is [{ Type: "string" }])
			return "string";

		if (schema.Reference != null)
		{
			if (schema.Reference.Id.EndsWith("Nullable", StringComparison.OrdinalIgnoreCase))
			{
				if (schema.AllOf is [{ } realType, ..])
					return GetPropertyType(className, propertyName, realType, entityType);
			}
			else if (schema.AdditionalProperties != null)
				return $"IReadOnlyDictionary<string, {GetPropertyType(className, propertyName, schema.AdditionalProperties, type)}>";
		}

		var entityName = schema.Title ?? schema.Reference?.Id;
		if (string.IsNullOrWhiteSpace(entityName))
		{
			var parentName = className.EndsWith("Object", StringComparison.OrdinalIgnoreCase) ? className[..^6] : className;
			entityName = parentName
				+ propertyName.ToPascalCase()
				+ (entityType == SchemaType.Enum ? "Enum" : "Object");
		}

		entityName = s_nameFixups.GetValueOrDefault(entityName, entityName);
		AddSchemaEntity("Entity", entityName, BaseType.None, schema, entityType);
		return entityName == "PlaidException"
			? "Exceptions.PlaidException"
			: $"Entity.{entityName}";
	}

	private static string GetEnumName(string name) =>
		$"{(char.IsDigit(name[0]) ? "_" : "")}{name.ToLower(null).ToPascalCase()}";

	private static void ProcessAccountTypes(OpenApiDocument doc)
	{
		var pd = new Dictionary<string, string>()
		{
			["depository"] = FixupDescription(
				doc.Components.Schemas["DepositoryAccount"].Description),
			["credit"] = FixupDescription(
				doc.Components.Schemas["CreditAccount"].Description),
			["loan"] = FixupDescription(
				doc.Components.Schemas["LoanAccount"].Description),
			["investment"] = FixupDescription(
				doc.Components.Schemas["InvestmentAccountSubtypeStandalone"].Description),
			["other"] = FixupDescription(
				doc.Components.Schemas["StandaloneAccountType"]
					.Properties["other"].Description),
		};

		s_schemaEntities["AccountType"] = new()
		{
			SchemaType = SchemaType.Enum,
			BasePath = "Entity",
			Name = "AccountType",
			Description = "The general type of an account.",
			Properties =
			[
				.. pd
					.Select(e => new Property(
						e.Key,
						string.Empty,
						GetEnumName(e.Key),
						e.Value
					))
			],
		};
		pd.Clear();

		AddAccountSubtype(doc, "DepositoryAccountSubtype", "DepositoryAccount");
		AddAccountSubtype(doc, "CreditAccountSubtype", "CreditAccount");
		AddAccountSubtype(doc, "LoanAccountSubtype", "LoanAccount");
		AddAccountSubtype(doc, "InvestmentAccountSubtype", "InvestmentAccountSubtypeStandalone");

		var s = doc.Components.Schemas["AccountSubtype"];
		foreach (var p in doc.Components.Schemas["DepositoryAccount"].Properties)
			pd[p.Key] = FixupDescription(p.Value.Description).TrimEnd();
		foreach (var p in doc.Components.Schemas["CreditAccount"].Properties)
			pd[p.Key] = FixupDescription(p.Value.Description).TrimEnd();
		foreach (var p in doc.Components.Schemas["LoanAccount"].Properties)
			pd[p.Key] = FixupDescription(p.Value.Description).TrimEnd();
		foreach (var p in doc.Components.Schemas["InvestmentAccountSubtypeStandalone"].Properties)
			pd[p.Key] = FixupDescription(p.Value.Description).TrimEnd();

		s_schemaEntities["AccountSubtype"] = new()
		{
			SchemaType = SchemaType.Enum,
			BasePath = "Entity",
			Name = "AccountSubtype",
			Description = "The specific type of an account.",
			Properties =
			[
				.. pd
					.Select(e => new Property(
						e.Key,
						string.Empty,
						GetEnumName(e.Key),
						e.Value
					))
			],
		};
	}

	private static void ProcessWebhookTypes(OpenApiDocument doc, bool isProcessor, Dictionary<(string type, string code), string> webhookMap)
	{
		var prefix = isProcessor ? "Processor" : "";
		var baseType = isProcessor ? BaseType.ProcessorWebhook : BaseType.Webhook;

		var schemas = doc.Components.Schemas
			.Select(x => x.Value)
			.Select(x => (schema: x, name: x.Title ?? x.Reference?.Id!))
			.Where(x => !string.IsNullOrWhiteSpace(x.name))
			.Where(x => x.name.EndsWith("Webhook", StringComparison.OrdinalIgnoreCase))
			.Where(x => isProcessor == x.name.StartsWith("Processor", StringComparison.OrdinalIgnoreCase))
			.Where(x => x.schema.Properties.Any(p => p.Key == "webhook_code"))
			.ToList();

		var types = new HashSet<(string jsonName, string name)>();
		var codes = new HashSet<(string jsonName, string name)>();

		foreach (var (schema, name) in schemas)
		{
			var entityName = s_nameFixups.GetValueOrDefault(name, name);
			AddSchemaEntity("Webhook", entityName, baseType, schema, SchemaType.Record);

			var se = s_schemaEntities[entityName];
			var type = se.Properties!
				.Single(p => p.Name == "WebhookType");
			var code = se.Properties!
				.Single(p => p.Name == "WebhookCode");

			webhookMap[(type.Description!, code.Description!)] = entityName;
			_ = types.Add((type.JsonName, type.Description!));
			_ = codes.Add((code.JsonName, code.Description!));
		}

		s_schemaEntities[prefix + "WebhookType"] = new()
		{
			SchemaType = SchemaType.Enum,
			BasePath = "Entity",
			Name = prefix + "WebhookType",
			Description = "A list of supported Webhook Payload types.",
			Properties =
			[
				.. types
					.Select(e => new Property(
						e.jsonName,
						string.Empty,
						e.name,
						null
					))
			],
		};

		s_schemaEntities[prefix + "WebhookCode"] = new()
		{
			SchemaType = SchemaType.Enum,
			BasePath = "Entity",
			Name = prefix + "WebhookCode",
			Description = "A list of supported Webhook Payload codes.",
			Properties =
			[
				.. codes
					.Select(e => new Property(
						e.jsonName,
						string.Empty,
						e.name,
						null
					))
			],
		};
	}

	private static void AddAccountSubtype(OpenApiDocument doc, string subtypeName, string descriptionSchemaName)
	{
		var schema = doc.Components.Schemas[subtypeName];
		var descriptions = doc.Components.Schemas[descriptionSchemaName].Properties;
		s_schemaEntities[subtypeName] = new()
		{
			SchemaType = SchemaType.Enum,
			BasePath = "Entity",
			Name = subtypeName,
			Description = FixupDescription(schema.Description),
			Properties =
			[
				.. schema.Enum
					.OfType<OpenApiString>()
					.Select(e => new Property(
						e.Value,
						string.Empty,
						GetEnumName(e.Value),
						e.Value == "all" ? "Allow all of the above subtypes" : descriptions[e.Value].Description
					))
			],
		};
	}

	private static string FormatDescription(string? description, int index)
	{
		var prefix = "/// ".PadLeft(index + 4, '\t');
		description ??= string.Empty;
		return string.Join(Environment.NewLine,
			description.Split(["\r\n", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries)
				.Select(l => $"{prefix}<para>{l}</para>")
				.DefaultIfEmpty(prefix));
	}

	private static void SaveApis(string plaidSrcPath)
	{
		var template = Template.Parse(GetTemplate("Api"));
		foreach (var g in s_apiCalls.GroupBy(a => a.BasePath))
		{
			var source = template.Render(new
			{
				Methods = g
					.Select(m => new
					{
						m.MethodName,
						m.RequestType,
						m.ResponseType,
						Description = FormatDescription(m.Description, 0),
						m.Uri,
						Url = m.ExternalUrl,
					}),
			});

			var apiFolder = Path.Combine(plaidSrcPath, g.Key);
			_ = Directory.CreateDirectory(apiFolder);
			File.WriteAllText(Path.Combine(apiFolder, "PlaidClient.cs"), source);
		}
	}

	private static void SaveSchemas(string plaidSrcPath)
	{
		var l = s_schemaEntities.Values
			.ToLookup(i => i.SchemaType);

		SaveClasses(plaidSrcPath, l[SchemaType.Class]);
		SaveRecords(plaidSrcPath, l[SchemaType.Record]);
		SaveEnums(plaidSrcPath, l[SchemaType.Enum]);
	}

	private static void SaveClasses(string plaidSrcPath, IEnumerable<SchemaEntity> classes)
	{
		var template = Template.Parse(GetTemplate("ClassType"));
		foreach (var i in classes)
		{
			var source = template.Render(new
			{
				i.Name,
				i.BasePath,
				IsRequest = i.BaseType == BaseType.Request,
				Description = FormatDescription(i.Description, 0),
				Properties = i.Properties
					?.Select(p => new
					{
						p.Type,
						p.Name,
						p.JsonName,
						Description = FormatDescription(p.Description, 0),
						p.IsDeprecated,
					})
					?? [],
			});

			var baseFolder = Path.Combine(plaidSrcPath, i.BasePath);
			_ = Directory.CreateDirectory(baseFolder);
			File.WriteAllText(Path.Combine(baseFolder, i.Name + ".cs"), source);
		}
	}

	private static void SaveRecords(string plaidSrcPath, IEnumerable<SchemaEntity> records)
	{
		var template = Template.Parse(GetTemplate("RecordType"));
		foreach (var i in records)
		{
			var source = template.Render(new
			{
				i.Name,
				i.BasePath,
				Base = i.BaseType switch
				{
					BaseType.Webhook => "Webhook",
					BaseType.Response => "Response",
					BaseType.ProcessorWebhook => "ProcessorWebhook",
					BaseType.Request => throw new NotSupportedException(),
					BaseType.None or _ => "",
				},
				Description = FormatDescription(i.Description, 0),

				WebhookType = i.Properties
					?.FirstOrDefault(p => p.Name == "WebhookType")
					.Description,
				WebhookCode = i.Properties
					?.FirstOrDefault(p => p.Name == "WebhookCode")
					.Description,

				Properties = i.Properties
					?.ExceptBy(["WebhookType", "WebhookCode"], x => x.Name)
					?.Select(p => new
					{
						p.Type,
						p.Name,
						p.JsonName,
						Description = FormatDescription(p.Description, 0),
						p.IsDeprecated,
					})
					?? [],
			});

			var baseFolder = Path.Combine(plaidSrcPath, i.BasePath);
			_ = Directory.CreateDirectory(baseFolder);
			File.WriteAllText(Path.Combine(baseFolder, i.Name + ".cs"), source);
		}
	}

	private static readonly Property s_unknownProperty =
		new(
			"undefined",
			string.Empty,
			"Undefined",
			"Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library."
		);

	private static void SaveEnums(string plaidSrcPath, IEnumerable<SchemaEntity> enums)
	{
		var template = Template.Parse(GetTemplate("EnumType"));
		foreach (var i in enums)
		{
			IEnumerable<Property> list = i.Properties ?? [];
			if (!list.Any(p => p.Name == "Undefined"))
				list = list.Append(s_unknownProperty);

			var source = template.Render(new
			{
				i.BasePath,
				i.Name,
				Description = FormatDescription(i.Description, 0),
				Properties = list
					.Select(p => new
					{
						p.JsonName,
						p.Name,
						Description = FormatDescription(p.Description, 0),
					})
			});
			File.WriteAllText(Path.Combine(plaidSrcPath, i.BasePath, i.Name + ".cs"), source);
		}
	}

	private static void SaveConverterMap(string plaidSrcPath, bool isProcessor, Dictionary<(string type, string code), string> webhookMap)
	{
		var template = Template.Parse(GetTemplate("WebhookConverterMap"));
		var prefix = isProcessor ? "Processor" : "";
		var source = template.Render(new
		{
			Prefix = prefix,
			Hooks = webhookMap
				.Select(kvp => new { Type = kvp.Key.type, Code = kvp.Key.code, kvp.Value, })
		});
		File.WriteAllText(Path.Combine(plaidSrcPath, "Converters", prefix + "WebhookBaseConverter.Map.cs"), source);
	}

	private static string GetTemplate(string templateName)
	{
		using var stream = Assembly
			.GetExecutingAssembly()
			.GetManifestResourceStream(
				typeof(Program),
				$"{templateName}.sbntxt"
			)!;

		using var reader = new StreamReader(stream);
		return reader.ReadToEnd();
	}

	private static IList<IOpenApiAny> GetEnumValues(OpenApiSchema schema)
	{
		if (schema.Enum is not null)
		{
			return schema.Enum;
		}

		foreach (var s in schema.AllOf)
		{
			if (GetEnumValues(s) is { Count: > 0 } values)
				return values;
		}

		return [];
	}
}

internal enum SchemaType
{
	None,
	Class,
	Record,
	Enum,
}

internal enum BaseType
{
	None,
	Request,
	Response,
	Webhook,
	ProcessorWebhook,
}

internal record struct ApiCall(string Uri, string BasePath, string MethodName, string Description, string ExternalUrl, string RequestType, string ResponseType);
internal record struct Property(string JsonName, string Type, string Name, string? Description, bool IsDeprecated = false);

internal sealed class SchemaEntity
{
	public SchemaType SchemaType { get; set; }
	public string BasePath { get; init; } = default!;
	public string Name { get; init; } = default!;
	public string Description { get; init; } = default!;
	public BaseType BaseType { get; set; }
	public IReadOnlyList<Property>? Properties { get; set; } = default!;
}
