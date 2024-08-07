using NETDiscord.Api.Common;
using NETDiscord.Api.Users;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NETDiscord.Api.Converters
{
	internal class LocaleJsonConverter : JsonConverter<Locale>
	{
		public override bool CanConvert(Type typeToConvert) => typeToConvert == typeof(Locale);
		public override Locale Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.TokenType != JsonTokenType.String ? throw new JsonException() : reader.GetString()!.ToLocale();
		public override void Write(Utf8JsonWriter writer, Locale value, JsonSerializerOptions options) => writer.WriteStringValue(value.AsString());
	}
}
