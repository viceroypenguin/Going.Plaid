using Going.Plaid.Webhook;

namespace Going.Plaid.Converters;

/// <inheritdoc />
public partial class ProcessorWebhookBaseConverter : JsonConverter<ProcessorWebhookBase>
{
	private static readonly Dictionary<(ProcessorWebhookType, ProcessorWebhookCode), Type> Map =
		new()
		{
			[(ProcessorWebhookType.Transactions, ProcessorWebhookCode.TransactionsRemoved)] = typeof(ProcessorTransactionsRemovedWebhook),
			[(ProcessorWebhookType.Transactions, ProcessorWebhookCode.DefaultUpdate)] = typeof(ProcessorDefaultUpdateWebhook),
			[(ProcessorWebhookType.Transactions, ProcessorWebhookCode.SyncUpdatesAvailable)] = typeof(ProcessorSyncUpdatesAvailableWebhook),
			[(ProcessorWebhookType.Transactions, ProcessorWebhookCode.RecurringTransactionsUpdate)] = typeof(ProcessorRecurringTransactionsUpdateWebhook),
			[(ProcessorWebhookType.Transactions, ProcessorWebhookCode.HistoricalUpdate)] = typeof(ProcessorHistoricalUpdateWebhook),
			[(ProcessorWebhookType.Transactions, ProcessorWebhookCode.InitialUpdate)] = typeof(ProcessorInitialUpdateWebhook),
		};
}
