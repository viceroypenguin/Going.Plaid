using System;
using System.Reflection;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Going.Plaid
{
	/// <summary>
	/// Converts an <see cref="Enum"/> to and from its name string value.
	/// </summary>
	public class EnumMemberEnumConverter : JsonConverter
	{
		/// <summary>
		/// Writes the JSON representation of the object.
		/// </summary>
		/// <param name="writer">The <see cref="JsonWriter"/> to write to.</param>
		/// <param name="value">The value.</param>
		/// <param name="serializer">The calling serializer.</param>
		public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}

			var memInfo = value.GetType().GetMember(value.ToString()!);
			var attr = memInfo[0].GetCustomAttribute<EnumMemberAttribute>();
			writer.WriteValue(
				attr?.Value
				?? value.ToString()!.ToLower());
		}

		/// <summary>
		/// Reads the JSON representation of the object.
		/// </summary>
		/// <param name="reader">The <see cref="JsonReader"/> to read from.</param>
		/// <param name="objectType">Type of the object.</param>
		/// <param name="existingValue">The existing value of object being read.</param>
		/// <param name="serializer">The calling serializer.</param>
		/// <returns>The object value.</returns>
		public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
		{
			var isNullable = IsNullableType(objectType);
			if (reader.TokenType == JsonToken.Null)
			{
				return isNullable
					? default(object)
					: throw new InvalidOperationException($"Cannot convert null value to {objectType}.");
			}

			var t = Nullable.GetUnderlyingType(objectType) ?? objectType;

			try
			{
				if (reader.TokenType == JsonToken.String)
				{
					var enumText = reader.Value?.ToString();

					if (string.IsNullOrWhiteSpace(enumText) && isNullable)
					{
						return null;
					}

					foreach (var value in t.GetMembers())
					{
						var ema = value.GetCustomAttribute<EnumMemberAttribute>();
						if (ema != null && ema.Value.Equals(enumText, StringComparison.OrdinalIgnoreCase))
							return value;
					}

					foreach (var value in t.GetMembers())
					{
						if (value.Name.Equals(enumText, StringComparison.OrdinalIgnoreCase))
							return value;
					}
				}
			}
			catch (Exception ex)
			{
				throw new InvalidOperationException($"Error converting value {reader.Value} to type '{objectType}'.", ex);
			}

			// we don't actually expect to get here.
			throw new InvalidOperationException($"Unexpected token {reader.TokenType} when parsing enum.");
		}

		/// <summary>
		/// Determines whether this instance can convert the specified object type.
		/// </summary>
		/// <param name="objectType">Type of the object.</param>
		/// <returns>
		/// <c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.
		/// </returns>
		public override bool CanConvert(Type objectType)
		{
			var t = IsNullableType(objectType)
				? Nullable.GetUnderlyingType(objectType)
				: objectType;

			return t!.IsEnum;
		}

		private static bool IsNullableType(Type t) =>
			t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>);
	}
}
