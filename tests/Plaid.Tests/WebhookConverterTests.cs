using System.Text.Json;
using Going.Plaid.Converters;
using Going.Plaid.Entity;
using Going.Plaid.Webhook;
using Xunit;

namespace Going.Plaid.Tests;

public class WebhookConverterTests
{
	private static readonly JsonSerializerOptions s_options = new()
	{
		Converters =
		{
			new EnumConverterFactory(),
			new WebhookBaseConverter(),
		},
	};

	[Fact]
	public void ParseValidWebhook()
	{
		const string ValidJson = /*lang=json,strict*/ """
			{"webhook_type":"Assets","webhook_code":"ProductReady","asset_report_id":null,"report_type":null,"environment":"sandbox"}
			""";

		var payload = JsonSerializer.Deserialize<WebhookBase>(ValidJson, s_options);
		_ = Assert.IsType<AssetsProductReadyWebhook>(payload);
		Assert.Equal(ValidJson, payload.RawJson);
	}

	[Fact]
	public void ParseUnknownWebhook()
	{
		const string InvalidJson = /*lang=json,strict*/ """
			{"webhook_type":"Assets","webhook_code":"ProductTesting","asset_report_id":null,"report_type":null,"environment":"sandbox"}
			""";

		var payload = JsonSerializer.Deserialize<WebhookBase>(InvalidJson, s_options);
		_ = Assert.IsType<UndefinedWebhook>(payload);
		Assert.Equal(WebhookType.Assets, payload.WebhookType);
		Assert.Equal(WebhookCode.Undefined, payload.WebhookCode);

		Assert.Equal(InvalidJson, payload.RawJson);
	}
}
