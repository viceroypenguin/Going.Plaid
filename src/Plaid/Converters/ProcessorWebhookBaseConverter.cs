using Going.Plaid.Webhook;

namespace Going.Plaid.Converters;

/// <inheritdoc />
public partial class ProcessorWebhookBaseConverter : JsonConverter<ProcessorWebhookBase>
{
	/// <inheritdoc />
	public override ProcessorWebhookBase? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var element = JsonElement.ParseValue(ref reader);

		var enumText = element.GetProperty("webhook_type").GetString();
		var type = EnumConverterFactory.ParseEnumValue<ProcessorWebhookType>(enumText);

		enumText = element.GetProperty("webhook_code").GetString();
		var code = EnumConverterFactory.ParseEnumValue<ProcessorWebhookCode>(enumText);

		if (!s_map.TryGetValue((type, code), out var webhookType))
		{
			return new ProcessorUndefinedWebhook(type, code)
			{
				RawJson = element.GetRawText(),
				Environment = EnumConverterFactory.ParseEnumValue<Environment>(
					element.GetProperty("environment").GetString()),
			};
		}

		var webhookValue = element.Deserialize(webhookType, options) as ProcessorWebhookBase;
		webhookValue!.RawJson = element.GetRawText();
		return webhookValue;
	}

	/// <inheritdoc />
	public override void Write(Utf8JsonWriter writer, ProcessorWebhookBase value, JsonSerializerOptions options) =>
		JsonSerializer.Serialize(writer, value, value.GetType(), options);
}
