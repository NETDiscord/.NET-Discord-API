using NETDiscord.Api.Guilds;
using System.Diagnostics.CodeAnalysis;

namespace NETDiscord.Api.Users
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/user#connection-object">Discord API documentation</see>
	/// </summary>
	[SuppressMessage("Performance", "CA1819: Properties should not return arrays", Justification = "Definition is a DTO")]
	public class ConnectionObject : ApiObject
	{
		public required ulong ID { get; set; }
		public required string Name { get; set; }
		public required Service Type { get; set; }
		public bool? Revoked { get; set; }
		public Integration[]? Integrations { get; set; }
		public required bool Verified { get; set; }
		public required bool FriendSync { get; set; }
		public required bool ShowActivity { get; set; }
		public required bool TwoWayLink { get; set; }
		public required VisibilityType Visibility { get; set; }
	}
}
