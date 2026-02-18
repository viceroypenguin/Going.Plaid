namespace Going.Plaid.BusinessVerification;

/// <summary>
/// <para>Request input for creating a business verification</para>
/// </summary>
public partial class BusinessVerificationCreateRequest : RequestBase
{
	/// <summary>
	/// <para>A unique ID that identifies the end user in your system. Either a <c>user_id</c> or the <c>client_user_id</c> must be provided. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the <c>/link/token/create</c> <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>Business information provided in the verification request</para>
	/// </summary>
	[JsonPropertyName("business")]
	public Entity.BusinessVerificationCreateRequestBusiness? Business { get; set; } = default!;

}
