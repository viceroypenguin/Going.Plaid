namespace Going.Plaid.PaymentProfile;

/// <summary>
/// <para>PaymentProfileGetResponse defines the response schema for <c>/payment_profile/get</c></para>
/// </summary>
public record PaymentProfileGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Timestamp in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (<c>YYYY-MM-DDTHH:mm:ssZ</c>) indicating the last time the given Payment Profile was updated at</para>
	/// </summary>
	[JsonPropertyName("updated_at")]
	public DateTimeOffset UpdatedAt { get; init; } = default!;

	/// <summary>
	/// <para>Timestamp in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (<c>YYYY-MM-DDTHH:mm:ssZ</c>) indicating the time the given Payment Profile was created at</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>Timestamp in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (<c>YYYY-MM-DDTHH:mm:ssZ</c>) indicating the time the given Payment Profile was deleted at. Always <c>null</c> if the Payment Profile has not been deleted</para>
	/// </summary>
	[JsonPropertyName("deleted_at")]
	public DateTimeOffset? DeletedAt { get; init; } = default!;

	/// <summary>
	/// <para>The status of the given Payment Profile.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.PaymentProfileStatus Status { get; init; } = default!;

}
