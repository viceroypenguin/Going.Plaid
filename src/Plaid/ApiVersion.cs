namespace Going.Plaid;

/// <summary>
/// Used to specify which version of the Plaid API is used to query for Plaid data.
/// </summary>
public enum ApiVersion
{
	/// <summary>
	/// API Version "2017-03-08"
	/// </summary>
	[Obsolete("Plaid has moved to version 2020-09-14. Please update your code.")]
	v20170308,

	/// <summary>
	/// API Version "2018-05-22"
	/// </summary>
	[Obsolete("Plaid has moved to version 2020-09-14. Please update your code.")]
	v20180522,

	/// <summary>
	/// API Version "2019-05-29"
	/// </summary>
	[Obsolete("Plaid has moved to version 2020-09-14. Please update your code.")]
	v20190529,

	/// <summary>
	/// API Version "2020-09-14"
	/// </summary>
	v20200914,
}
