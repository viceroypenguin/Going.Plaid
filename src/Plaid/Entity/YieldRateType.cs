namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of rate which indicates how the predicted yield was calculated. It is one of:</para>
/// </summary>
public enum YieldRateType
{
	/// <summary>
	/// <para>the annualized interest rate for securities with a one-year term or longer, such as treasury notes and bonds.</para>
	/// </summary>
	[EnumMember(Value = "coupon")]
	Coupon,

	/// <summary>
	/// <para>the calculated equivalent for the annualized interest rate factoring in the discount rate and time to maturity, for shorter term, non-interest-bearing securities such as treasury bills.</para>
	/// </summary>
	[EnumMember(Value = "coupon_equivalent")]
	CouponEquivalent,

	/// <summary>
	/// <para>the rate at which the present value or cost is discounted from the future value upon maturity, also known as the face value.</para>
	/// </summary>
	[EnumMember(Value = "discount")]
	Discount,

	/// <summary>
	/// <para>the total predicted rate of return factoring in both the discount rate and the coupon rate, applicable to securities such as exchange-traded bonds which can both be interest-bearing as well as sold at a discount off its face value.</para>
	/// </summary>
	[EnumMember(Value = "yield")]
	Yield,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
