namespace Going.Plaid.Entity;

/// <summary>
/// <para>Inputs for device Trust Index models.</para>
/// </summary>
public class ProtectDeviceModelInputs
{
	/// <summary>
	/// <para>A unique identifier for the device session started via the Protect SDK, used to compute a Trust Index score and fraud attributes.</para>
	/// </summary>
	[JsonPropertyName("device_session_id")]
	public string DeviceSessionId { get; set; } = default!;

}
