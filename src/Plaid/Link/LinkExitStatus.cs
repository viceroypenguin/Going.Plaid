using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Going.Plaid.Link
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>See: <see href="https://plaid.com/docs/#metadata-status"/></remarks>
	public enum LinkExitStatus
	{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
		[Description("User prompted to answer security question(s)")]
		requires_questions,
		[Description("User prompted to answer multiple choice question(s)")]
		requires_selections,
		[Description("User prompted to provide a one-time passcode")]
		requires_code,
		[Description("User prompted to select a device on which to receive a one-time passcode")]
		choose_device,
		[Description(
			"User prompted to provide credentials for the selected financial institution " +
			"or has not yet selected a financial institution")]
		requires_credentials,
		[Description(
			"User exited the Link flow after unsuccessfully (no results returned) " +
			"searching for a financial institution")]
		institution_not_found
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}
