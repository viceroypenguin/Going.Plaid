using System;
using System.Collections.Generic;
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
		[EnumMember(Value = "requires_questions")]
		RequiresQuestions,

		[EnumMember(Value = "requires_selections")]
		RequiresSelections,

		[EnumMember(Value = "requires_code")]
		RequiresCode,

		[EnumMember(Value = "choose_device")]
		ChooseDevice,

		[EnumMember(Value = "requires_credentials")]
		RequiresCredentials,

		[EnumMember(Value = "institution_not_found")]
		InstitutionNotFound
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	}
}
