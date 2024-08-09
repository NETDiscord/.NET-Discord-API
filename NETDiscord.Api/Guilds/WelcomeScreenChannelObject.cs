using System.Text.Json.Serialization;
using static System.Text.Json.Serialization.JsonIgnoreCondition;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#welcome-screen-object-welcome-screen-channel-structure">Discord API documentation</see>
	/// </summary>
	public class WelcomeScreenChannelObject : ApiObject
	{
		public required ulong ChannelID { get; init; }
		public required string Description { get; init; }

		[JsonIgnore(Condition = Never)]
		public ulong? EmojiID { get; init; }

		[JsonIgnore(Condition = Never)]
		public string? EmojiName { get; init; }
	}
}
