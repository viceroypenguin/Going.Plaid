namespace Going.Plaid.Entity;

/// <summary>
/// <para>Identity information about an account</para>
/// </summary>
public record AccountIdentity
{
	/// <summary>
	/// <para>Plaid’s unique identifier for the account. This value will not change unless Plaid can't reconcile the account with the data returned by the financial institution. This may occur, for example, when the name of the account changes. If this happens a new <c>account_id</c> will be assigned to the account.</para>
	/// <para>The <c>account_id</c> can also change if the <c>access_token</c> is deleted and the same credentials that were used to generate that <c>access_token</c> are used to generate a new <c>access_token</c> on a later date. In that case, the new <c>account_id</c> will be different from the old <c>account_id</c>.</para>
	/// <para>If an account with a specific <c>account_id</c> disappears instead of changing, the account is likely closed. Closed accounts are not returned by the Plaid API.</para>
	/// <para>Like all Plaid identifiers, the <c>account_id</c> is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string? AccountId { get; init; } = default!;

	/// <summary>
	/// <para>A set of fields describing the balance for an account. Balance information may be cached unless the balance object was returned by <c>/accounts/balance/get</c>.</para>
	/// </summary>
	[JsonPropertyName("balances")]
	public Entity.AccountBalance? Balances { get; init; } = default!;

	/// <summary>
	/// <para>The last 2-4 alphanumeric characters of either the account’s displayed mask or the account’s official account number. Note that the mask may be non-unique between an Item’s accounts.</para>
	/// </summary>
	[JsonPropertyName("mask")]
	public string? Mask { get; init; } = default!;

	/// <summary>
	/// <para>The name of the account, either assigned by the user or by the financial institution itself</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

	/// <summary>
	/// <para>The official name of the account as given by the financial institution</para>
	/// </summary>
	[JsonPropertyName("official_name")]
	public string? OfficialName { get; init; } = default!;

	/// <summary>
	/// <para>See the <a href="https://plaid.com/docs/api/accounts#account-type-schema">Account type schema</a> for a full listing of account types and corresponding subtypes.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.AccountType? Type { get; init; } = default!;

	/// <summary>
	/// <para>See the [Account type schema](https://plaid.com/docs/api/accounts/#account-type-schema) for a full listing of account types and corresponding subtypes.</para>
	/// </summary>
	[JsonPropertyName("subtype")]
	public Entity.AccountSubtype? Subtype { get; init; } = default!;

	/// <summary>
	/// <para>The current verification status of an Auth Item initiated through micro-deposits or database verification. Returned for Auth Items only.</para>
	/// </summary>
	[JsonPropertyName("verification_status")]
	public Entity.AccountIdentityVerificationStatusEnum? VerificationStatus { get; init; } = default!;

	/// <summary>
	/// <para>The account holder name that was used for micro-deposit and/or database verification. Only returned for Auth Items created via micro-deposit or database verification. This name was manually-entered by the user during Link, unless it was otherwise provided via the <c>user.legal_name</c> request field in <c>/link/token/create</c> for the Link session that created the Item.</para>
	/// </summary>
	[JsonPropertyName("verification_name")]
	public string? VerificationName { get; init; } = default!;

	/// <summary>
	/// <para>Insights from performing database verification for the account. Only returned for Auth Items using Database Auth.</para>
	/// </summary>
	[JsonPropertyName("verification_insights")]
	public Entity.VerificationInsights? VerificationInsights { get; init; } = default!;

	/// <summary>
	/// <para>A unique and persistent identifier for accounts that can be used to trace multiple instances of the same account across different Items for depository accounts. This field is currently supported only for Items at institutions that use Tokenized Account Numbers (i.e., Chase and PNC, and in May 2025 US Bank). Because these accounts have a different account number each time they are linked, this field may be used instead of the account number to uniquely identify an account across multiple Items for payments use cases, helping to reduce duplicate Items or attempted fraud. In Sandbox, this field is populated for TAN-based institutions (<c>ins_56</c>, <c>ins_13</c>) as well as the OAuth Sandbox institution (<c>ins_127287</c>); in Production, it will only be populated for accounts at applicable institutions.</para>
	/// </summary>
	[JsonPropertyName("persistent_account_id")]
	public string? PersistentAccountId { get; init; } = default!;

	/// <summary>
	/// <para>Indicates the account's categorization as either a personal or a business account. This field is currently in beta; to request access, contact your account manager.</para>
	/// </summary>
	[JsonPropertyName("holder_category")]
	public Entity.HolderCategory? HolderCategory { get; init; } = default!;

	/// <summary>
	/// <para>Data returned by the financial institution about the account owner or owners. Only returned by Identity or Assets endpoints. For business accounts, the name reported may be either the name of the individual or the name of the business, depending on the institution; detecting whether the linked account is a business account is not currently supported. Multiple owners on a single account will be represented in the same <c>owner</c> object, not in multiple owner objects within the array. In API versions 2018-05-22 and earlier, the <c>owners</c> object is not returned, and instead identity information is returned in the top level <c>identity</c> object. For more details, see <a href="https://plaid.com/docs/api/versioning/#version-2019-05-29">Plaid API versioning</a></para>
	/// </summary>
	[JsonPropertyName("owners")]
	public IReadOnlyList<Entity.Owner>? Owners { get; init; } = default!;

}
