namespace Going.Plaid.Beacon;

/// <summary>
/// <para>Request input for creating a Beacon User.</para>
/// <para>The primary use for this endpoint is to add a new end user to Beacon for fraud and duplicate scanning.</para>
/// <para>This endpoint can also be used to import historical fraud cases into the Beacon Network without being charged</para>
/// <para>for creating a Beacon User. To import historical fraud cases, embed the fraud report in the optional <c>report</c></para>
/// <para>section of the request payload.</para>
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
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.BeaconUserRequestData User { get; set; } = default!;
}