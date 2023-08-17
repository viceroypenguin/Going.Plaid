namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of identity document detected in the images provided. Will always be one of the following values:</para>
/// </summary>
public enum PhysicalDocumentCategory
{
	/// <summary>
	/// <para>A driver's license issued by the associated country, establishing identity without any guarantee as to citizenship, and granting driving privileges</para>
	/// </summary>
	[EnumMember(Value = "drivers_license")]
	DriversLicense,

	/// <summary>
	/// <para>A general national identification card, distinct from driver's licenses as it only establishes identity</para>
	/// </summary>
	[EnumMember(Value = "id_card")]
	IdCard,

	/// <summary>
	/// <para>A travel passport issued by the associated country for one of its citizens</para>
	/// </summary>
	[EnumMember(Value = "passport")]
	Passport,

	/// <summary>
	/// <para>An identity document issued by the associated country permitting a foreign citizen to <em>temporarily</em> reside there</para>
	/// </summary>
	[EnumMember(Value = "residence_permit_card")]
	ResidencePermitCard,

	/// <summary>
	/// <para>An identity document issued by the associated country permitting a foreign citizen to <em>permanently</em> reside there</para>
	/// </summary>
	[EnumMember(Value = "resident_card")]
	ResidentCard,

	/// <summary>
	/// <para>An identity document issued by the associated country permitting a foreign citizen entry for a short duration and for a specific purpose, typically no longer than 6 months</para>
	/// </summary>
	[EnumMember(Value = "visa")]
	Visa,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}