using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Going.Plaid.Utilities
{
	/// <summary>
	/// Extensions for the generic Enum
	/// </summary>
	public static class EnumExtensions
	{
		/// <summary>
		/// Read and return the Description value applied as an attribute to the <paramref name="value"/> in the source for this Enum
		/// </summary>
		/// <param name="value"></param>
		/// <param name="defaultValue"></param>
		/// <returns></returns>
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
