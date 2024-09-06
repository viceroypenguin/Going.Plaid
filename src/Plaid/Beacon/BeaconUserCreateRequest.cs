namespace Going.Plaid.Beacon;

/// <summary>
/// <para>Request input for creating a Beacon User.</para>
/// <para>The primary use for this endpoint is to add a new end user to Beacon for fraud and duplicate scanning.</para>
/// <para>Some fields are optional, but it is recommended to provide as much information as possible to improve</para>
/// <para>the accuracy of the fraud and duplicate scanning.</para>
/// </summary>
public partial class BeaconUserCreateRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated Beacon Program.</para>
	/// </summary>
	[JsonPropertyName("program_id")]
	public string ProgramId { get; set; } = default!;

	/// <summary>
	/// <para>A unique ID that identifies the end user in your system. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the <c>/link/token/create</c> <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>A Beacon User's data which is used to check against duplicate records and the Beacon Fraud Network.</para>
	/// <para>In order to create a Beacon User, in addition to the <c>name</c>, _either_ the <c>date_of_birth</c> _or_ the <c>depository_accounts</c> field must be provided.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.BeaconUserRequestData User { get; set; } = default!;

	/// <summary>
	/// <para>Send this array of access tokens to link accounts to the Beacon User and have them evaluated for Account Insights.</para>
	/// <para>A maximum of 50 accounts total can be added to a single Beacon User.</para>
	/// </summary>
	[JsonPropertyName("access_tokens")]
	public IReadOnlyList<string>? AccessTokens { get; set; } = default!;

}
