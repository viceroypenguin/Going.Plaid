namespace Going.Plaid.Converters;

/// <inheritdoc/>
public class DateTimeOffsetConverter : JsonConverter<DateTimeOffset>
{
	/// <inheritdoc/>
	public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
		DateTimeOffset.Parse(
			reader.GetString() ?? string.Empty,
			System.Globalization.CultureInfo.InvariantCulture);

	/// <inheritdoc/>
	public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options) =>
		writer.WriteStringValue(
			value.UtcDateTime.ToString(
				"yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'",
				System.Globalization.CultureInfo.InvariantCulture));
}
