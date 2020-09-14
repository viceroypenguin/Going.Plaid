using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Going.Plaid.Link
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	/// <summary>
	/// A broad categorization of the error.
	/// </summary>
	/// <remarks>See: <see href="https://plaid.com/docs/#errors-overview"/></remarks>
	public enum PlaidErrorType
	{
		[Description("Returned when the request is malformed and cannot be processed.")]
		INVALID_REQUEST,

		[Description(
			"Returned when all fields are provided and are in the correct format, " +
			"but the values provided are incorrect in some way.")]
		INVALID_INPUT,

		[Description("Returned when there are errors for the requested financial institution.")]
		INSTITUTION_ERROR,

		[Description(
			"Returned when the request is valid but has exceeded established rate limits. " +
			"All API endpoints are rate limited and all data-access endpoints are rate limited" +
			"by access_token. Exact limits are dynamic and are designed to prevent any single" +
			"source of traffic from impacting overall API stability.")]
		RATE_LIMIT_EXCEEDED,

		[Description("Returned during planned maintenance windows and in response to API errors.")]
		API_ERROR,

		[Description(
			"Information provided for the Item (such as credentials or MFA) may be invalid or " +
			"the Item is not supported on Plaid's platform. You'll encounter ITEM_ERRORs as your users " +
			"use Link via the onExit() callback.")]
		ITEM_ERROR,

		[Description("The AUTH_ERROR error type identifies a class of issues related to verifying and pulling Auth numbers data.")]
		AUTH_ERROR,

		/// <summary>
		/// 
		/// </summary>
		///<remarks>See: <see href="https://plaid.com/docs/#asset-report-errors-and-warnings"/></remarks>
		[Description(
			"Identifies a class of issues related to the creation of an Asset Report. " +
			"ASSET_REPORT_ERROR is used for errors that prevent the creation of an Asset Report.")]
		ASSET_REPORT_ERROR
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
