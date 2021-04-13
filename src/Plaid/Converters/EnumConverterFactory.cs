using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Going.Plaid.Converters
{
	/// <inheritdoc/>
	public class EnumConverterFactory : JsonConverterFactory
	{
		/// <inheritdoc/>
		public override bool CanConvert(Type typeToConvert) => typeToConvert.IsEnum || (Nullable.GetUnderlyingType(typeToConvert)?.IsEnum ?? false);

		/// <inheritdoc/>
		public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
		{
			if (_converters.TryGetValue(typeToConvert, out var c))
				return c;

			if (typeToConvert.IsEnum)
			{
				var converter = (JsonConverter)Activator.CreateInstance(
					typeof(EnumMemberEnumConverterNotNull<>).MakeGenericType(typeToConvert))!;
				var d = new Dictionary<Type, JsonConverter>(_converters) { [typeToConvert] = converter, };
				_converters = d;
				return converter;
			}
			else if (Nullable.GetUnderlyingType(typeToConvert)?.IsEnum ?? false)
			{
				var converter = (JsonConverter)Activator.CreateInstance(
					typeof(EnumMemberEnumConverterNull<>).MakeGenericType(Nullable.GetUnderlyingType(typeToConvert)!))!;
				var d = new Dictionary<Type, JsonConverter>(_converters) { [typeToConvert] = converter, };
				_converters = d;
				return converter;
			}
			else
				throw new InvalidOperationException($"Attempted to create converter for type we cannot convert. Type: {typeToConvert.FullName}");
		}

		private Dictionary<Type, JsonConverter> _converters = new Dictionary<Type, JsonConverter>();

		internal class EnumMemberEnumConverterNotNull<T> : JsonConverter<T>
			where T : struct, Enum
		{
			public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
				reader.TokenType == JsonTokenType.Null
					? throw new JsonException($"Expected a non-null enum value, found null.")
					: EnumMemberEnumConverterNotNull<T>.DoRead(ref reader);

			public static T DoRead(ref Utf8JsonReader reader)
			{
				if (reader.TokenType == JsonTokenType.Number)
				{
					var i = reader.GetInt32();
					return Unsafe.As<int, T>(ref i);
				}

				var enumText = reader.GetString();
				if (Enum.TryParse<T>(enumText, out var e)
					|| Enum.TryParse<T>(enumText, ignoreCase: true, out e))
					return e;

				foreach (var value in typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static))
				{
					var ema = value.GetCustomAttribute<EnumMemberAttribute>();
					if (ema?.Value != null && ema.Value.Equals(enumText, StringComparison.OrdinalIgnoreCase))
						return (T)value.GetRawConstantValue()!;
				}

				// we don't actually expect to get here.
				throw new InvalidOperationException($"Unexpected token {enumText} when parsing enum.");
			}

			public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) =>
				EnumMemberEnumConverterNotNull<T>.DoWrite(writer, value);

			public static void DoWrite(Utf8JsonWriter writer, T value)
			{
				var memInfo = value.GetType().GetMember(value.ToString()!);
				var attr = memInfo[0].GetCustomAttribute<EnumMemberAttribute>();
				writer.WriteStringValue(
					attr?.Value
					?? value.ToString()!.ToLower());
			}
		}

		internal class EnumMemberEnumConverterNull<T> : JsonConverter<T?>
			where T : struct, Enum
		{
			public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
				reader.TokenType == JsonTokenType.Null
					? default(T?)
					: EnumMemberEnumConverterNotNull<T>.DoRead(ref reader);

			public override void Write(Utf8JsonWriter writer, T? value, JsonSerializerOptions options)
			{
				if (value == null)
				{
					writer.WriteNullValue();
					return;
				}

				EnumMemberEnumConverterNotNull<T>.DoWrite(writer, value.Value);
			}
		}
	}
}
