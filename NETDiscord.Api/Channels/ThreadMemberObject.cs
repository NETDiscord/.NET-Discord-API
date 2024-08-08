using NETDiscord.Api.Guilds;

namespace NETDiscord.Api.Channels
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/channel#thread-member-object">Discord API documentation</see>
	/// </summary>
	public class ThreadMemberObject : ApiObject
	{
		public ulong? ID { get; init; }
		public ulong? UserID { get; init; }
		public required string JoinTimestamp { get; init; }
		public required int Flags { get; init; }
		public GuildMember? Member { get; init; }
	}
}
