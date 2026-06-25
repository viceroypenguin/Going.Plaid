namespace Going.Plaid.Entity;

/// <summary>
/// <para>The adaptive guarantee outcome for a transfer.</para>
/// </summary>
public enum TransferGuaranteeOutcome
{
	/// <summary>
	/// <para>The full transfer amount is guaranteed and funds are available instantly.</para>
	/// </summary>
	[EnumMember(Value = "FULL_INSTANT")]
	FullInstant,

	/// <summary>
	/// <para>A partial amount is guaranteed and available instantly; the remainder is not guaranteed.</para>
	/// </summary>
	[EnumMember(Value = "PARTIAL_INSTANT_ONLY")]
	PartialInstantOnly,

	/// <summary>
	/// <para>A partial amount is guaranteed instantly; an additional amount is conditionally guaranteed subject to an observation window.</para>
	/// </summary>
	[EnumMember(Value = "PARTIAL_INSTANT_WITH_OBSERVATION_WINDOW")]
	PartialInstantWithObservationWindow,

	/// <summary>
	/// <para>Plaid did not provide a guarantee for this transfer.</para>
	/// </summary>
	[EnumMember(Value = "NOT_GUARANTEED")]
	NotGuaranteed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
