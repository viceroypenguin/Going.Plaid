using System;
using System.Collections.Generic;
using System.Text;

namespace Going.Plaid.Utilities
{
	public static class EnumExtensions
	{
		public static string GetDescription(this Enum value, string defaultValue = default)
		{
			return
				value
					?.GetType()
					.GetMember(value.ToString())
					.FirstOrDefault()
					?.GetCustomAttribute<DescriptionAttribute>()
					?.Description
				?? defaultValue;
		}
	}
}
