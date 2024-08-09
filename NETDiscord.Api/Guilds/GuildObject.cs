using NETDiscord.Api.Channels;
using NETDiscord.Api.Common;
using NETDiscord.Api.Emoji;
using NETDiscord.Api.Permissions;
using NETDiscord.Api.Sticker;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using static System.Text.Json.Serialization.JsonIgnoreCondition;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#guild-object">Discord API documentation</see>
	/// </summary>
	[SuppressMessage("Design", "CA1056: URI properties should not be strings", Justification = "Property doesn't represent a URI")]
	public record class GuildObject : ApiObject
	{
		public required ulong ID { get; init; }
		public required string Name { get; init; }

		[JsonIgnore(Condition = Never)]
		public string? Icon { get; init; }

		public string? IconHash { get; init; }

		[JsonIgnore(Condition = Never)]
		public string? Splash { get; init; }

		[JsonIgnore(Condition = Never)]
		public string? DiscoverySplash { get; init; }

		public bool? Owner { get; init; }
		public required ulong OwnerID { get; init; }
		public PermissionFlags? Permissions { get; init; }
		public string? VoiceRegion { get; init; }

		[JsonIgnore(Condition = Never)]
		public ulong? AfkChannelID { get; init; }

		public required int AfkTimeout { get; init; }
		public bool? WidgetEnabled { get; init; }
		public ulong? WidgetChannelID { get; init; }
		public required VerificationLevel VerificationLevel { get; init; }
		public required DefaultMessageNotificationLevel DefaultMessageNotifications { get; init; }
		public required ExplicitContentFilterLevel ExplicitContentFilter { get; init; }
		public required ImmutableArray<RoleObject> Roles { get; init; }
		public required ImmutableArray<EmojiObject> Emojis { get; init; }
		public required ImmutableArray<GuildFeature> Features { get; init; }
		public required MfaLevel MfaLevel { get; init; }

		[JsonIgnore(Condition = Never)]
		public ulong? ApplicationID { get; init; }

		[JsonIgnore(Condition = Never)]
		public ulong? SystemChannelID { get; init; }

		public SystemChannelFlags SystemChannelFlags { get; init; }

		[JsonIgnore(Condition = Never)]
		public ulong? RulesChannelID { get; init; }

		public int? MaxPresences { get; init; }
		public int? MaxMembers { get; init; }
		public string? VanityUrlCode { get; init; }

		[JsonIgnore(Condition = Never)]
		public string? Description { get; init; }

		[JsonIgnore(Condition = Never)]
		public string? Banner { get; init; }

		public PremiumTier PremiumTier { get; init; }
		public int? PremiumSubscriptionCount { get; init; }
		public Locale PreferredLocale { get; init; }

		[JsonIgnore(Condition = Never)]
		public ulong? PublicUpdatesChannelID { get; init; }

		public int? MaxVideoChannelUsers { get; init; }
		public int? MaxStageVideoChannelUsers { get; init; }
		public int? ApproximateMemberCount { get; init; }
		public int? ApproximatePresenceCount { get; init; }
		public WelcomeScreenObject? WelcomeScreen { get; init; }
		public required GuildNsfwLevel NsfwLevel { get; init; }
		public ImmutableArray<StickerObject>? Stickers { get; init; }
		public required bool PremiumProgressBarEnabled { get; init; }

		[JsonIgnore(Condition = Never)]
		public ulong? SafetyAlertsChannelID { get; init; }
	}
}
