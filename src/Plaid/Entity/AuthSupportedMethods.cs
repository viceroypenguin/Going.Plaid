namespace Going.Plaid.Entity;

/// <summary>
/// <para>Metadata specifically related to which auth methods an institution supports.</para>
/// </summary>
public record AuthSupportedMethods
{
	/// <summary>
	/// <para>Indicates if instant auth is supported.</para>
	/// </summary>
	[JsonPropertyName("instant_auth")]
	public bool InstantAuth { get; init; } = default!;

	/// <summary>
	/// <para>Indicates if instant match is supported.</para>
	/// </summary>
	[JsonPropertyName("instant_match")]
	public bool InstantMatch { get; init; } = default!;

	/// <summary>
	/// <para>Indicates if automated microdeposits are supported.</para>
	/// </summary>
	[JsonPropertyName("automated_micro_deposits")]
	public bool AutomatedMicroDeposits { get; init; } = default!;
}