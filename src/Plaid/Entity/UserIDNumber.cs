namespace Going.Plaid.Entity;

/// <summary>
/// <para>ID number submitted by the user, currently used only for the Identity Verification product. If the user has not submitted this data yet, this field will be <c>null</c>. Otherwise, both fields are guaranteed to be filled.</para>
/// </summary>
public class UserIDNumber
{
	/// <summary>
	/// <para>Value of identity document value typed in by user. Alpha-numeric, with all formatting characters stripped. For specific format requirements by ID type, see <a href="https://plaid.com/docs/identity-verification/hybrid-input-validation/#id-numbers">Input Validation Rules</a>.</para>
	/// </summary>
	[JsonPropertyName("value")]
	public string Value { get; set; } = default!;

	/// <summary>
	/// <para>A globally unique and human readable ID type, specific to the country and document category. For more context on this field, see [Input Validation Rules](https://cognitohq.com/docs/flow/flow-hybrid-input-validation#id-numbers).</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.IDNumberType Type { get; set; } = default!;

}
