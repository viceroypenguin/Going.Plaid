using Going.Plaid.Webhook;

namespace Going.Plaid.Converters;

/// <inheritdoc />
public partial class WebhookBaseConverter : JsonConverter<WebhookBase>
{
	/// <inheritdoc />
	public override WebhookBase? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
	{
		var element = JsonElement.ParseValue(ref reader);

		var enumText = element.GetProperty("webhook_type").GetString();
		var type = EnumConverterFactory.ParseEnumValue<WebhookType>(enumText);

		enumText = element.GetProperty("webhook_code").GetString();
		var code = EnumConverterFactory.ParseEnumValue<WebhookCode>(enumText);

		if (!Map.TryGetValue((type, code), out var webhookType))
		{
			return new UndefinedWebhook(type, code)
			{
				RawJson = element.GetRawText(),
				Environment = EnumConverterFactory.ParseEnumValue<Environment>(
					element.GetProperty("environment").GetString()),
			};
		}

		var webhookValue = element.Deserialize(webhookType, options) as WebhookBase;
		webhookValue!.RawJson = element.GetRawText();
		return webhookValue;
	}

	/// <inheritdoc />
	public override void Write(Utf8JsonWriter writer, WebhookBase value, JsonSerializerOptions options) =>
		JsonSerializer.Serialize(writer, value, value.GetType(), options);
}
