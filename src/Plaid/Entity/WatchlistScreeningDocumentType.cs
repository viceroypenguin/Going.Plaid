namespace Going.Plaid.Entity;

/// <summary>
/// <para>The kind of official document represented by this object.</para>
/// </summary>
public enum WatchlistScreeningDocumentType
{
	/// <summary>
	/// <para>A certificate of birth</para>
	/// </summary>
	[EnumMember(Value = "birth_certificate")]
	BirthCertificate,

	/// <summary>
	/// <para>A license to operate a motor vehicle</para>
	/// </summary>
	[EnumMember(Value = "drivers_license")]
	DriversLicense,

	/// <summary>
	/// <para>Immigration or residence documents</para>
	/// </summary>
	[EnumMember(Value = "immigration_number")]
	ImmigrationNumber,

	/// <summary>
	/// <para>Identification issued by a military group</para>
	/// </summary>
	[EnumMember(Value = "military_id")]
	MilitaryId,

	/// <summary>
	/// <para>Any document not covered by other categories</para>
	/// </summary>
	[EnumMember(Value = "other")]
	Other,

	/// <summary>
	/// <para>An official passport issue by a government</para>
	/// </summary>
	[EnumMember(Value = "passport")]
	Passport,

	/// <summary>
	/// <para>Any generic personal identification that is not covered by other categories</para>
	/// </summary>
	[EnumMember(Value = "personal_identification")]
	PersonalIdentification,

	/// <summary>
	/// <para>Identification that entitles the holder to rations</para>
	/// </summary>
	[EnumMember(Value = "ration_card")]
	RationCard,

	/// <summary>
	/// <para>United States Social Security Number</para>
	/// </summary>
	[EnumMember(Value = "ssn")]
	Ssn,

	/// <summary>
	/// <para>Identification issued by an educational institution</para>
	/// </summary>
	[EnumMember(Value = "student_id")]
	StudentId,

	/// <summary>
	/// <para>Identification issued for the purpose of collecting taxes</para>
	/// </summary>
	[EnumMember(Value = "tax_id")]
	TaxId,

	/// <summary>
	/// <para>Visas, entry permits, refugee documents, etc.</para>
	/// </summary>
	[EnumMember(Value = "travel_document")]
	TravelDocument,

	/// <summary>
	/// <para>Identification issued for the purpose of voting</para>
	/// </summary>
	[EnumMember(Value = "voter_id")]
	VoterId,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}