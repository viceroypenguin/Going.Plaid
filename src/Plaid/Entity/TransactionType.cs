using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Where the transaction occurred
	/// </summary>
	[Obsolete("TransactionType will be deprecated in the future.")]
	public enum TransactionType
	{
		/// <summary>
		/// transactions that took place online.
		/// </summary>
		[EnumMember(Value = "digital")]
		Digital,

		/// <summary>
		/// transactions that were made at a physical location.
		/// </summary>
		[EnumMember(Value = "place")]
		Place,

		/// <summary>
		/// transactions that relate to banks, e.g. fees or deposits.
		/// </summary>
		[EnumMember(Value = "special")]
		Special,

		/// <summary>
		/// transactions that do not fit into the other three types.
		/// </summary>
		[EnumMember(Value = "unresolved")]
		Unresolved,
	}
}
