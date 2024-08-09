using NETDiscord.Api.Common;
using NETDiscord.Api.Guilds;
using NETDiscord.Api.OAuth2;
using NETDiscord.Api.Users;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NETDiscord.Api.Converters
{
	internal class GuildFeatureJsonConverter : JsonConverter<GuildFeature>
	{
		public override bool CanConvert(Type typeToConvert) => typeToConvert == typeof(GuildFeature);
		public override GuildFeature Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.TokenType != JsonTokenType.String ? throw new JsonException() : reader.GetString()!.ToGuildFeature();
		public override void Write(Utf8JsonWriter writer, GuildFeature value, JsonSerializerOptions options) => writer.WriteStringValue(value.AsString());
	}
}
