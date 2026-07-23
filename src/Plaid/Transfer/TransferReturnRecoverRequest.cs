namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/return/recover</c></para>
/// </summary>
public partial class TransferReturnRecoverRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the returned transfer that was recovered.</para>
	/// </summary>
	[JsonPropertyName("transfer_id")]
	public string TransferId { get; set; } = default!;

	/// <summary>
	/// <para>The amount being recovered (decimal string with two digits of precision e.g. "10.00"). The sum of recovered amounts across calls cannot exceed the original transfer's amount.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; set; } = default!;

	/// <summary>
	/// <para>A random key provided by the client, per unique recovery. Maximum of 50 characters.</para>
	/// <para>The API supports idempotency for safely retrying requests without accidentally performing the same operation twice. For example, if a request to report a recovery fails due to a network connection error, you can retry the request with the same idempotency key to guarantee that only a single recovery is recorded.</para>
	/// </summary>
	[JsonPropertyName("idempotency_key")]
	public string IdempotencyKey { get; set; } = default!;

}
