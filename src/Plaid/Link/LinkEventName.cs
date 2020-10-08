using System.Runtime.Serialization;

namespace Going.Plaid.Link
{
	/// <summary>
	/// The event that has just occurred in the Link flow.
	/// </summary>
	/// <remarks>See: <see href="https://plaid.com/docs/#event-names"/></remarks>
	public enum LinkEventName
	{
		/// <summary>
		/// The user closed the third-party website or mobile app without completing the OAuth flow.
		/// </summary>
		[EnumMember(Value = "CLOSE_OAUTH")]
		CloseOAuth,

		/// <summary>
		/// A recoverable error occurred in the Link flow, see the error_code metadata.
		/// </summary>
		[EnumMember(Value = "ERROR")]
		Error,

		/// <summary>
		/// The user has exited without completing the Link flow and the onExit callback is fired.
		/// </summary>
		[EnumMember(Value = "EXIT")]
		Exit,

		/// <summary>
		/// The user encountered an error while completing the third-party's OAuth login flow.
		/// </summary>
		[EnumMember(Value = "FAIL_OAUTH")]
		FailOAuth,

		/// <summary>
		/// The user has completed the Link flow and the onSuccess callback is fired.
		/// </summary>
		[EnumMember(Value = "HANDOFF")]
		Handoff,

		/// <summary>
		/// The user has opened Link.
		/// </summary>
		[EnumMember(Value = "OPEN")]
		Open,

		/// <summary>
		/// The user has opened my.plaid.com. This event is only sent when Link is initialized with assets as a product
		/// </summary>
		[EnumMember(Value = "OPEN_MY_PLAID")]
		OpenMyPlaid,

		/// <summary>
		/// The user has navigated to a third-party website or mobile app in order to complete the OAuth login flow.
		/// </summary>
		[EnumMember(Value = "OPEN_OAUTH")]
		OpenOAuth,

		/// <summary>
		/// The user has searched for an institution.
		/// </summary>
		[EnumMember(Value = "SEARCH_INSTITUTION")]
		SearchInstitution,

		/// <summary>
		/// The user selected an institution.
		/// </summary>
		[EnumMember(Value = "SELECT_INSTITUTION")]
		SelectInstitution,

		/// <summary>
		/// The user has submitted credentials.
		/// </summary>
		[EnumMember(Value = "SUBMIT_CREDENTIALS")]
		SubmitCredentials,

		/// <summary>
		/// The user has submitted MFA.
		/// </summary>
		[EnumMember(Value = "SUBMIT_MFA")]
		SubmitMfa,

		/// <summary>
		/// The <see cref="TransitionView"/> event indicates that the user has moved from one view to the next.
		/// </summary>
		[EnumMember(Value = "TRANSITION_VIEW")]
		TransitionView,
	}
}
