using Going.Plaid.Converters;

namespace System.Text.Json;

/// <summary>
/// Plaid-specific extension methods for <see cref="JsonSerializerOptions"/>
/// </summary>
public static class PlaidExtensions
{
	/// <summary>
	/// Extension method to add Plaid converters to a <see cref="JsonSerializerOptions"/> object
	/// </summary>
	/// <param name="options">The object to which to add the converters</param>
	/// <returns>The object passed in, with the Plaid converters added</returns>
	public static JsonSerializerOptions AddPlaidConverters(this JsonSerializerOptions options)
	{
		options.Converters.Add(new DateTimeConverter());
		options.Converters.Add(new DateTimeOffsetConverter());
		options.Converters.Add(new EnumConverterFactory());
		options.Converters.Add(new EnumDictionaryConverterFactory());
		return options;
	}
}
