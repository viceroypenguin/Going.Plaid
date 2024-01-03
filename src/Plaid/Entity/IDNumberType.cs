namespace Going.Plaid.Entity;

/// <summary>
/// <para>A globally unique and human readable ID type, specific to the country and document category. For more context on this field, see [Hybrid Input Validation](https://plaid.com/docs/identity-verification/hybrid-input-validation).</para>
/// </summary>
public enum IDNumberType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ar_dni")]
	ArDni,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "au_drivers_license")]
	AuDriversLicense,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "au_passport")]
	AuPassport,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "br_cpf")]
	BrCpf,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ca_sin")]
	CaSin,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "cl_run")]
	ClRun,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "cn_resident_card")]
	CnResidentCard,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "co_nit")]
	CoNit,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "dk_cpr")]
	DkCpr,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "eg_national_id")]
	EgNationalId,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "es_dni")]
	EsDni,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "es_nie")]
	EsNie,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "hk_hkid")]
	HkHkid,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "in_pan")]
	InPan,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "it_cf")]
	ItCf,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "jo_civil_id")]
	JoCivilId,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "jp_my_number")]
	JpMyNumber,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ke_huduma_namba")]
	KeHudumaNamba,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "kw_civil_id")]
	KwCivilId,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "mx_curp")]
	MxCurp,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "mx_rfc")]
	MxRfc,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "my_nric")]
	MyNric,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ng_nin")]
	NgNin,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "nz_drivers_license")]
	NzDriversLicense,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "om_civil_id")]
	OmCivilId,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ph_psn")]
	PhPsn,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "pl_pesel")]
	PlPesel,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ro_cnp")]
	RoCnp,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "sa_national_id")]
	SaNationalId,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "se_pin")]
	SePin,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "sg_nric")]
	SgNric,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "tr_tc_kimlik")]
	TrTcKimlik,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "us_ssn")]
	UsSsn,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "us_ssn_last_4")]
	UsSsnLast4,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "za_smart_id")]
	ZaSmartId,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
