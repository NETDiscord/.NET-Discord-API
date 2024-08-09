using NETDiscord.Api.Users;
using System.Text.Json.Serialization;
using static System.Text.Json.Serialization.JsonIgnoreCondition;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#ban-object">Discord API documentation</see>
	/// </summary>
	public record class BanObject : ApiObject
	{
		[JsonIgnore(Condition = Never)]
		public string? Reason { get; init; }

		public required UserObject User { get; init; }
	}
}
