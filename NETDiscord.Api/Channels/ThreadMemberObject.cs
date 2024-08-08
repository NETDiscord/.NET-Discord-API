using NETDiscord.Api.Guilds;

namespace NETDiscord.Api.Channels
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/channel#thread-member-object">Discord API documentation</see>
	/// </summary>
	public class ThreadMemberObject : ApiObject
	{
		public ulong? ID { get; set; }
		public ulong? UserID { get; set; }
		public required string JoinTimestamp { get; set; }
		public required int Flags { get; set; }
		public GuildMember? Member { get; set; }
	}
}
