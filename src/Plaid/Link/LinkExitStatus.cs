using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Going.Plaid.Link
{
	/// <summary>
	/// In the Plaid Link flow, there can be events that cause the flow to exit prematurely.<br/>
	/// Plaid returns a <pre>status</pre> field containing a value that indicates at what stage of 
	/// the Link Flow the user exited.<br/>
	/// </summary>
	/// <remarks>See: <see href="https://plaid.com/docs/#metadata-status"/></remarks>
	public enum LinkExitStatus
	{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
		[Description("User prompted to answer security question(s)")]
		[EnumMember(Value = "requires_questions")]
		RequiresQuestions,
		[Description("User prompted to answer multiple choice question(s)")]
		[EnumMember(Value = "requires_selections")]
		RequiresSelections,
		[Description("User prompted to provide a one-time passcode")]
		[EnumMember(Value = "requires_code")]
		RequiresCode,
		[Description("User prompted to select a device on which to receive a one-time passcode")]
		[EnumMember(Value = "choose_device")]
		ChooseDevice,
		[Description(
			"User prompted to provide credentials for the selected financial institution " +
			"or has not yet selected a financial institution")]
		[EnumMember(Value = "requires_credentials")]
		RequiresCredentials,
		[Description(
			"User exited the Link flow after unsuccessfully (no results returned) " +
			"searching for a financial institution")]
		[EnumMember(Value = "institution_not_found")]
		InstitutionNotFound
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}
