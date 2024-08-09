using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using static System.Text.Json.Serialization.JsonIgnoreCondition;
using System.Threading.Tasks;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#guild-widget-settings-object">Discord API documentation</see>
	/// </summary>
	public class GuildWidgetSettingsObject : ApiObject
	{
		public required bool Enabled { get; init; }

		[JsonIgnore(Condition = Never)]
		public ulong? ChannelID { get; init; }
	}
}
