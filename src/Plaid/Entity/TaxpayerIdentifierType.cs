namespace Going.Plaid.Entity;

/// <summary>
/// <para>A value from a MISMO prescribed list that classifies identification numbers used by the Internal Revenue Service (IRS) in the administration of tax laws. A Social Security number (SSN) is issued by the SSA; all other taxpayer identification numbers are issued by the IRS.</para>
/// </summary>
public enum TaxpayerIdentifierType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IndividualTaxpayerIdentificationNumber")]
	Individualtaxpayeridentificationnumber,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SocialSecurityNumber")]
	Socialsecuritynumber,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}