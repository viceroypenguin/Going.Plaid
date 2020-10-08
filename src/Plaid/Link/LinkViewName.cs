using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Going.Plaid.Link
{
	/// <summary>
	/// The names of the various Plaid-provided views in the Link flow.<br/>
	/// These are used in the <see cref="OnEventMetadata"/> data structures for 
	/// deserializing the metadata in the Plaid Link Javascript responses/events.
	/// </summary>
	/// <remarks>See: <see href="https://plaid.com/docs/#metadata-view_name"/></remarks>
	public enum LinkViewName
	{
		/// <summary>
		/// The user has connected their account.
		/// </summary>
		[EnumMember(Value = "CONNECTED")]
		Connected,

		/// <summary>
		/// We ask the user to consent to the privacy policy.
		/// </summary>
		[EnumMember(Value = "CONSENT")]
		Consent,

		/// <summary>
		/// Asking the user for their account credentials.
		/// </summary>
		[EnumMember(Value = "CREDENTIAL")]
		Credential,

		/// <summary>
		/// An error has occurred.
		/// </summary>
		[EnumMember(Value = "ERROR")]
		Error,

		/// <summary>
		/// Confirming if the user wishes to close Link.
		/// </summary>
		[EnumMember(Value = "EXIT")]
		Exit,

		/// <summary>
		/// Link is making a request to our servers.
		/// </summary>
		[EnumMember(Value = "LOADING")]
		Loading,

		/// <summary>
		/// The user is asked by the institution for additional MFA authentication.
		/// </summary>
		[EnumMember(Value = "MFA")]
		Mfa,

		/// <summary>
		/// The user is asked to insert their account and routing numbers.
		/// </summary>
		[EnumMember(Value = "NUMBERS")]
		Numbers,

		/// <summary>
		/// The user was presented with a Google reCAPTCHA to verify they are human.
		/// </summary>
		[EnumMember(Value = "RECAPTCHA")]
		Recaptcha,

		/// <summary>
		/// We ask the user to choose an account.
		/// </summary>
		[EnumMember(Value = "SELECT_ACCOUNT")]
		SelectAccount,

		/// <summary>
		/// We ask the user to choose their institution.
		/// </summary>
		[EnumMember(Value = "SELECT_INSTITUTION")]
		SelectInstitution
	}
}
