using System.Collections.Immutable;
using System.Text.Json.Serialization;
using static System.Text.Json.Serialization.JsonIgnoreCondition;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#welcome-screen-object">Discord API documentation</see>
	/// </summary>
	public record class WelcomeScreenObject : ApiObject
	{
		[JsonIgnore(Condition = Never)]
		public string? Description { get; init; }

		public ImmutableArray<WelcomeScreenChannelObject> WelcomeChannels { get; init; }
	}
}
