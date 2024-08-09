using NETDiscord.Api.Common;
using NETDiscord.Api.Guilds;
using NETDiscord.Api.OAuth2;
using NETDiscord.Api.Users;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NETDiscord.Api.Converters
{
	internal class OAuth2ScopeJsonConverter : JsonConverter<OAuth2Scope>
	{
		public override bool CanConvert(Type typeToConvert) => typeToConvert == typeof(OAuth2Scope);
		public override OAuth2Scope Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => reader.TokenType != JsonTokenType.String ? throw new JsonException() : reader.GetString()!.ToOAuth2Scope();
		public override void Write(Utf8JsonWriter writer, OAuth2Scope value, JsonSerializerOptions options) => writer.WriteStringValue(value.AsString());
	}
}
