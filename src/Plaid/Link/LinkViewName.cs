using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Going.Plaid.Link
{
	/// <summary>
	/// 
	/// </summary>
	/// <remarks>See: <see href="https://plaid.com/docs/#metadata-view_name"/></remarks>
	public enum LinkViewName
	{
		/// <summary>
		/// The user has connected their account.
		/// </summary>
		CONNECTED,
		/// <summary>
		/// We ask the user to consent to the privacy policy.
		/// </summary>
		CONSENT,
		/// <summary>
		/// Asking the user for their account credentials.
		/// </summary>
		CREDENTIAL,
		/// <summary>
		/// An error has occurred.
		/// </summary>
		ERROR,
		/// <summary>
		/// Confirming if the user wishes to close Link.
		/// </summary>
		EXIT,
		/// <summary>
		/// Link is making a request to our servers.
		/// </summary>
		LOADING,
		/// <summary>
		/// The user is asked by the institution for additional MFA authentication.
		/// </summary>
		MFA,
		/// <summary>
		/// The user is asked to insert their account and routing numbers.
		/// </summary>
		NUMBERS,
		/// <summary>
		/// The user was presented with a Google reCAPTCHA to verify they are human.
		/// </summary>
		RECAPTCHA,
		/// <summary>
		/// We ask the user to choose an account.
		/// </summary>
		SELECT_ACCOUNT,
		/// <summary>
		/// We ask the user to choose their institution.
		/// </summary>
		SELECT_INSTITUTION
	}
}
