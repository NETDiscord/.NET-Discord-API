using NETDiscord.Api.Users;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NETDiscord.Api.Converters
{
	internal class ServiceJsonConverter : JsonConverter<Service>
	{
		public override bool CanConvert(Type typeToConvert) => typeToConvert == typeof(Service);
		public override Service Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.TokenType != JsonTokenType.String ? throw new JsonException() : reader.GetString()!.ToService();
		public override void Write(Utf8JsonWriter writer, Service value, JsonSerializerOptions options) => writer.WriteStringValue(value.AsString());
	}
}
