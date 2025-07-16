namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information specific to wire transfers.</para>
/// </summary>
public class TransferWireDetails
{
	/// <summary>
	/// <para>Additional information from the wire originator to the beneficiary. Max 140 characters.</para>
	/// </summary>
	[JsonPropertyName("message_to_beneficiary")]
	public string? MessageToBeneficiary { get; set; } = default!;

	/// <summary>
	/// <para>The fee amount deducted from the original transfer during a wire return, if applicable.</para>
	/// </summary>
	[JsonPropertyName("wire_return_fee")]
	public string? WireReturnFee { get; set; } = default!;

}
