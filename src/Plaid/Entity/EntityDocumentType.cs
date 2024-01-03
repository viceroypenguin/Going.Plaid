namespace Going.Plaid.Entity;

/// <summary>
/// <para>The kind of official document represented by this object.</para>
/// </summary>
public enum EntityDocumentType
{
	/// <summary>
	/// <para>Russian bank code</para>
	/// </summary>
	[EnumMember(Value = "bik")]
	Bik,

	/// <summary>
	/// <para>A number that uniquely identifies the business within a category of businesses</para>
	/// </summary>
	[EnumMember(Value = "business_number")]
	BusinessNumber,

	/// <summary>
	/// <para>Number assigned to the entity by the International Maritime Organization</para>
	/// </summary>
	[EnumMember(Value = "imo")]
	Imo,

	/// <summary>
	/// <para>Any document not covered by other categories</para>
	/// </summary>
	[EnumMember(Value = "other")]
	Other,

	/// <summary>
	/// <para>Number identifying a bank and branch.</para>
	/// </summary>
	[EnumMember(Value = "swift")]
	Swift,

	/// <summary>
	/// <para>Identification issued for the purpose of collecting taxes</para>
	/// </summary>
	[EnumMember(Value = "tax_id")]
	TaxId,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
