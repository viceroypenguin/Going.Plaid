using System.Text.Json;
using Going.Plaid;
using Going.Plaid.Converters;
using Going.Plaid.Entity;
using Going.Plaid.Webhook;
using Xunit;

namespace Plaid.Tests.Tests;

public class WebhookConverterTests
{
	private static readonly JsonSerializerOptions s_options = new JsonSerializerOptions
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
		const string validJson = @"{""webhook_type"":""Assets"",""webhook_code"":""ProductReady"",""asset_report_id"":null,""report_type"":null,""environment"":""sandbox""}";

		var payload = JsonSerializer.Deserialize<WebhookBase>(validJson, s_options);
		Assert.IsType<AssetsProductReadyWebhook>(payload);
		Assert.Equal(validJson, payload.RawJson);
	}

	[Fact]
	public void ParseUnknownWebhook()
	{
		const string invalidJson = @"{""webhook_type"":""Assets"",""webhook_code"":""ProductTesting"",""asset_report_id"":null,""report_type"":null,""environment"":""sandbox""}";

		var payload = JsonSerializer.Deserialize<WebhookBase>(invalidJson, s_options);
		Assert.IsType<UndefinedWebhook>(payload);
		Assert.Equal(WebhookType.Assets, payload.WebhookType);
		Assert.Equal(WebhookCode.Undefined, payload.WebhookCode);

		Assert.Equal(invalidJson, payload.RawJson);
	}
}
