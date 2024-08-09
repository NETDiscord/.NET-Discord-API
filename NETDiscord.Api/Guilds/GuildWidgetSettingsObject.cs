using System.Text.Json.Serialization;
using static System.Text.Json.Serialization.JsonIgnoreCondition;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#guild-widget-settings-object">Discord API documentation</see>
	/// </summary>
	public record class GuildWidgetSettingsObject : ApiObject
	{
		public required bool Enabled { get; init; }

		[JsonIgnore(Condition = Never)]
		public ulong? ChannelID { get; init; }
	}
}
