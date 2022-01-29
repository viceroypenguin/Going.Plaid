using System.Reflection;
using System.Runtime.CompilerServices;

namespace Going.Plaid.Converters;

/// <inheritdoc/>
public class EnumConverterFactory : JsonConverterFactory
{
	/// <inheritdoc/>
	public override bool CanConvert(Type typeToConvert) =>
		typeToConvert.IsEnum
		|| (Nullable.GetUnderlyingType(typeToConvert)?.IsEnum ?? false);

	/// <inheritdoc/>
	public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
	{
		if (_converters.TryGetValue(typeToConvert, out var c))
			return c;

		static JsonConverter GetConverter(Type type)
		{
			if (type.IsEnum)
				return (JsonConverter)Activator.CreateInstance(
					typeof(EnumMemberEnumConverterNotNull<>).MakeGenericType(type))!;
			else if (Nullable.GetUnderlyingType(type)?.IsEnum ?? false)
				return (JsonConverter)Activator.CreateInstance(
					typeof(EnumMemberEnumConverterNull<>).MakeGenericType(Nullable.GetUnderlyingType(type)!))!;
			else
				throw new InvalidOperationException($"Attempted to create converter for type we cannot convert. Type: {type.FullName}");
		}

		var converter = GetConverter(typeToConvert);
		var d = new Dictionary<Type, JsonConverter>(_converters) { [typeToConvert] = converter, };
		_converters = d;
		return converter;
	}

	private Dictionary<Type, JsonConverter> _converters = new();

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

			// Plaid may return new/unknown values on parse. Don't crash at least...
#if NETCOREAPP3_1_OR_GREATER
			return Enum.Parse<T>("Undefined");
#else
			return (T)Enum.Parse(typeof(T), "Undefined");
#endif
		}

		public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) =>
			EnumMemberEnumConverterNotNull<T>.DoWrite(writer, value);

		public static void DoWrite(Utf8JsonWriter writer, T value) =>
			writer.WriteStringValue(
				EnumMemberEnumConverterNotNull<T>.GetEnumValue(value));

		public static string GetEnumValue(T value)
		{
			var memInfo = value.GetType().GetMember(value.ToString()!);
			var attr = memInfo[0].GetCustomAttribute<EnumMemberAttribute>();
			var name = attr?.Value ?? value.ToString()!.ToLower();
			return name;
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
