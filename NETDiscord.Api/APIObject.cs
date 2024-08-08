using NETDiscord.Api.Converters;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using JsonConverters;

namespace NETDiscord.Api
{
	public abstract class ApiObject
	{
		private static readonly JsonSerializerOptions _options = new()
		{
			IncludeFields = false,
			WriteIndented = false,
			AllowTrailingCommas = false,
			NumberHandling = JsonNumberHandling.Strict,
			ReadCommentHandling = JsonCommentHandling.Skip,
			UnmappedMemberHandling = JsonUnmappedMemberHandling.Skip,
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
			DictionaryKeyPolicy = JsonNamingPolicy.SnakeCaseLower,
			PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
			Converters =
			{
				new TupleConverter(),
				new ImmutableArrayConverter(),
				new ServiceJsonConverter(),
				new LocaleJsonConverter()
			},
			TypeInfoResolver = new DefaultJsonTypeInfoResolver()
			{
				Modifiers = { SerializeLongAsString }
			}
		};

		private static void SerializeLongAsString(JsonTypeInfo jsonTypeInfo)
		{
			if (jsonTypeInfo.Type == typeof(long) || jsonTypeInfo.Type == typeof(ulong))
			{
				jsonTypeInfo.NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString;
			};
		}
		public override string ToString() => JsonSerializer.Serialize(this, GetType(), _options);
		public static T? FromString<T>(string json) where T : ApiObject => JsonSerializer.Deserialize<T>(json, _options);
	}
}