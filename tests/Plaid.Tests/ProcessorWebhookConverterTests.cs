using System.Text.Json;
using Going.Plaid.Converters;
using Going.Plaid.Entity;
using Going.Plaid.Webhook;
using Xunit;

namespace Going.Plaid.Tests;

public class ProcessorWebhookConverterTests
{
	private static readonly JsonSerializerOptions s_options = new()
	{
		Converters =
		{
			new EnumConverterFactory(),
			new ProcessorWebhookBaseConverter(),
		},
	};

	[Fact]
	public void ParseValidWebhook()
	{
		const string ValidJson = /*lang=json,strict*/ """
			{"webhook_type":"Transactions","webhook_code":"InitialUpdate","new_transactions":0,"account_id":"","environment":"sandbox"}
			""";

		var payload = JsonSerializer.Deserialize<ProcessorWebhookBase>(ValidJson, s_options);
		_ = Assert.IsType<ProcessorInitialUpdateWebhook>(payload);
		Assert.Equal(ValidJson, payload.RawJson);
	}

	[Fact]
	public void ParseUnknownWebhook()
	{
		const string InvalidJson = /*lang=json,strict*/ """
			{"webhook_type":"Transactions","webhook_code":"Unknown","asset_report_id":null,"report_type":null,"environment":"sandbox"}
			""";

		var payload = JsonSerializer.Deserialize<ProcessorWebhookBase>(InvalidJson, s_options);
		_ = Assert.IsType<ProcessorUndefinedWebhook>(payload);
		Assert.Equal(ProcessorWebhookType.Transactions, payload.WebhookType);
		Assert.Equal(ProcessorWebhookCode.Undefined, payload.WebhookCode);

		Assert.Equal(InvalidJson, payload.RawJson);
	}
}
