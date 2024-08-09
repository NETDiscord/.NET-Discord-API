using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using static System.Text.Json.Serialization.JsonIgnoreCondition;
using System.Threading.Tasks;
using System.Collections.Immutable;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#welcome-screen-object">Discord API documentation</see>
	/// </summary>
	public class WelcomeScreenObject : ApiObject
	{
		[JsonIgnore(Condition = Never)]
		public string? Description { get; init; }

		public ImmutableArray<WelcomeScreenChannelObject> WelcomeChannels { get; init; }
	}
}
