using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using CaseExtensions;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

namespace PlaidOpenApiParser;

static class Program
{
	static void Main(string[] args)
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
			// throw new InvalidOperationException("Invalid plaid yaml file.");
		}

		ProcessUris(doc);
		ProcessAccountTypes(doc);

		var plaidSrcPath = Path.Combine(basePath, "src", "Plaid");
		if (!Directory.Exists(Path.Combine(plaidSrcPath, "Entity")))
			Directory.CreateDirectory(Path.Combine(plaidSrcPath, "Entity"));

		SaveApis(plaidSrcPath);
		SaveSchemas(plaidSrcPath);
	}

	private static string GetBasePath()
	{
		var path = Environment.CurrentDirectory;
		while (!Directory.Exists(Path.Combine(path, "plaid-openapi")))
			path = Path.GetDirectoryName(path)!;
		return path;
	}

	private static readonly List<ApiCall> apiCalls = new();
	private static readonly Dictionary<string, SchemaEntity> schemaEntities = new();
	private static readonly Dictionary<string, string> nameFixups = new()
	{
		["ACHClass"] = "AchClass",
		["APR"] = "Apr",
		["NumbersACH"] = "NumbersAch",
		["NumbersEFT"] = "NumbersEft",
		["NumbersBACS"] = "NumbersBacs",
		["Transaction Location"] = "Location",
		["transaction_code"] = "TransactionCode",
		["Error"] = "PlaidException",
		["YTDGrossIncomeSummaryFieldNumber"] = "YtdGrossIncomeSummaryFieldNumber",
		["YTDNetIncomeSummaryFieldNumber"] = "YtdNetIncomeSummaryFieldNumber",
	};
	private static readonly string[] excludes = new[]
	{
		"PlaidException",
		"AccountType",
		"OverrideAccountType",
		"StandaloneAccountType",
		"DepositoryAccount",
		"CreditAccount",
		"LoanAccount",
		"InvestmentAccountSubtype",
		"AccountSubtype",
	};

	private static void ProcessUris(OpenApiDocument doc)
	{
		foreach (var (uri, item) in doc.Paths)
		{
			var basePath = uri[1..].Split('/')[0].ToPascalCase();
			var op = item.Operations[OperationType.Post];

			if (!op.Responses["200"].Content.ContainsKey("application/json"))
				continue;

			if (op.Responses["200"].Content["application/json"].Schema == default)
				continue;

			var requestSchema = op.RequestBody.Content["application/json"].Schema;
			AddSchemaEntity(basePath, requestSchema.Reference.Id, requestSchema, SchemaType.Class);

			var responseSchema = op.Responses["200"].Content["application/json"].Schema;
			AddSchemaEntity(basePath, responseSchema.Reference.Id, responseSchema, SchemaType.Record);

			apiCalls.Add(new(
				uri,
				basePath,
				string.Concat(uri[1..].Split('/').Select(s => s.ToPascalCase())),
				FixupDescription(op.Description ?? op.Summary),
				op.ExternalDocs?.Url?.ToString() ?? string.Empty,
				requestSchema.Reference.Id,
				responseSchema.Reference.Id));
		}
	}

	private static void AddSchemaEntity(string basePath, string name, OpenApiSchema schema, SchemaType type)
	{
		if (excludes.Contains(name)) return;

		if (schemaEntities.ContainsKey(name))
		{
			if (schemaEntities[name].SchemaType == SchemaType.Record
				&& type == SchemaType.Class)
			{
				schemaEntities[name].SchemaType = SchemaType.Class;
			}

			return;
		}

		if (type == SchemaType.Enum)
		{
			var (pd, ed) = ParseEnumDescription(schema.Description);

			static string GetEnumName(string name) =>
				$"{(char.IsDigit(name[0]) ? "_" : "")}{name.ToLower().ToPascalCase()}";

			schemaEntities[name] = new()
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
			// hard-coded. blech
			if (name == "ExternalPaymentScheduleGet")
			{
				type = SchemaType.Class;
			}

			var e = schemaEntities[name] = new()
			{
				SchemaType = type,
				BasePath = basePath,
				Name = name,
				Description = GetPropertyDescription(schema),
			};

			// hard-coded. blech
			if (name == "PaymentInitiationRecipientGetResponse"
				|| name == "PaymentInitiationPaymentGetResponse")
			{
				schema = schema.AllOf[0];
			}

			if (schema.AllOf.Any())
			{
				foreach (var s in schema.AllOf)
				{
					if (s.Reference != null)
					{
						e.BaseClass = GetPropertyType(
							name,
							string.Empty,
							s,
							type);
					}
					else
					{
						schema = s;
					}
				}
			}

			e.Properties = schema.Properties
				.Where(p => !(
					(name.EndsWith("Request")
						&& (p.Key == "client_id"
							|| p.Key == "secret"
							|| p.Key == "access_token"))
					|| (name.EndsWith("Response") && p.Key == "request_id")))
				.Select(p =>
				{
					var propertyName = p.Key.ToLower().ToPascalCase();
					var typeName = GetPropertyType(name, propertyName, p.Value, type);
					if (p.Value.Nullable)
						typeName += "?";
					return new Property(p.Key, typeName, propertyName, GetPropertyDescription(p.Value));
				})
				.ToList();
		}
	}

	private static string PrefixPlaidUrl(string url) =>
		url.StartsWith("/")
			? "https://plaid.com" + url
			: url;

	private static string FixLinkBlocks(string description) =>
		Regex.Replace(
			description,
			@"\[([^]]+)\]\(([^)]+)\)",
			m => "<a href=\"" + PrefixPlaidUrl(m.Groups[2].Value) + "\">" + m.Groups[1].Value + "</a>");

	private static string FixBrackets(string description) =>
		Regex.Replace(
			description,
			@"<(\w+)>",
			"$1");

	private static string FixCodeBlocks(string description) =>
		Regex.Replace(
			description,
			@"`([^`]+)`",
			"<c>$1</c>");

	private static string FixupDescription(string description) =>
		string.IsNullOrWhiteSpace(description) ? string.Empty :
		FixCodeBlocks(FixBrackets(FixLinkBlocks(description))).TrimEnd();

	private static readonly string[] newLineSplits = { "\r\n", "\r", "\n", };
	private static (string enumDescription, Dictionary<string, string> propertyDescription) ParseEnumDescription(string description)
	{
		if (string.IsNullOrWhiteSpace(description))
			return (string.Empty, new Dictionary<string, string>());
		var lines = description.Split(newLineSplits, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

		if (lines.Length == 1)
			return (FixCodeBlocks(lines[0]), new Dictionary<string, string>());

		if (lines.Any(l => l.StartsWith('`')))
		{
			var ed = lines.FirstOrDefault(l => !l.StartsWith('`'))
				?? string.Empty;

			ed = FixupDescription(ed);

			var pd = lines
				.Where(l => l.StartsWith('`'))
				.Select(l => Regex.Match(l, "^`\"?(.+?)\"?:?`\\s*:?-?\\s*(.*)$"))
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
			if (schema.Description.Contains("ISO8601"))
				return "DateTimeOffset";
			if (schema.Description.Contains("ISO 8601"))
				return "DateTimeOffset";
		}

		var entityType = (schema.Enum?.Any() ?? false) ? SchemaType.Enum : type;
		if (schema.Type == "string" && entityType != SchemaType.Enum)
			return "string";

		if (schema.Reference != null)
		{
			if (schema.Reference.Id.EndsWith("Nullable"))
			{
				var realType = schema.AllOf.First();
				return GetPropertyType(className, propertyName, realType, entityType);
			}
			else if (schema.Reference.Id == "BankTransferMetadata")
				return "IReadOnlyDictionary<string, string>";
		}

		var entityName = schema.Title ?? schema.Reference?.Id;
		if (string.IsNullOrWhiteSpace(entityName))
		{
			var parentName = className.EndsWith("Object") ? className[..^6] : className;
			entityName = parentName
				+ propertyName.ToPascalCase()
				+ (entityType == SchemaType.Enum ? "Enum" : "Object");
		}

		entityName = nameFixups.GetValueOrDefault(entityName, entityName);
		AddSchemaEntity("Entity", entityName, schema, entityType);
		return entityName == "PlaidException"
			? "Exceptions.PlaidException"
			: $"Entity.{entityName}";
	}

	private static void ProcessAccountTypes(OpenApiDocument doc)
	{
		static string GetEnumName(string name) =>
			$"{(char.IsDigit(name[0]) ? "_" : "")}{name.ToLower().ToPascalCase()}";

		var pd = new Dictionary<string, string>()
		{
			["depository"] = FixupDescription(
				doc.Components.Schemas["DepositoryAccount"].Description),
			["credit"] = FixupDescription(
				doc.Components.Schemas["CreditAccount"].Description),
			["loan"] = FixupDescription(
				doc.Components.Schemas["LoanAccount"].Description),
			["investment"] = FixupDescription(
				doc.Components.Schemas["InvestmentAccountSubtype"].Description),
			["brokerage"] =
				ParseEnumDescription(doc.Components.Schemas["AccountType"].Description)
					.propertyDescription["brokerage"],
			["other"] = FixupDescription(
				doc.Components.Schemas["StandaloneAccountType"]
					.Properties["other"].Description),
		};

		schemaEntities["AccountType"] = new()
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

		var s = doc.Components.Schemas["AccountSubtype"];
		foreach (var p in doc.Components.Schemas["DepositoryAccount"].Properties)
			pd[p.Key] = FixupDescription(p.Value.Description).TrimEnd();
		foreach (var p in doc.Components.Schemas["CreditAccount"].Properties)
			pd[p.Key] = FixupDescription(p.Value.Description).TrimEnd();
		foreach (var p in doc.Components.Schemas["LoanAccount"].Properties)
			pd[p.Key] = FixupDescription(p.Value.Description).TrimEnd();
		foreach (var p in doc.Components.Schemas["InvestmentAccountSubtype"].Properties)
			pd[p.Key] = FixupDescription(p.Value.Description).TrimEnd();

		schemaEntities["AccountSubtype"] = new()
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

	private static string FormatDescription(string description, int index)
	{
		var prefix = "/// ".PadLeft(index + 4, '\t');
		return string.Join(Environment.NewLine,
			description.Split(newLineSplits, StringSplitOptions.RemoveEmptyEntries)
				.Select(l => $"{prefix}<para>{l}</para>")
				.DefaultIfEmpty(prefix));
	}

	private static void SaveApis(string plaidSrcPath)
	{
		foreach (var g in apiCalls.GroupBy(a => a.BasePath))
		{
			var apiFolder = Path.Combine(plaidSrcPath, g.Key);
			if (!Directory.Exists(apiFolder))
				Directory.CreateDirectory(apiFolder);

			static string remarks(string url) =>
				string.IsNullOrWhiteSpace(url) ? string.Empty :
				$@"
	/// <remarks><see href=""{ PrefixPlaidUrl(url)}"" /></remarks>";

			var methods = g.Select(c => $@"
	/// <summary>
{FormatDescription(c.Description, 1)}
	/// </summary>{remarks(c.ExternalUrl)}
	public Task<{g.Key}.{c.ResponseType}> {c.MethodName}Async({g.Key}.{c.RequestType} request) =>
		PostAsync(""{c.Uri}"", request)
			.ParseResponseAsync<{g.Key}.{c.ResponseType}>();");

			var body = $@"namespace Going.Plaid;

public sealed partial class PlaidClient
{{{string.Join(Environment.NewLine, methods)}
}}";

			File.WriteAllText(Path.Combine(apiFolder, "PlaidClient.cs"), body);
		}
	}

	private static void SaveSchemas(string plaidSrcPath)
	{
		foreach (var i in schemaEntities.Values)
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
		if (i.BaseClass != null)
			basePath = " : " + i.BaseClass;
		else if (i.Name.EndsWith("Request"))
			basePath = " : RequestBase";

		var body = $@"namespace Going.Plaid.{i.BasePath};

/// <summary>
{FormatDescription(i.Description, 0)}
/// </summary>
public {(i.Name.EndsWith("Request") ? "partial class" : "class")} {i.Name}{basePath}
{{{string.Join(Environment.NewLine, properties)}
}}";

		File.WriteAllText(Path.Combine(plaidSrcPath, i.BasePath, i.Name + ".cs"), body);
	}

	private static void SaveRecord(string plaidSrcPath, SchemaEntity i)
	{
		var properties = i.Properties?.Select(p => $@"
	/// <summary>
{FormatDescription(p.Description ?? string.Empty, 1)}
	/// </summary>
	[JsonPropertyName(""{p.JsonName}"")]
	public {p.Type} {p.Name} {{ get; init; }} = default!;")
			?? Array.Empty<string>();

		var basePath = string.Empty;
		if (i.BaseClass != null)
			basePath = " : " + i.BaseClass;
		else if (i.Name.EndsWith("Response"))
			basePath = " : ResponseBase";

		var body = $@"namespace Going.Plaid.{i.BasePath};

/// <summary>
{FormatDescription(i.Description, 0)}
/// </summary>
public record {i.Name}{basePath}
{{{string.Join(Environment.NewLine, properties)}
}}";

		File.WriteAllText(Path.Combine(plaidSrcPath, i.BasePath, i.Name + ".cs"), body);
	}

	private static readonly Property unknownProperty = new("undefined", string.Empty, "Undefined", "Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.");
	private static void SaveEnum(string plaidSrcPath, SchemaEntity i)
	{
		IEnumerable<Property> list = i.Properties ?? Array.Empty<Property>();
		if (!list.Any(p => p.Name == "Undefined"))
			list = list.Append(unknownProperty);
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
}

public enum SchemaType
{
	Class,
	Record,
	Enum,
}

public record struct ApiCall(string Uri, string BasePath, string MethodName, string Description, string ExternalUrl, string RequestType, string ResponseType);
public record struct Property(string JsonName, string Type, string Name, string? Description);

public class SchemaEntity
{
	public SchemaType SchemaType { get; set; }
	public string BasePath { get; init; } = default!;
	public string Name { get; init; } = default!;
	public string Description { get; init; } = default!;
	public string? BaseClass { get; set; }
	public IReadOnlyList<Property>? Properties { get; set; } = default!;
}
