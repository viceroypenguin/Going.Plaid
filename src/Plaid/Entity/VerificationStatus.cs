using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// The current verification status of an Auth <see cref="Item" /> initiated through Automated or Manual micro-deposits.  Returned for Auth <see cref="Item" />s only.
	/// </summary>
	public enum VerificationStatus
	{
		/// <summary>
		/// The <see cref="Item" /> is pending automatic verification
		/// </summary>
		[EnumMember(Value = "pending_automatic_verification")]
		PendingAutomaticVerification,

		/// <summary>
		/// The <see cref="Item" /> is pending manual micro-deposit verification. <see cref="Item" />s remain in this state until the user successfully verifies the two amounts.
		/// </summary>
		[EnumMember(Value = "pending_manual_verification")]
		PendingManualVerification,

		/// <summary>
		/// The <see cref="Item" /> has successfully been automatically verified
		/// </summary>
		[EnumMember(Value = "automatically_verified")]
		AutomaticallyVerified,

		/// <summary>
		/// The <see cref="Item" /> has successfully been manually verified
		/// </summary>
		[EnumMember(Value = "manually_verified")]
		ManuallyVerified,

		/// <summary>
		/// Plaid was unable to automatically verify the deposit within 7 calendar days and will no longer attempt to validate the <see cref="Item" />. Users may retry by submitting their information again through Link.
		/// </summary>
		[EnumMember(Value = "verification_expired")]
		VerificationExpired,

		/// <summary>
		/// The <see cref="Item" /> failed manual micro-deposit verification because the user exhausted all 3 verification attempts. Users may retry by submitting their information again through Link.
		/// </summary>
		[EnumMember(Value = "verification_failed")]
		VerificationFailed,
	}
}
