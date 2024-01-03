namespace Going.Plaid.Entity;

/// <summary>
/// <para>The ID number associated with a Beacon User.</para>
/// </summary>
public class BeaconUserIDNumber
{
	/// <summary>
	/// <para>Value of identity document value typed in by user. Alpha-numeric, with all formatting characters stripped.</para>
	/// </summary>
	[JsonPropertyName("value")]
	public string Value { get; set; } = default!;

	/// <summary>
	/// <para>A globally unique and human readable ID type, specific to the country and document category. For more context on this field, see [Hybrid Input Validation](https://plaid.com/docs/identity-verification/hybrid-input-validation).</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.IDNumberType Type { get; set; } = default!;

}
