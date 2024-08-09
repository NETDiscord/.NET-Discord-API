using NETDiscord.Api.Permissions;
using NETDiscord.Api.Users;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;

namespace NETDiscord.Api.Channels
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/channel#channel-object">Discord API documentation</see>
	/// </summary>

	[SuppressMessage("Performance", "CA1819: Properties should not return arrays", Justification = "Definition is a DTO")]
	public record class ChannelObject : ApiObject
	{
		public required ulong ID { get; init; }
		public required ChannelType Type { get; init; }
		public ulong? GuildID { get; init; }
		public int? Position { get; init; }
		public ImmutableArray<OverwriteObject>? PermissionOverwrites { get; init; }
		public string? Name { get; init; }
		public string? Topic { get; init; }
		public bool? Nsfw { get; init; }
		public ulong LastMessageID { get; init; }
		public int? Bitrate { get; init; }
		public int? UserLimit { get; init; }
		public int? RateLimitPerUser { get; init; }
		public ImmutableArray<UserObject>? Recipients { get; init; }
		public string? Icon { get; init; }
		public ulong? OwnerID { get; init; }
		public ulong? ApplicationID { get; init; }
		public bool? Managed { get; init; }
		public ulong? ParentID { get; init; }
		public string? LastPinTimestamp { get; init; }
		public string? RtcRegion { get; init; }
		public VideoQualityMode? VideoQualityMode { get; init; }
		public int? MessageCount { get; init; }
		public int? MemberCount { get; init; }
		public ThreadMetadataObject? ThreadMetadata { get; init; }
		public ThreadMemberObject? Member { get; init; }
		public int? DefaultAutoArchiveDuration { get; init; }
		public PermissionFlags? Permissions { get; init; }
		public ChannelFlags? Flags { get; init; }
		public int? TotalMessageSent { get; init; }
		public ImmutableArray<ForumTagObject>? AvailableTags { get; init; }
		public ImmutableArray<ulong>? AppliedTags { get; init; }
		public DefaultReactionObject? DefaultReactionEmoji { get; init; }
		public int? DefaultThreadRateLimitPerUser { get; init; }
		public SortOrderType? DefaultSortOrder { get; init; }
		public ForumLayoutType? DefaultForumLayout { get; init; }
	}
}
