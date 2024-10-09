namespace Going.Plaid.Entity;

/// <summary>
/// <para>ID number of the person</para>
/// </summary>
public class TransferPlatformPersonIDNumber
{
	/// <summary>
	/// <para>Value of the person's ID Number. Alpha-numeric, with all formatting characters stripped.</para>
	/// </summary>
	[JsonPropertyName("value")]
	public string Value { get; set; } = default!;

	/// <summary>
	/// <para>A globally unique and human readable ID type, specific to the country and document category. For more context on this field, see [Hybrid Input Validation](https://plaid.com/docs/identity-verification/hybrid-input-validation).</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.IDNumberType Type { get; set; } = default!;

}
