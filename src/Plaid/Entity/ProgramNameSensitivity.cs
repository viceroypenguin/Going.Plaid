namespace Going.Plaid.Entity;

/// <summary>
/// <para>The valid name matching sensitivity configurations for a screening program. Note that while certain matching techniques may be more prevalent on less strict settings, all matching algorithms are enabled for every sensitivity.</para>
/// </summary>
public enum ProgramNameSensitivity
{
	/// <summary>
	/// <para>See more potential matches. This sensitivity will see more broad phonetic matches across alphabets that make missing a potential hit very unlikely. This setting is noisier and will require more manual review.</para>
	/// </summary>
	[EnumMember(Value = "coarse")]
	Coarse,

	/// <summary>
	/// <para>A good default for most companies. This sensitivity is balanced to show high quality hits with reduced noise.</para>
	/// </summary>
	[EnumMember(Value = "balanced")]
	Balanced,

	/// <summary>
	/// <para>Aggressive false positive reduction. This sensitivity will require names to be more similar than <c>coarse</c> and <c>balanced</c> settings, relying less on phonetics, while still accounting for character transpositions, missing tokens, and other common permutations.</para>
	/// </summary>
	[EnumMember(Value = "strict")]
	Strict,

	/// <summary>
	/// <para>Matches must be nearly exact. This sensitivity will only show hits with exact or nearly exact name matches with only basic correction such as extraneous symbols and capitalization. This setting is generally not recommended unless you have a very specific use case.</para>
	/// </summary>
	[EnumMember(Value = "exact")]
	Exact,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}