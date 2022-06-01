namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of identity document detected in the images provided. Will always be one of the following values:</para>
/// </summary>
public enum PhysicalDocumentCategory
{
	/// <summary>
	/// <para>A driver's license for the associated country</para>
	/// </summary>
	[EnumMember(Value = "drivers_license")]
	DriversLicense,

	/// <summary>
	/// <para>A general national identification card, distinct from driver's licenses</para>
	/// </summary>
	[EnumMember(Value = "id_card")]
	IdCard,

	/// <summary>
	/// <para>A passport for the associated country</para>
	/// </summary>
	[EnumMember(Value = "passport")]
	Passport,

	/// <summary>
	/// <para>An identity document permitting a foreign citizen to <em>temporarily</em> reside in the associated country</para>
	/// </summary>
	[EnumMember(Value = "residence_permit_card")]
	ResidencePermitCard,

	/// <summary>
	/// <para>An identity document permitting a foreign citizen to <em>permanently</em> reside in the associated country</para>
	/// </summary>
	[EnumMember(Value = "resident_card")]
	ResidentCard,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}
