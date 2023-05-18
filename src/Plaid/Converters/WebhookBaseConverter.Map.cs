using Going.Plaid.Webhook;

namespace Going.Plaid.Converters;

/// <inheritdoc />
public partial class WebhookBaseConverter : JsonConverter<WebhookBase>
{
	private static readonly Dictionary<(WebhookType, WebhookCode), Type> Map =
		new()
		{
			[(WebhookType.Screening, WebhookCode.StatusUpdated)] = typeof(ScreeningStatusUpdatedWebhook),
			[(WebhookType.EntityScreening, WebhookCode.StatusUpdated)] = typeof(EntityScreeningStatusUpdatedWebhook),
			[(WebhookType.IdentityVerification, WebhookCode.StepUpdated)] = typeof(IdentityVerificationStepUpdatedWebhook),
			[(WebhookType.IdentityVerification, WebhookCode.Retried)] = typeof(IdentityVerificationRetriedWebhook),
			[(WebhookType.IdentityVerification, WebhookCode.StatusUpdated)] = typeof(IdentityVerificationStatusUpdatedWebhook),
			[(WebhookType.Transactions, WebhookCode.TransactionsRemoved)] = typeof(TransactionsRemovedWebhook),
			[(WebhookType.Transactions, WebhookCode.DefaultUpdate)] = typeof(DefaultUpdateWebhook),
			[(WebhookType.Transactions, WebhookCode.SyncUpdatesAvailable)] = typeof(SyncUpdatesAvailableWebhook),
			[(WebhookType.Transactions, WebhookCode.RecurringTransactionsUpdate)] = typeof(RecurringTransactionsUpdateWebhook),
			[(WebhookType.Identity, WebhookCode.DefaultUpdate)] = typeof(IdentityDefaultUpdateWebhook),
			[(WebhookType.Transactions, WebhookCode.HistoricalUpdate)] = typeof(HistoricalUpdateWebhook),
			[(WebhookType.Transactions, WebhookCode.InitialUpdate)] = typeof(InitialUpdateWebhook),
			[(WebhookType.Auth, WebhookCode.AutomaticallyVerified)] = typeof(FallbackAuthMicrodepositAutoVerifiedWebhook),
			[(WebhookType.Auth, WebhookCode.VerificationExpired)] = typeof(FallbackAuthMicrodepositVerificationExpiredWebhook),
			[(WebhookType.Item, WebhookCode.WebhookUpdateAcknowledged)] = typeof(WebhookUpdateAcknowledgedWebhook),
			[(WebhookType.Item, WebhookCode.PendingExpiration)] = typeof(PendingExpirationWebhook),
			[(WebhookType.Item, WebhookCode.Error)] = typeof(ItemErrorWebhook),
			[(WebhookType.Item, WebhookCode.LoginRepaired)] = typeof(ItemLoginRepairedWebhook),
			[(WebhookType.Income, WebhookCode.ProductReady)] = typeof(ItemProductReadyWebhook),
			[(WebhookType.BankTransfers, WebhookCode.BankTransfersEventsUpdate)] = typeof(BankTransfersEventsUpdateWebhook),
			[(WebhookType.Transfer, WebhookCode.TransferEventsUpdate)] = typeof(TransferEventsUpdateWebhook),
			[(WebhookType.Transfer, WebhookCode.RecurringNewTransfer)] = typeof(RecurringNewTransferWebhook),
			[(WebhookType.Transfer, WebhookCode.RecurringTransferSkipped)] = typeof(RecurringTransferSkippedWebhook),
			[(WebhookType.Transfer, WebhookCode.RecurringCancelled)] = typeof(RecurringCancelledWebhook),
			[(WebhookType.InvestmentsTransactions, WebhookCode.DefaultUpdate)] = typeof(InvestmentsDefaultUpdateWebhook),
			[(WebhookType.Holdings, WebhookCode.DefaultUpdate)] = typeof(HoldingsDefaultUpdateWebhook),
			[(WebhookType.Partner, WebhookCode.EndCustomerOauthStatusUpdated)] = typeof(PartnerEndCustomerOAuthStatusUpdatedWebhook),
			[(WebhookType.Liabilities, WebhookCode.DefaultUpdate)] = typeof(LiabilitiesDefaultUpdateWebhook),
			[(WebhookType.PaymentInitiation, WebhookCode.PaymentStatusUpdate)] = typeof(PaymentStatusUpdateWebhook),
			[(WebhookType.Wallet, WebhookCode.WalletTransactionStatusUpdate)] = typeof(WalletTransactionStatusUpdateWebhook),
			[(WebhookType.Item, WebhookCode.UserPermissionRevoked)] = typeof(UserPermissionRevokedWebhook),
			[(WebhookType.DepositSwitch, WebhookCode.SwitchStateUpdate)] = typeof(DepositSwitchStateUpdateWebhook),
			[(WebhookType.Income, WebhookCode.IncomeVerification)] = typeof(IncomeVerificationStatusWebhook),
			[(WebhookType.Income, WebhookCode.IncomeVerificationRiskSignals)] = typeof(IncomeVerificationRiskSignalsStatusWebhook),
			[(WebhookType.Item, WebhookCode.NewAccountsAvailable)] = typeof(NewAccountsAvailableWebhook),
			[(WebhookType.LinkDelivery, WebhookCode.DeliveryStatus)] = typeof(LinkUserDeliveryStatusWebhook),
			[(WebhookType.LinkDelivery, WebhookCode.LinkCallback)] = typeof(LinkDeliveryCallbackWebhook),
			[(WebhookType.Link, WebhookCode.Events)] = typeof(LinkEventsWebhook),
			[(WebhookType.Assets, WebhookCode.ProductReady)] = typeof(AssetsProductReadyWebhook),
			[(WebhookType.Assets, WebhookCode.Error)] = typeof(AssetsErrorWebhook),
		};
}