namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/create</c></para>
/// </summary>
public class TransferCreateRequest : RequestBase
{
	/// <summary>
	/// <para>A random key provided by the client, per unique transfer. Maximum of 50 characters.</para>
	/// <para>The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. For example, if a request to create a transfer fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single transfer is created.</para>
	/// </summary>
	[JsonPropertyName("idempotency_key")]
	public string IdempotencyKey { get; set; } = default!;

	/// <summary>
	/// <para>The Plaid <c>account_id</c> for the account that will be debited or credited.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; set; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for a transfer authorization.</para>
	/// </summary>
	[JsonPropertyName("authorization_id")]
	public string AuthorizationId { get; set; } = default!;

	/// <summary>
	/// <para>The type of transfer. This will be either <c>debit</c> or <c>credit</c>.  A <c>debit</c> indicates a transfer of money into the origination account; a <c>credit</c> indicates a transfer of money out of the origination account.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.TransferType Type { get; set; } = default!;

	/// <summary>
	/// <para>The network or rails used for the transfer. Valid options are <c>ach</c> or <c>same-day-ach</c>.</para>
	/// </summary>
	[JsonPropertyName("network")]
	public Entity.TransferNetwork Network { get; set; } = default!;

	/// <summary>
	/// <para>The amount of the transfer (decimal string with two digits of precision e.g. “10.00”).</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; set; } = default!;

	/// <summary>
	/// <para>The transfer description. Maximum of 10 characters.</para>
	/// </summary>
	[JsonPropertyName("description")]
	public string Description { get; set; } = default!;

	/// <summary>
	/// <para>Specifies the use case of the transfer.  Required for transfers on an ACH network.</para>
	/// </summary>
	[JsonPropertyName("ach_class")]
	public Entity.AchClass AchClass { get; set; } = default!;

	/// <summary>
	/// <para>The legal name and other information for the account holder.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.TransferUserInRequest User { get; set; } = default!;

	/// <summary>
	/// <para>The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply:</para>
	/// <para>- The JSON values must be Strings (no nested JSON objects allowed)</para>
	/// <para>- Only ASCII characters may be used</para>
	/// <para>- Maximum of 50 key/value pairs</para>
	/// <para>- Maximum key length of 40 characters</para>
	/// <para>- Maximum value length of 500 characters</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public Entity.TransferMetadata? Metadata { get; set; } = default!;

	/// <summary>
	/// <para>Plaid’s unique identifier for the origination account for this transfer. If you have more than one origination account, this value must be specified.</para>
	/// </summary>
	[JsonPropertyName("origination_account_id")]
	public string? OriginationAccountId { get; set; } = default!;
}