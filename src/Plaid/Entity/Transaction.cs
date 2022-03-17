namespace Going.Plaid.Entity;

/// <summary>
/// <para>A representation of a transaction</para>
/// </summary>
public record Transaction : Entity.TransactionBase
{
	/// <summary>
	/// <para>The channel used to make a payment.</para>
	/// </summary>
	[JsonPropertyName("payment_channel")]
	public Entity.TransactionPaymentChannelEnum PaymentChannel { get; init; } = default!;

	/// <summary>
	/// <para>The date that the transaction was authorized. Dates are returned in an <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ( <c>YYYY-MM-DD</c> ). The <c>authorized_date</c> field uses machine learning to determine a transaction date for transactions where the <c>date_transacted</c> is not available. If the <c>date_transacted</c> field is present and not <c>null</c>, the <c>authorized_date</c> field will have the same value as the <c>date_transacted</c> field.</para>
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
	/// <para>An identifier classifying the transaction type.</para>
	/// </summary>
	[JsonPropertyName("transaction_code")]
	public Entity.TransactionCode? TransactionCode { get; init; } = default!;

	/// <summary>
	/// <para>Information describing the intent of the transaction. Most relevant for personal finance use cases, but not limited to such use cases.</para>
	/// <para>See the <a href="https://plaid.com/documents/transactions-personal-finance-category-taxonomy.csv"><c>taxonomy csv file</c></a> for a full list of personal finance categories.</para>
	/// </summary>
	[JsonPropertyName("personal_finance_category")]
	public Entity.PersonalFinanceCategory? PersonalFinanceCategory { get; init; } = default!;
}