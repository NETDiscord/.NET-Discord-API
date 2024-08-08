namespace NETDiscord.Api.Channels
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/channel#followed-channel-object">Discord API documentation</see>
	/// </summary>
	public class FollowedChannelObject
	{
		public required ulong ChannelID { get; set; }
		public required ulong WebhookID { get; set; }
	}
}
