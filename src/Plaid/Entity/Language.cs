using System.Runtime.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Used to tell Plaid which language to use in the Plaid Link Tool.
	/// </summary>
	public enum Language
	{
		/// <summary>
		/// Use Danish in the Plaid Link Tool.
		/// </summary>
		[EnumMember(Value = "da")]
		Danish,

		/// <summary>
		/// Use Dutch in the Plaid Link Tool.
		/// </summary>
		[EnumMember(Value = "nl")]
		Dutch,

		/// <summary>
		/// Use English in the Plaid Link Tool.
		/// </summary>
		[EnumMember(Value = "en")]
		English,

		/// <summary>
		/// Use Estonian in the Plaid Link Tool.
		/// </summary>
		[EnumMember(Value = "et")]
		Estonian,

		/// <summary>
		/// Use French in the Plaid Link Tool.
		/// </summary>
		[EnumMember(Value = "fr")]
		French,

		/// <summary>
		/// Use German in the Plaid Link Tool.
		/// </summary>
		[EnumMember(Value = "de")]
		German,

		/// <summary>
		/// Use Italian in the Plaid Link Tool.
		/// </summary>
		[EnumMember(Value = "it")]
		Italian,

		/// <summary>
		/// Use Latvian in the Plaid Link Tool.
		/// </summary>
		[EnumMember(Value = "lv")]
		Latvian,

		/// <summary>
		/// Use Lithuanian in the Plaid Link Tool.
		/// </summary>
		[EnumMember(Value = "lt")]
		Lithuanian,

		/// <summary>
		/// Use Norwegian in the Plaid Link Tool.
		/// </summary>
		[EnumMember(Value = "no")]
		Norwegian,

		/// <summary>
		/// Use Polish in the Plaid Link Tool.
		/// </summary>
		[EnumMember(Value = "po")]
		Polish,

		/// <summary>
		/// Use Romanian in the Plaid Link Tool.
		/// </summary>
		[EnumMember(Value = "ro")]
		Romanian,

		/// <summary>
		/// Use Spanish in the Plaid Link Tool.
		/// </summary>
		[EnumMember(Value = "es")]
		Spanish,

		/// <summary>
		/// Use Swedish in the Plaid Link Tool.
		/// </summary>
		[EnumMember(Value = "se")]
		Swedish,
	}
}
