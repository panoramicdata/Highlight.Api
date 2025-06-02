using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Highlight.Api.Converters;

internal class BetterJsonStringEnumConverter : JsonConverterFactory
{
	public override bool CanConvert(Type typeToConvert)
	{
		return typeToConvert.IsEnum;
	}

	public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
	{
		var converterType = typeof(EnumMemberConverter<>).MakeGenericType(typeToConvert);
		return (JsonConverter)Activator.CreateInstance(converterType);
	}

	private class EnumMemberConverter<T> : JsonConverter<T> where T : struct, Enum
	{
		private readonly Dictionary<string, T> _fromValue = [];
		private readonly Dictionary<T, string> _toValue = [];

		public EnumMemberConverter()
		{

			foreach (var field in typeof(T).GetFields().Where(f => f.IsStatic))
			{
				var enumValue = (T)field.GetValue(null);
				var enumMemberAttr = field.GetCustomAttributes(typeof(EnumMemberAttribute), false)
					.Cast<EnumMemberAttribute>()
					.FirstOrDefault();

				var value = enumMemberAttr?.Value ?? field.Name;
				_fromValue[value] = enumValue;
				_toValue[enumValue] = value;
			}
		}

		public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			var value = reader.GetString();
			if (_fromValue.TryGetValue(value, out var result))
			{
				return result;
			}

			throw new JsonException($"Unknown {typeof(T).Name} enum value: {value}");
		}

		public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
		{
			if (_toValue.TryGetValue(value, out var stringValue))
			{
				writer.WriteStringValue(stringValue);
			}
			else
			{
				writer.WriteStringValue(value.ToString());
			}
		}
	}
}