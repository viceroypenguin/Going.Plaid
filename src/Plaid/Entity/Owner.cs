namespace Going.Plaid.Entity;

/// <summary>
/// <para>Data returned from the financial institution about the owner or owners of an account. Only the <c>names</c> array must be non-empty.</para>
/// </summary>
public record Owner
{
	/// <summary>
	/// <para>A list of names associated with the account by the financial institution. In the case of a joint account, Plaid will make a best effort to report the names of all account holders.</para>
	/// <para>If an Item contains multiple accounts with different owner names, some institutions will report all names associated with the Item in each account's <c>names</c> array.</para>
	/// </summary>
	[JsonPropertyName("names")]
	public IReadOnlyList<string> Names { get; init; } = default!;

	/// <summary>
	/// <para>A list of phone numbers associated with the account by the financial institution. May be an empty array if no relevant information is returned from the financial institution.</para>
	/// </summary>
	[JsonPropertyName("phone_numbers")]
	public IReadOnlyList<Entity.PhoneNumber> PhoneNumbers { get; init; } = default!;

	/// <summary>
	/// <para>A list of email addresses associated with the account by the financial institution. May be an empty array if no relevant information is returned from the financial institution.</para>
	/// </summary>
	[JsonPropertyName("emails")]
	public IReadOnlyList<Entity.Email> Emails { get; init; } = default!;

	/// <summary>
	/// <para>Data about the various addresses associated with the account by the financial institution. May be an empty array if no relevant information is returned from the financial institution.</para>
	/// </summary>
	[JsonPropertyName("addresses")]
	public IReadOnlyList<Entity.Address> Addresses { get; init; } = default!;

}
