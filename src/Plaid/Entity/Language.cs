using System.Runtime.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Used to tell Plaid which language to use in the Plaid Link Tool.
	/// </summary>
	public enum Language
	{
		/// <summary>
		/// Use English in the Plaid Link Tool
		/// </summary>
		[EnumMember(Value = "en")]
		English,

		/// <summary>
		/// Use French in the Plaid Link Tool
		/// </summary>
		[EnumMember(Value = "fr")]
		French,

		/// <summary>
		/// Use Spanish in the Plaid Link Tool
		/// </summary>
		[EnumMember(Value = "es")]
		Spanish,

		/// <summary>
		/// Use Dutch in the Plaid Link Tool
		/// </summary>
		[EnumMember(Value = "nl")]
		Dutch,
	}
}
