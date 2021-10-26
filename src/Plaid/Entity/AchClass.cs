namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies the use case of the transfer.  Required for transfers on an ACH network.</para>
/// </summary>
public enum AchClass
{
	/// <summary>
	/// <para>Accounts Receivable Entry</para>
	/// </summary>
	[EnumMember(Value = "arc")]
	Arc,

	/// <summary>
	/// <para>" - Cross Border Entry</para>
	/// </summary>
	[EnumMember(Value = "cbr")]
	Cbr,

	/// <summary>
	/// <para>Corporate Credit or Debit - fund transfer between two corporate bank accounts</para>
	/// </summary>
	[EnumMember(Value = "ccd")]
	Ccd,

	/// <summary>
	/// <para>Customer Initiated Entry</para>
	/// </summary>
	[EnumMember(Value = "cie")]
	Cie,

	/// <summary>
	/// <para>Automated Notification of Change</para>
	/// </summary>
	[EnumMember(Value = "cor")]
	Cor,

	/// <summary>
	/// <para>Corporate Trade Exchange</para>
	/// </summary>
	[EnumMember(Value = "ctx")]
	Ctx,

	/// <summary>
	/// <para>International</para>
	/// </summary>
	[EnumMember(Value = "iat")]
	Iat,

	/// <summary>
	/// <para>Machine Transfer Entry</para>
	/// </summary>
	[EnumMember(Value = "mte")]
	Mte,

	/// <summary>
	/// <para>Cross Border Entry</para>
	/// </summary>
	[EnumMember(Value = "pbr")]
	Pbr,

	/// <summary>
	/// <para>Point-of-Purchase Entry</para>
	/// </summary>
	[EnumMember(Value = "pop")]
	Pop,

	/// <summary>
	/// <para>Point-of-Sale Entry</para>
	/// </summary>
	[EnumMember(Value = "pos")]
	Pos,

	/// <summary>
	/// <para>Prearranged Payment or Deposit - the transfer is part of a pre-existing relationship with a consumer, eg. bill payment</para>
	/// </summary>
	[EnumMember(Value = "ppd")]
	Ppd,

	/// <summary>
	/// <para>Re-presented Check Entry</para>
	/// </summary>
	[EnumMember(Value = "rck")]
	Rck,

	/// <summary>
	/// <para>Telephone-Initiated Entry</para>
	/// </summary>
	[EnumMember(Value = "tel")]
	Tel,

	/// <summary>
	/// <para>Internet-Initiated Entry - debits from a consumer’s account where their authorization is obtained over the Internet</para>
	/// </summary>
	[EnumMember(Value = "web")]
	Web,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,
}