using NETDiscord.Api.Permissions;
using NETDiscord.Api.Users;
using System.Diagnostics.CodeAnalysis;

namespace NETDiscord.Api.Channels
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/channel#channel-object">Discord API documentation</see>
	/// </summary>

	[SuppressMessage("Performance", "CA1819: Properties should not return arrays", Justification = "Definition is a DTO")]
	public class ChannelObject : ApiObject
	{
		public required ulong ID { get; set; }
		public required ChannelType Type { get; set; }
		public ulong? GuildID { get; set; }
		public int? Position { get; set; }
		public OverwriteObject[]? PermissionOverwrites { get; set; }
		public string? Name { get; set; }
		public string? Topic { get; set; }
		public bool? Nsfw { get; set; }
		public ulong LastMessageID { get; set; }
		public int? Bitrate { get; set; }
		public int? UserLimit { get; set; }
		public int? RateLimitPerUser { get; set; }
		public UserObject[]? Recipients { get; set; }
		public string? Icon { get; set; }
		public ulong? OwnerID { get; set; }
		public ulong? ApplicationID { get; set; }
		public bool? Managed { get; set; }
		public ulong? ParentID { get; set; }
		public string? LastPinTimestamp { get; set; }
		public string? RtcRegion { get; set; }
		public VideoQualityMode? VideoQualityMode { get; set; }
		public int? MessageCount { get; set; }
		public int? MemberCount { get; set; }
		public ThreadMetadataObject? ThreadMetadata { get; set; }
		public ThreadMemberObject? Member { get; set; }
		public int? DefaultAutoArchiveDuration { get; set; }
		public PermissionFlags? Permissions { get; set; }
		public ChannelFlags? Flags { get; set; }
		public int? TotalMessageSent { get; set; }
		public ForumTagObject[]? AvailableTags { get; set; }
		public ulong[]? AppliedTags { get; set; }
		public DefaultReactionObject? DefaultReactionEmoji { get; set; }
		public int? DefaultThreadRateLimitPerUser { get; set; }
		public SortOrderType? DefaultSortOrder { get; set; }
		public ForumLayoutType? DefaultForumLayout { get; set; }
	}
}
