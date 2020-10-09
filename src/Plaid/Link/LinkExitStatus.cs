using System.Runtime.Serialization;

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
		/// <summary>
		/// User prompted to answer security questions
		/// </summary>
		[EnumMember(Value = "requires_questions")]
		RequiresQuestions,

		/// <summary>
		/// User prompted to answer multiple choice question(s)
		/// </summary>
		[EnumMember(Value = "requires_selections")]
		RequiresSelections,

		/// <summary>
		/// User prompted to provide a one-time passcode
		/// </summary>
		[EnumMember(Value = "requires_code")]
		RequiresCode,

		/// <summary>
		/// User prompted to select a device on which to receive a one-time passcode
		/// </summary>
		[EnumMember(Value = "choose_device")]
		ChooseDevice,

		/// <summary>
		/// User prompted to provide credentials for the selected financial institution or has not yet selected a financial institution
		/// </summary>
		[EnumMember(Value = "requires_credentials")]
		RequiresCredentials,

		/// <summary>
		/// User exited the Link flow after unsuccessfully (no results returned) searching for a financial institution
		/// </summary>
		[EnumMember(Value = "institution_not_found")]
		InstitutionNotFound
	}
}
