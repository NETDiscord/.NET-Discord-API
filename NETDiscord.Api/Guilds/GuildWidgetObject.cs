using System.Text.Json.Serialization;
using static System.Text.Json.Serialization.JsonIgnoreCondition;
using System.Collections.Immutable;
using NETDiscord.Api.Channels;
using NETDiscord.Api.Users;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#guild-widget-object">Discord API documentation</see>
	/// </summary>
	public record class GuildWidgetObject : ApiObject
	{
		public required ulong ID { get; init; }
		public required string Name { get; init; }

		[JsonIgnore(Condition = Never)]
		public string? InstantInvite { get; init; }

		public required ImmutableArray<ChannelObject> Channels { get; init; }
		public required ImmutableArray<UserObject> Members { get; init; }
		public required int PresenceCount { get; init; }
	}
}
