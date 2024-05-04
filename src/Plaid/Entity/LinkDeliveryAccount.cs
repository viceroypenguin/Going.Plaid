namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information related to account attached to the connected Item</para>
/// </summary>
public record LinkDeliveryAccount
{
	/// <summary>
	/// <para>The Plaid <c>account_id</c></para>
	/// </summary>
	[JsonPropertyName("id")]
	public string? Id { get; init; } = default!;

	/// <summary>
	/// <para>The official account name</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

	/// <summary>
	/// <para>The last 2-4 alphanumeric characters of an account's official account number. Note that the mask may be non-unique between an Item's accounts. It may also not match the mask that the bank displays to the user.</para>
	/// </summary>
	[JsonPropertyName("mask")]
	public string? Mask { get; init; } = default!;

	/// <summary>
	/// <para>The account type. See the <a href="https://plaid.com/docs/api/accounts/#account-type-schema">Account schema</a> for a full list of possible values</para>
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; init; } = default!;

	/// <summary>
	/// <para>The account subtype. See the <a href="https://plaid.com/docs/api/accounts/#account-type-schema">Account schema</a> for a full list of possible values</para>
	/// </summary>
	[JsonPropertyName("subtype")]
	public string? Subtype { get; init; } = default!;

	/// <summary>
	/// <para>Indicates an Item's micro-deposit-based verification or database verification status.</para>
	/// </summary>
	[JsonPropertyName("verification_status")]
	public Entity.LinkDeliveryVerificationStatus? VerificationStatus { get; init; } = default!;

	/// <summary>
	/// <para>If micro-deposit verification is being used, indicates whether the account being verified is a <c>business</c> or <c>personal</c> account.</para>
	/// </summary>
	[JsonPropertyName("class_type")]
	public string? ClassType { get; init; } = default!;

}
