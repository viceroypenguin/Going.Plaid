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
	/// <para>The merchant name, as extracted by Plaid from the <c>name</c> field.</para>
	/// </summary>
	[JsonPropertyName("merchant_name")]
	public string? MerchantName { get; init; } = default!;

	/// <summary>
	/// <para>The date that the transaction was authorized. Dates are returned in an ISO 8601 format ( <c>YYYY-MM-DD</c> ).</para>
	/// </summary>
	[JsonPropertyName("authorized_date")]
	public DateOnly? AuthorizedDate { get; init; } = default!;

	/// <summary>
	/// <para>Date and time when a transaction was authorized in ISO 8601 format ( <c>YYYY-MM-DDTHH:mm:ssZ</c> ).</para>
	/// <para>This field is only populated for UK institutions. For institutions in other countries, will be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("authorized_datetime")]
	public DateTimeOffset? AuthorizedDatetime { get; init; } = default!;

	/// <summary>
	/// <para>Date and time when a transaction was posted in ISO 8601 format ( <c>YYYY-MM-DDTHH:mm:ssZ</c> ).</para>
	/// <para>This field is only populated for UK institutions. For institutions in other countries, will be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("datetime")]
	public DateTimeOffset? Datetime { get; init; } = default!;

	/// <summary>
	/// <para>An identifier classifying the transaction type.</para>
	/// </summary>
	[JsonPropertyName("transaction_code")]
	public Entity.transaction_code? TransactionCode { get; init; } = default!;
}