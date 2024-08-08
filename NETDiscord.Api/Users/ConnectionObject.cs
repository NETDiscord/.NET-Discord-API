using NETDiscord.Api.Guilds;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;

namespace NETDiscord.Api.Users
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/user#connection-object">Discord API documentation</see>
	/// </summary>
	[SuppressMessage("Performance", "CA1819: Properties should not return arrays", Justification = "Definition is a DTO")]
	public class ConnectionObject : ApiObject
	{
		public required ulong ID { get; init; }
		public required string Name { get; init; }
		public required Service Type { get; init; }
		public bool? Revoked { get; set; }
		public ImmutableArray<Integration>? Integrations { get; init; }
		public required bool Verified { get; init; }
		public required bool FriendSync { get; init; }
		public required bool ShowActivity { get; init; }
		public required bool TwoWayLink { get; init; }
		public required VisibilityType Visibility { get; init; }
	}
}
