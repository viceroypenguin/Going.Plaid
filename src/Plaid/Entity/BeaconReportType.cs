namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of Beacon Report.</para>
/// </summary>
public enum BeaconReportType
{
	/// <summary>
	/// <para>If this is the same individual as the one who submitted the KYC.</para>
	/// </summary>
	[EnumMember(Value = "first_party")]
	FirstParty,

	/// <summary>
	/// <para>If this is a different individual from the one who submitted the KYC.</para>
	/// </summary>
	[EnumMember(Value = "third_party")]
	ThirdParty,

	/// <summary>
	/// <para>If this is an individual using fabricated information.</para>
	/// </summary>
	[EnumMember(Value = "synthetic")]
	Synthetic,

	/// <summary>
	/// <para>If this individual's account was compromised.</para>
	/// </summary>
	[EnumMember(Value = "account_takeover")]
	AccountTakeover,

	/// <summary>
	/// <para>If you aren't sure who committed the fraud.</para>
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}