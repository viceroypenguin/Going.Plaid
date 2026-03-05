namespace Going.Plaid.Entity;

/// <summary>
/// <para>Inputs for Protect SDK Trust Index models.</para>
/// </summary>
public class ProtectSDKModelInputs
{
	/// <summary>
	/// <para>A unique identifier for the Protect SDK session, used to compute a Trust Index score and fraud attributes.</para>
	/// </summary>
	[JsonPropertyName("sdk_session_id")]
	public string SdkSessionId { get; set; } = default!;

}
