namespace Going.Plaid.Entity;

/// <summary>
/// <para>A representation of a transaction</para>
/// </summary>
public record Transaction
{
	/// <summary>
	/// <para>The ID of the account in which this transaction occurred.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The settled value of the transaction, denominated in the transactions's currency, as stated in <c>iso_currency_code</c> or <c>unofficial_currency_code</c>. Positive values when money moves out of the account; negative values when money moves in. For example, debit card purchases are positive; credit card payments, direct deposits, and refunds are negative.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the transaction. Always <c>null</c> if <c>unofficial_currency_code</c> is non-null.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The unofficial currency code associated with the transaction. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.</para>
	/// <para>See the <a href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</a> for a full listing of supported <c>iso_currency_code</c>s.</para>
	/// </summary>
	[JsonPropertyName("unofficial_currency_code")]
	public string? UnofficialCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>A hierarchical array of the categories to which this transaction belongs. For a full list of categories, see <a href="https://plaid.com/docs/api/products/transactions/#categoriesget"><c>/categories/get</c></a>.</para>
	/// <para>If the <c>transactions</c> object was returned by an Assets endpoint such as <c>/asset_report/get/</c> or <c>/asset_report/pdf/get</c>, this field will only appear in an Asset Report with Insights.</para>
	/// </summary>
	[JsonPropertyName("category")]
	public IReadOnlyList<string>? Category { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the category to which this transaction belongs. For a full list of categories, see <a href="https://plaid.com/docs/api/products/transactions/#categoriesget"><c>/categories/get</c></a>.</para>
	/// <para>If the <c>transactions</c> object was returned by an Assets endpoint such as <c>/asset_report/get/</c> or <c>/asset_report/pdf/get</c>, this field will only appear in an Asset Report with Insights.</para>
	/// </summary>
	[JsonPropertyName("category_id")]
	public string? CategoryId { get; init; } = default!;

	/// <summary>
	/// <para>The check number of the transaction. This field is only populated for check transactions.</para>
	/// </summary>
	[JsonPropertyName("check_number")]
	public string? CheckNumber { get; init; } = default!;

	/// <summary>
	/// <para>For pending transactions, the date that the transaction occurred; for posted transactions, the date that the transaction posted. Both dates are returned in an <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ( <c>YYYY-MM-DD</c> ).</para>
	/// </summary>
	[JsonPropertyName("date")]
	public DateOnly Date { get; init; } = default!;

	/// <summary>
	/// <para>A representation of where a transaction took place</para>
	/// </summary>
	[JsonPropertyName("location")]
	public Entity.Location Location { get; init; } = default!;

	/// <summary>
	/// <para>The merchant name or transaction description.</para>
	/// <para>If the <c>transactions</c> object was returned by a Transactions endpoint such as <c>/transactions/get</c>, this field will always appear. If the <c>transactions</c> object was returned by an Assets endpoint such as <c>/asset_report/get/</c> or <c>/asset_report/pdf/get</c>, this field will only appear in an Asset Report with Insights.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>The merchant name, as enriched by Plaid from the <c>name</c> field. This is typically a more human-readable version of the merchant counterparty in the transaction. For some bank transactions (such as checks or account transfers) where there is no meaningful merchant name, this value will be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("merchant_name")]
	public string? MerchantName { get; init; } = default!;

	/// <summary>
	/// <para>The string returned by the financial institution to describe the transaction. For transactions returned by <c>/transactions/get</c>, this field is in beta and will be omitted unless the client is both enrolled in the closed beta program and has set <c>options.include_original_description</c> to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("original_description")]
	public string? OriginalDescription { get; init; } = default!;

	/// <summary>
	/// <para>Transaction information specific to inter-bank transfers. If the transaction was not an inter-bank transfer, all fields will be <c>null</c>.</para>
	/// <para>If the <c>transactions</c> object was returned by a Transactions endpoint such as <c>/transactions/get</c>, the <c>payment_meta</c> key will always appear, but no data elements are guaranteed. If the <c>transactions</c> object was returned by an Assets endpoint such as <c>/asset_report/get/</c> or <c>/asset_report/pdf/get</c>, this field will only appear in an Asset Report with Insights.</para>
	/// </summary>
	[JsonPropertyName("payment_meta")]
	public Entity.PaymentMeta PaymentMeta { get; init; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, identifies the transaction as pending or unsettled. Pending transaction details (name, type, amount, category ID) may change before they are settled.</para>
	/// </summary>
	[JsonPropertyName("pending")]
	public bool Pending { get; init; } = default!;

	/// <summary>
	/// <para>The ID of a posted transaction's associated pending transaction, where applicable.</para>
	/// </summary>
	[JsonPropertyName("pending_transaction_id")]
	public string? PendingTransactionId { get; init; } = default!;

	/// <summary>
	/// <para>The name of the account owner. This field is not typically populated and only relevant when dealing with sub-accounts.</para>
	/// </summary>
	[JsonPropertyName("account_owner")]
	public string? AccountOwner { get; init; } = default!;

	/// <summary>
	/// <para>The unique ID of the transaction. Like all Plaid identifiers, the <c>transaction_id</c> is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("transaction_id")]
	public string TransactionId { get; init; } = default!;

	/// <summary>
	/// <para>Please use the <c>payment_channel</c> field, <c>transaction_type</c> will be deprecated in the future.</para>
	/// </summary>
	[JsonPropertyName("transaction_type")]
	public Entity.TransactionTransactionTypeEnum TransactionType { get; init; } = default!;

	/// <summary>
	/// <para>The logo associated with the merchant, if available. Formatted as a 100x100 pixels PNG file path.</para>
	/// </summary>
	[JsonPropertyName("logo_url")]
	public string? LogoUrl { get; init; } = default!;

	/// <summary>
	/// <para>The website associated with the merchant, if available.</para>
	/// </summary>
	[JsonPropertyName("website")]
	public string? Website { get; init; } = default!;

	/// <summary>
	/// <para>The date that the transaction was authorized. Dates are returned in an <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ( <c>YYYY-MM-DD</c> ).</para>
	/// </summary>
	[JsonPropertyName("authorized_date")]
	public DateOnly? AuthorizedDate { get; init; } = default!;

	/// <summary>
	/// <para>Date and time when a transaction was authorized in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ( <c>YYYY-MM-DDTHH:mm:ssZ</c> ).</para>
	/// <para>This field is returned for select financial institutions and comes as provided by the institution. It may contain default time values (such as 00:00:00).</para>
	/// </summary>
	[JsonPropertyName("authorized_datetime")]
	public DateTimeOffset? AuthorizedDatetime { get; init; } = default!;

	/// <summary>
	/// <para>Date and time when a transaction was posted in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ( <c>YYYY-MM-DDTHH:mm:ssZ</c> ).</para>
	/// <para>This field is returned for select financial institutions and comes as provided by the institution. It may contain default time values (such as 00:00:00).</para>
	/// </summary>
	[JsonPropertyName("datetime")]
	public DateTimeOffset? Datetime { get; init; } = default!;

	/// <summary>
	/// <para>The channel used to make a payment.</para>
	/// </summary>
	[JsonPropertyName("payment_channel")]
	public Entity.TransactionPaymentChannelEnum PaymentChannel { get; init; } = default!;

	/// <summary>
	/// <para>Information describing the intent of the transaction. Most relevant for personal finance use cases, but not limited to such use cases.</para>
	/// <para>See the <a href="https://plaid.com/documents/transactions-personal-finance-category-taxonomy.csv"><c>taxonomy csv file</c></a> for a full list of personal finance categories.</para>
	/// </summary>
	[JsonPropertyName("personal_finance_category")]
	public Entity.PersonalFinanceCategory? PersonalFinanceCategory { get; init; } = default!;

	/// <summary>
	/// <para>An identifier classifying the transaction type.</para>
	/// </summary>
	[JsonPropertyName("transaction_code")]
	public Entity.TransactionCode? TransactionCode { get; init; } = default!;

	/// <summary>
	/// <para>A link to the icon associated with the primary personal finance category. The logo will always be 100x100 pixels.</para>
	/// </summary>
	[JsonPropertyName("personal_finance_category_icon_url")]
	public string PersonalFinanceCategoryIconUrl { get; init; } = default!;

	/// <summary>
	/// <para>The counterparties present in the transaction. Counterparties, such as the financial institutions, are extracted by Plaid from the raw description.</para>
	/// </summary>
	[JsonPropertyName("counterparties")]
	public IReadOnlyList<Entity.Counterparty> Counterparties { get; init; } = default!;
}