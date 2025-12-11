namespace Going.Plaid.Entity;

/// <summary>
/// <para>The user's ID number. Used only for Identity Verification. If provided, the user will not be shown fields to enter their ID number in the Identity Verification flow. May be omitted, but if not omitted, all fields marked as required must be provided.</para>
/// </summary>
public class LinkTokenCreateRequestUserIdNumberObject
{
	/// <summary>
	/// <para>Value of identity document value typed in by user. Alpha-numeric, with all formatting characters stripped. For specific format requirements by ID type, see <a href="https://plaid.com/docs/identity-verification/hybrid-input-validation/#id-numbers">Input Validation Rules</a>.</para>
	/// </summary>
	[JsonPropertyName("value")]
	public string? Value { get; set; } = default!;

	/// <summary>
	/// <para>A globally unique and human readable ID type, specific to the country and document category. For more context on this field, see [Input Validation Rules](https://cognitohq.com/docs/flow/flow-hybrid-input-validation#id-numbers).</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.IDNumberType? Type { get; set; } = default!;

}
