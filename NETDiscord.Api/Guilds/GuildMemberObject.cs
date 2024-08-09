using NETDiscord.Api.Permissions;
using NETDiscord.Api.Users;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#guild-member-object">Discord API documentation</see>
	/// </summary>
	[SuppressMessage("Performance", "CA1819: Properties should not return arrays", Justification = "Definition is a DTO")]
	public class GuildMemberObject : ApiObject
	{
		public UserObject? User { get; init; }
		public string? Nick { get; init; }
		public string? Avatar { get; init; }
		public required ImmutableArray<ulong> Roles { get; init; }
		public required string JoinedAt { get; init; }
		public string? PremiumSince { get; init; }
		public required bool Deaf { get; init; }
		public required bool Mute { get; init; }
		public required GuildMemberFlags Flags { get; init; }
		public bool? Pending { get; init; }
		public required PermissionFlags Permissions { get; init; }
		public string? CommunicationDisabledUntil { get; init; }
		public AvatarDecotarionDataObject? AvatarDecotarionData { get; init; }
	}
}
