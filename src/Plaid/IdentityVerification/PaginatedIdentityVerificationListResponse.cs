namespace Going.Plaid.IdentityVerification;

/// <summary>
/// <para>Paginated list of Plaid sessions.</para>
/// </summary>
public record PaginatedIdentityVerificationListResponse : ResponseBase
{
	/// <summary>
	/// <para>List of Plaid sessions</para>
	/// </summary>
	[JsonPropertyName("identity_verifications")]
	public IReadOnlyList<Entity.IdentityVerification> IdentityVerifications { get; init; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; init; } = default!;
}