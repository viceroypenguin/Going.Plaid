using System;
using System.Collections.Generic;
using System.Text;

namespace Going.Plaid.Management
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>See: <see href="https://plaid.com/docs/#event-names"/></remarks>
	public enum PlaidLinkEventName
	{
		/// <summary>
		/// The user closed the third-party website or mobile app without completing the OAuth flow.
		/// </summary>
		CLOSE_OAUTH,
		/// <summary>
		/// A recoverable error occurred in the Link flow, see the error_code metadata.
		/// </summary>
		ERROR,
		/// <summary>
		/// The user has exited without completing the Link flow and the onExit callback is fired.
		/// </summary>
		EXIT,
		/// <summary>
		/// The user encountered an error while completing the third-party's OAuth login flow.
		/// </summary>
		FAIL_OAUTH,
		/// <summary>
		/// The user has completed the Link flow and the onSuccess callback is fired.
		/// </summary>
		HANDOFF,
		/// <summary>
		/// The user has opened Link.
		/// </summary>
		OPEN,
		/// <summary>
		/// The user has opened my.plaid.com. This event is only sent when Link is initialized with assets as a product
		/// </summary>
		OPEN_MY_PLAID,
		/// <summary>
		/// The user has navigated to a third-party website or mobile app in order to complete the OAuth login flow.
		/// </summary>
		OPEN_OAUTH,
		/// <summary>
		/// The user has searched for an institution.
		/// </summary>
		SEARCH_INSTITUTION,
		/// <summary>
		/// The user selected an institution.
		/// </summary>
		SELECT_INSTITUTION,
		/// <summary>
		/// The user has submitted credentials.
		/// </summary>
		SUBMIT_CREDENTIALS,
		/// <summary>
		/// The user has submitted MFA.
		/// </summary>
		SUBMIT_MFA,
		/// <summary>
		/// The TRANSITION_VIEW event indicates that the user has moved from one view to the next.
		/// </summary>
		TRANSITION_VIEW
	}
}
