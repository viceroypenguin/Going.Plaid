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
		ProcessWebhookTypes(doc);

		var plaidSrcPath = Path.Combine(basePath, "src", "Plaid");
		SaveApis(plaidSrcPath);
		SaveSchemas(plaidSrcPath);
		SaveConverterMap(plaidSrcPath);
	}

	private static string GetBasePath()
	{
		var path = Environment.CurrentDirectory;
		while (!Directory.Exists(Path.Combine(path, "plaid-openapi")))
			path = Path.GetDirectoryName(path)!;
		return path;
	}

	private static readonly List<ApiCall> ApiCalls = [];
	private static readonly Dictionary<string, SchemaEntity> SchemaEntities = [];
	private static readonly Dictionary<(string type, string code), string> WebhookDictionaryMap = [];
	private static readonly Dictionary<string, string> NameFixups = new()
	{
		["ACHClass"] = "AchClass",
		["APR"] = "Apr",
		["ISO Currency Code"] = "IsoCurrencyCode",
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
	private static readonly string[] Excludes =
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
	private static readonly string[] ExcludeApis =
	[
		"/credit/asset_report/freddie_mac/get",
	];

	private static void ProcessUris(OpenApiDocument doc)
	{
		foreach (var (uri, item) in doc.Paths)
		{
			if (ExcludeApis.Contains(uri))
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

			ApiCalls.Add(new(
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
		if (Excludes.Contains(name)) return;

		if (SchemaEntities.TryGetValue(name, out var value))
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

			SchemaEntities[name] = new()
			{
				SchemaType = type,
				BasePath = basePath,
				Name = name,
				Description = pd,
				Properties = schema.Enum
					.OfType<OpenApiString>()
					.Select(e => new Property(
						e.Value,
						string.Empty,
						GetEnumName(e.Value),
						ed.GetValueOrDefault(e.Value)))
					.ToList(),
			};
		}
		else
		{
			var e = SchemaEntities[name] = new()
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

			e.Properties = properties
				.Where(p => baseType switch
				{
					BaseType.Request => p.Key is not "client_id" and not "secret" and not "access_token",
					BaseType.Response => p.Key is not "request_id" and not "error",
					BaseType.Webhook => p.Key is not "environment",
					BaseType.None => true,
					_ => true,
				})
				.Select(p =>
				{
					var propertyName = p.Key.ToLower(null).ToPascalCase();
					if (baseType == BaseType.Webhook && p.Key is "webhook_type" or "webhook_code")
					{
						var code = p.Value.Description.Trim('`', '"');
						return new Property(code, propertyName, propertyName, code.ToLower(null).ToPascalCase());
					}

					var typeName = GetPropertyType(name, propertyName, p.Value, type);
					if (p.Value.Nullable || !schema.Required.Contains(p.Key))
						typeName += "?";
					return new Property(p.Key, typeName, propertyName, GetPropertyDescription(p.Value));
				})
				.ToList();
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

	private static readonly string[] NewLineSplits = ["\r\n", "\r", "\n"];

	[GeneratedRegex("^`\"?(.+?)\"?:?`\\s*:?-?\\s*(.*)$")]
	private static partial Regex EnumDescriptionRegex();

	private static (string enumDescription, Dictionary<string, string> propertyDescription) ParseEnumDescription(string description)
	{
		if (string.IsNullOrWhiteSpace(description))
			return (string.Empty, new Dictionary<string, string>());
		if (description.StartsWith("The asynchronous event to be simulated.", StringComparison.OrdinalIgnoreCase))
			return (FixupDescription(description), new Dictionary<string, string>());

		var lines = description.Split(NewLineSplits, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

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
		var entityType = (type.Enum?.Any() ?? false) ? 2 : 1;
		return
			entityType == 2
			? ParseEnumDescription(type.Description)
				.enumDescription
			: FixupDescription(type.Description);
	}

	private static string GetPropertyType(string className, string propertyName, OpenApiSchema schema, SchemaType type)
	{
		if (schema.Type == "array")
		{
			return $"IReadOnlyList<{GetPropertyType(className, propertyName, schema.Items, type)}>";
		}

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

		var entityType = (schema.Enum?.Any() ?? false) ? SchemaType.Enum : type;
		if (schema.Type == "string" && entityType != SchemaType.Enum)
			return "string";

		if (schema.AllOf.Count == 1
			&& schema.AllOf[0].Type == "string")
			return "string";

		if (schema.Reference != null)
		{
			if (schema.Reference.Id.EndsWith("Nullable", StringComparison.OrdinalIgnoreCase))
			{
				if (schema.AllOf.Count > 0)
				{
					var realType = schema.AllOf.First();
					return GetPropertyType(className, propertyName, realType, entityType);
				}
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

		entityName = NameFixups.GetValueOrDefault(entityName, entityName);
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

		SchemaEntities["AccountType"] = new()
		{
			SchemaType = SchemaType.Enum,
			BasePath = "Entity",
			Name = "AccountType",
			Description = "The general type of an account.",
			Properties = pd
				.Select(e => new Property(
					e.Key,
					string.Empty,
					GetEnumName(e.Key),
					e.Value))
				.ToList(),
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

		SchemaEntities["AccountSubtype"] = new()
		{
			SchemaType = SchemaType.Enum,
			BasePath = "Entity",
			Name = "AccountSubtype",
			Description = "The specific type of an account.",
			Properties = pd
				.Select(e => new Property(
					e.Key,
					string.Empty,
					GetEnumName(e.Key),
					e.Value))
				.ToList(),
		};
	}

	private static void ProcessWebhookTypes(OpenApiDocument doc)
	{
		var schemas = doc.Components.Schemas
			.Select(x => x.Value)
			.Select(x => (schema: x, name: x.Title ?? x.Reference?.Id!))
			.Where(x => !string.IsNullOrWhiteSpace(x.name))
			.Where(x => x.name.EndsWith("Webhook", StringComparison.OrdinalIgnoreCase))
			.Where(x => x.schema.Properties.Any(p => p.Key == "webhook_code"))
			.ToList();

		var types = new HashSet<(string jsonName, string name)>();
		var codes = new HashSet<(string jsonName, string name)>();

		foreach (var (schema, name) in schemas)
		{
			var entityName = NameFixups.GetValueOrDefault(name, name);
			AddSchemaEntity("Webhook", entityName, BaseType.Webhook, schema, SchemaType.Record);

			var se = SchemaEntities[entityName];
			var type = se.Properties!
				.Single(p => p.Name == "WebhookType");
			var code = se.Properties!
				.Single(p => p.Name == "WebhookCode");

			WebhookDictionaryMap[(type.Description!, code.Description!)] = entityName;
			_ = types.Add((type.JsonName, type.Description!));
			_ = codes.Add((code.JsonName, code.Description!));
		}

		SchemaEntities["WebhookType"] = new()
		{
			SchemaType = SchemaType.Enum,
			BasePath = "Entity",
			Name = "WebhookType",
			Description = "A list of supported Webhook Payload types.",
			Properties = types
				.Select(e => new Property(
					e.jsonName,
					string.Empty,
					e.name,
					null))
				.ToList(),
		};

		SchemaEntities["WebhookCode"] = new()
		{
			SchemaType = SchemaType.Enum,
			BasePath = "Entity",
			Name = "WebhookCode",
			Description = "A list of supported Webhook Payload codes.",
			Properties = codes
				.Select(e => new Property(
					e.jsonName,
					string.Empty,
					e.name,
					null))
				.ToList(),
		};
	}

	private static void AddAccountSubtype(OpenApiDocument doc, string subtypeName, string descriptionSchemaName)
	{
		var schema = doc.Components.Schemas[subtypeName];
		var descriptions = doc.Components.Schemas[descriptionSchemaName].Properties;
		SchemaEntities[subtypeName] = new()
		{
			SchemaType = SchemaType.Enum,
			BasePath = "Entity",
			Name = subtypeName,
			Description = FixupDescription(schema.Description),
			Properties = schema.Enum
				.OfType<OpenApiString>()
				.Select(e => new Property(
					e.Value,
					string.Empty,
					GetEnumName(e.Value),
					e.Value == "all" ? "Allow all of the above subtypes" : descriptions[e.Value].Description))
				.ToList(),
		};
	}

	private static string FormatDescription(string description, int index)
	{
		var prefix = "/// ".PadLeft(index + 4, '\t');
		return string.Join(Environment.NewLine,
			description.Split(NewLineSplits, StringSplitOptions.RemoveEmptyEntries)
				.Select(l => $"{prefix}<para>{l}</para>")
				.DefaultIfEmpty(prefix));
	}

	private static void SaveApis(string plaidSrcPath)
	{
		foreach (var g in ApiCalls.GroupBy(a => a.BasePath))
		{
			static string Remarks(string url) =>
				string.IsNullOrWhiteSpace(url) ? string.Empty :
				$@"
	/// <remarks><see href=""https://plaid.com/docs{url}"" /></remarks>";

			var methods = g.Select(c => $@"
	/// <summary>
{FormatDescription(c.Description, 1)}
	/// </summary>{Remarks(c.ExternalUrl)}
	public Task<{c.ResponseType}> {c.MethodName}Async({c.RequestType} request) =>
		PostAsync(""{c.Uri}"", request)
			.ParseResponseAsync<{c.ResponseType}>();");

			var body = $@"namespace Going.Plaid;

public sealed partial class PlaidClient
{{{string.Join(Environment.NewLine, methods)}
}}";

			var apiFolder = Path.Combine(plaidSrcPath, g.Key);
			_ = Directory.CreateDirectory(apiFolder);
			File.WriteAllText(Path.Combine(apiFolder, "PlaidClient.cs"), body);
		}
	}

	private static void SaveSchemas(string plaidSrcPath)
	{
		foreach (var i in SchemaEntities.Values)
		{
			switch (i.SchemaType)
			{
				case SchemaType.Class:
					SaveClass(plaidSrcPath, i);
					break;
				case SchemaType.Record:
					SaveRecord(plaidSrcPath, i);
					break;
				case SchemaType.Enum:
					SaveEnum(plaidSrcPath, i);
					break;
				case SchemaType.None:
				default:
					throw new NotSupportedException();
			}
		}
	}

	private static void SaveClass(string plaidSrcPath, SchemaEntity i)
	{
		var properties = i.Properties?.Select(p => $@"
	/// <summary>
{FormatDescription(p.Description ?? string.Empty, 1)}
	/// </summary>
	[JsonPropertyName(""{p.JsonName}"")]
	public {p.Type} {p.Name} {{ get; set; }} = default!;")
			?? Array.Empty<string>();

		var basePath = string.Empty;
		if (i.BaseType == BaseType.Request)
			basePath = " : RequestBase";

		var body = $@"namespace Going.Plaid.{i.BasePath};

/// <summary>
{FormatDescription(i.Description, 0)}
/// </summary>
public {(i.Name.EndsWith("Request", StringComparison.OrdinalIgnoreCase) ? "partial class" : "class")} {i.Name}{basePath}
{{{string.Join(Environment.NewLine, properties)}
}}";

		var baseFolder = Path.Combine(plaidSrcPath, i.BasePath);
		_ = Directory.CreateDirectory(baseFolder);
		File.WriteAllText(Path.Combine(baseFolder, i.Name + ".cs"), body);
	}

	private static void SaveRecord(string plaidSrcPath, SchemaEntity i)
	{
		var properties = i.Properties
			?.ExceptBy(["WebhookType", "WebhookCode"], x => x.Name)
			?.Select(p => $@"
	/// <summary>
{FormatDescription(p.Description ?? string.Empty, 1)}
	/// </summary>
	[JsonPropertyName(""{p.JsonName}"")]
	public {p.Type} {p.Name} {{ get; init; }} = default!;")
			?? Array.Empty<string>();

		var basePath = string.Empty;
		if (i.BaseType == BaseType.Response)
			basePath = " : ResponseBase";
		else if (i.BaseType == BaseType.Webhook)
		{
			var type = i.Properties!
				.Single(p => p.Name == "WebhookType")
				.Description;
			var code = i.Properties!
				.Single(p => p.Name == "WebhookCode")
				.Description;

			properties = properties
				.Prepend($@"
	/// <inheritdoc />
	[JsonPropertyName(""webhook_type"")]
	public override WebhookType WebhookType => WebhookType.{type};

	/// <inheritdoc />
	[JsonPropertyName(""webhook_code"")]
	public override WebhookCode WebhookCode => WebhookCode.{code};");

			basePath = " : WebhookBase";
		}

		var body = $@"namespace Going.Plaid.{i.BasePath};

/// <summary>
{FormatDescription(i.Description, 0)}
/// </summary>
public record {i.Name}{basePath}
{{{string.Join(Environment.NewLine, properties)}
}}";

		var baseFolder = Path.Combine(plaidSrcPath, i.BasePath);
		_ = Directory.CreateDirectory(baseFolder);
		File.WriteAllText(Path.Combine(baseFolder, i.Name + ".cs"), body);
	}

	private static readonly Property UnknownProperty = new("undefined", string.Empty, "Undefined", "Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.");
	private static void SaveEnum(string plaidSrcPath, SchemaEntity i)
	{
		IEnumerable<Property> list = i.Properties ?? Array.Empty<Property>();
		if (!list.Any(p => p.Name == "Undefined"))
			list = list.Append(UnknownProperty);
		var properties = list
			.Select(p => $@"
	/// <summary>
{FormatDescription(p.Description ?? string.Empty, 1)}
	/// </summary>
	[EnumMember(Value = ""{p.JsonName}"")]
	{p.Name},");
		var body = $@"namespace Going.Plaid.{i.BasePath};

/// <summary>
{FormatDescription(i.Description, 0)}
/// </summary>
public enum {i.Name}
{{{string.Join(Environment.NewLine, properties)}
}}";

		File.WriteAllText(Path.Combine(plaidSrcPath, i.BasePath, i.Name + ".cs"), body);
	}

	private static void SaveConverterMap(string plaidSrcPath)
	{
		var template = Template.Parse(GetTemplate("WebhookConverterMap"));
		var source = template.Render(new
		{
			Hooks = WebhookDictionaryMap
				.Select(kvp => new { Type = kvp.Key.type, Code = kvp.Key.code, kvp.Value, })
		});
		File.WriteAllText(Path.Combine(plaidSrcPath, "Converters", "WebhookBaseConverter.Map.cs"), source);
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
}

public enum SchemaType
{
	None,
	Class,
	Record,
	Enum,
}

public enum BaseType
{
	None,
	Request,
	Response,
	Webhook,
}

public record struct ApiCall(string Uri, string BasePath, string MethodName, string Description, string ExternalUrl, string RequestType, string ResponseType);
public record struct Property(string JsonName, string Type, string Name, string? Description);

public class SchemaEntity
{
	public SchemaType SchemaType { get; set; }
	public string BasePath { get; init; } = default!;
	public string Name { get; init; } = default!;
	public string Description { get; init; } = default!;
	public BaseType BaseType { get; set; }
	public IReadOnlyList<Property>? Properties { get; set; } = default!;
}
