using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Going.Plaid.Converters
{
	/// <inheritdoc/>
	public class DateTimeConverter : JsonConverter<DateTime>
	{
		/// <inheritdoc/>
		public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
			DateTime.Parse(reader.GetString() ?? string.Empty);

		/// <inheritdoc/>
		public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options) =>
			writer.WriteStringValue(
				value.ToString("yyyy-MM-dd"));
	}
}
