using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Enum Processor
	/// </summary>
	/// <seealso href="https://plaid.com/docs/api/processors/#processor-token-create-request-processor"/>
	public enum Processor
	{
		/// <summary>
		/// ACH Processing Solutions
		/// </summary>
		/// <seealso href="https://achq.com/"/>
		[EnumMember(Value = "achq")]
		Achq,

		/// <summary>
		/// Checkbook Payments Solutions
		/// </summary>
		/// <seealso href="https://checkbook.io/"/>
		[EnumMember(Value = "checkbook")]
		Checkbook,

		/// <summary>
		/// Circle Payments System
		/// </summary>
		/// <seealso href="https://www.circle.com/"/>
		[EnumMember(Value = "circle")]
		circle,

		/// <summary>
		/// DriveWealth Investment System
		/// </summary>
		/// <seealso href="https://drivewealth.com/"/>
		[EnumMember(Value = "drivewealth")]
		DriveWealth,

		/// <summary>
		/// Dwolla Payments Infrastructure
		/// </summary>
		/// <seealso href="https://www.dwolla.com/"/>
		[EnumMember(Value = "dwolla")]
		Dwolla,

		/// <summary>
		/// Galileo Card Management System
		/// </summary>
		/// <seealso href="https://www.galileo-ft.com/"/>
		[EnumMember(Value = "galileo")]
		Galileo,

		/// <summary>
		/// Interactive Brokers Investment System
		/// </summary>
		/// <seealso href="https://www.interactivebrokers.com/"/>
		[EnumMember(Value = "interactive_brokers")]
		InteractiveBrokers,

		/// <summary>
		/// Modern Treasury Payments System
		/// </summary>
		/// <seealso href="https://www.moderntreasury.com/"/>
		[EnumMember(Value = "modern_treasury")]
		ModernTreasury,

		/// <summary>
		/// Ocrulus Document Management System
		/// </summary>
		/// <seealso href="https://www.ocrolus.com/"/>
		[EnumMember(Value = "ocrolus")]
		Ocrolus,

		/// <summary>
		/// Prime Trust Financial System
		/// </summary>
		/// <seealso href="https://www.primetrust.com/"/>
		[EnumMember(Value = "prime_trust")]
		PrimeTrust,

		/// <summary>
		/// Velox Clearing Firm
		/// </summary>
		/// <seealso href="https://www.velox-global.com/Home"/>
		[EnumMember(Value = "velox")]
		Velox,

		/// <summary>
		/// Vesta Fraud Prevention System
		/// </summary>
		/// <seealso href="https://trustvesta.com/"/>
		[EnumMember(Value = "vesta")]
		Vesta,

		/// <summary>
		/// VoPay Payments Management System
		/// </summary>
		/// <seealso href="https://vopay.com/"/>
		[EnumMember(Value = "vopay")]
		VoPay,
	}
}
