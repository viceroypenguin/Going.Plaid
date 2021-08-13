using System.Collections.Generic;

namespace Going.Plaid.Converters;

/// <inheritdoc/>
public class EnumDictionaryConverterFactory : JsonConverterFactory
{
	/// <inheritdoc/>
	public override bool CanConvert(Type typeToConvert) =>
		typeToConvert.IsGenericType
		&& typeToConvert.GetGenericTypeDefinition() == typeof(Dictionary<,>)
		&& typeToConvert.GetGenericArguments()[0].IsEnum;

	/// <inheritdoc/>
	public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
	{
		if (_converters.TryGetValue(typeToConvert, out var c))
			return c;

		var keyType = typeToConvert.GetGenericArguments()[0];
		var valueType = typeToConvert.GetGenericArguments()[1];

		var converter = (JsonConverter)Activator.CreateInstance(
			typeof(DictionaryEnumConverterInner<,>).MakeGenericType(
				new Type[] { keyType, valueType }),
			args: new object[] { options, })!;

		var d = new Dictionary<Type, JsonConverter>(_converters) { [typeToConvert] = converter, };
		_converters = d;
		return converter;
	}

	private Dictionary<Type, JsonConverter> _converters = new();

	internal class DictionaryEnumConverterInner<TKey, TValue> :
		JsonConverter<Dictionary<TKey, TValue>>
		where TKey : struct, Enum
	{
		private readonly JsonConverter<TValue> _valueConverter;
		private readonly Type _valueType;

		public DictionaryEnumConverterInner(JsonSerializerOptions options)
		{
			_valueType = typeof(TValue);

			_valueConverter = (JsonConverter<TValue>)options.GetConverter(_valueType);
		}

		public override Dictionary<TKey, TValue>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.Null)
			{
				return null;
			}

			if (reader.TokenType != JsonTokenType.StartObject)
			{
				throw new JsonException();
			}

			var dictionary = new Dictionary<TKey, TValue>();

			while (reader.Read())
			{
				if (reader.TokenType == JsonTokenType.EndObject)
				{
					return dictionary;
				}

				if (reader.TokenType != JsonTokenType.PropertyName)
				{
					throw new JsonException();
				}

				var key = EnumConverterFactory.EnumMemberEnumConverterNotNull<TKey>
					.DoRead(ref reader);

				TValue value;
				if (_valueConverter != null)
				{
					reader.Read();
					// assert non-null, even if may be null; _we're_ not reading it...
					value = _valueConverter.Read(ref reader, _valueType, options)!;
				}
				else
				{
					// assert non-null, even if may be null; _we're_ not reading it...
					value = JsonSerializer.Deserialize<TValue>(ref reader, options)!;
				}

				// Add to dictionary.
				dictionary.Add(key, value);
			}

			throw new JsonException();
		}

		public override void Write(Utf8JsonWriter writer, Dictionary<TKey, TValue>? value, JsonSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return;
			}

			writer.WriteStartObject();

			foreach ((var key, var val) in value)
			{
				var name = EnumConverterFactory.EnumMemberEnumConverterNotNull<TKey>
					.GetEnumValue(key);
				writer.WritePropertyName(name);

				if (_valueConverter != null)
				{
					_valueConverter.Write(writer, val, options);
				}
				else
				{
					JsonSerializer.Serialize(writer, val, options);
				}
			}

			writer.WriteEndObject();
		}
	}
}
