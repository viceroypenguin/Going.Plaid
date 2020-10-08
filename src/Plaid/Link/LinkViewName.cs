using System;
using System.Collections.Generic;
using System.ComponentModel;
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
		[Description("The user has connected their account.")]
		[EnumMember(Value = "CONNECTED")]
		Connected,

		/// <summary>
		/// We ask the user to consent to the privacy policy.
		/// </summary>
		[Description("We ask the user to consent to the privacy policy.")]
		[EnumMember(Value = "CONSENT")]
		Consent,

		/// <summary>
		/// Asking the user for their account credentials.
		/// </summary>
		[Description("Asking the user for their account credentials.")]
		[EnumMember(Value = "CREDENTIAL")]
		Credential,

		/// <summary>
		/// An error has occurred.
		/// </summary>
		[Description("An error has occurred.")]
		[EnumMember(Value = "ERROR")]
		Error,

		/// <summary>
		/// Confirming if the user wishes to close Link.
		/// </summary>
		[Description("Confirming if the user wishes to close Link.")]
		[EnumMember(Value = "EXIT")]
		Exit,

		/// <summary>
		/// Link is making a request to our servers.
		/// </summary>
		[Description("Link is making a request to our servers.")]
		[EnumMember(Value = "LOADING")]
		Loading,

		/// <summary>
		/// The user is asked by the institution for additional MFA authentication.
		/// </summary>
		[Description("The user is asked by the institution for additional MFA authentication.")]
		[EnumMember(Value = "MFA")]
		Mfa,

		/// <summary>
		/// The user is asked to insert their account and routing numbers.
		/// </summary>
		[Description("The user is asked to insert their account and routing numbers.")]
		[EnumMember(Value = "NUMBERS")]
		Numbers,

		/// <summary>
		/// The user was presented with a Google reCAPTCHA to verify they are human.
		/// </summary>
		[Description("The user was presented with a Google reCAPTCHA to verify they are human.")]
		[EnumMember(Value = "RECAPTCHA")]
		Recaptcha,

		/// <summary>
		/// We ask the user to choose an account.
		/// </summary>
		[Description("We ask the user to choose an account.")]
		[EnumMember(Value = "SELECT_ACCOUNT")]
		SelectAccount,

		/// <summary>
		/// We ask the user to choose their institution.
		/// </summary>
		[Description("We ask the user to choose their institution.")]
		[EnumMember(Value = "SELECT_INSTITUTION")]
		SelectInstitution
	}
}
