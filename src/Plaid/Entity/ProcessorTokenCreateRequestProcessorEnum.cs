namespace Going.Plaid.Entity;

/// <summary>
/// <para>The processor you are integrating with.</para>
/// </summary>
public enum ProcessorTokenCreateRequestProcessorEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "dwolla")]
	Dwolla,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "galileo")]
	Galileo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "modern_treasury")]
	ModernTreasury,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ocrolus")]
	Ocrolus,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "vesta")]
	Vesta,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "drivewealth")]
	Drivewealth,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "vopay")]
	Vopay,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "achq")]
	Achq,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "check")]
	Check,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "checkbook")]
	Checkbook,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "circle")]
	Circle,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "sila_money")]
	SilaMoney,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "rize")]
	Rize,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "svb_api")]
	SvbApi,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "unit")]
	Unit,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "wyre")]
	Wyre,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "lithic")]
	Lithic,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "alpaca")]
	Alpaca,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "astra")]
	Astra,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "moov")]
	Moov,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "treasury_prime")]
	TreasuryPrime,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "marqeta")]
	Marqeta,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "checkout")]
	Checkout,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "solid")]
	Solid,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "highnote")]
	Highnote,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "gemini")]
	Gemini,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "apex_clearing")]
	ApexClearing,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "gusto")]
	Gusto,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "adyen")]
	Adyen,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "atomic")]
	Atomic,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "i2c")]
	I2c,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "wepay")]
	Wepay,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "riskified")]
	Riskified,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "utb")]
	Utb,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "adp_roll")]
	AdpRoll,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "fortress_trust")]
	FortressTrust,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "bond")]
	Bond,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "bakkt")]
	Bakkt,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "teal")]
	Teal,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "zero_hash")]
	ZeroHash,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "taba_pay")]
	TabaPay,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "knot")]
	Knot,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "sardine")]
	Sardine,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "alloy")]
	Alloy,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "finix")]
	Finix,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "nuvei")]
	Nuvei,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "layer")]
	Layer,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "boom")]
	Boom,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "paynote")]
	Paynote,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "stake")]
	Stake,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "wedbush")]
	Wedbush,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "esusu")]
	Esusu,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ansa")]
	Ansa,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "scribeup")]
	Scribeup,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "straddle")]
	Straddle,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "loanpro")]
	Loanpro,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "bloom_credit")]
	BloomCredit,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "sfox")]
	Sfox,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "brale")]
	Brale,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "parafin")]
	Parafin,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "cardless")]
	Cardless,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "open_ledger")]
	OpenLedger,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "valon")]
	Valon,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "gainbridge")]
	Gainbridge,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "cardlytics")]
	Cardlytics,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "pinwheel")]
	Pinwheel,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "thread_bank")]
	ThreadBank,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "array")]
	Array,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
