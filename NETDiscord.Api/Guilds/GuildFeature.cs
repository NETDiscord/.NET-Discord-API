using System;

namespace NETDiscord.Api.Guilds
{
	public enum GuildFeature
	{
		AnimatedBanner,
		AnimatedIcon,
		ApplicationCommandPermissionsV2,
		AutoModeration,
		Banner,
		Community,
		CreatorMonetizableProvisional,
		CreatorStorePage,
		DeveloperSupportServer,
		Discoverable,
		Featurable,
		InvitesDisabled,
		InviteSplash,
		MemberVerificationGateEnabled,
		MoreStickers,
		News,
		Partnered,
		PreviewEnabled,
		RaidAlertsDisabled,
		RoleIcons,
		RoleSubscriptionsAvailableForPurchase,
		RoleSubscriptionsEnabled,
		TicketedEventsEnabled,
		VanityUrl,
		Verified,
		VipRegions,
		WelcomeScreenEnabled
	}
	internal static class GuildFeaturesExtension
	{
		public const string AnimatedBanner = "ANIMATED_BANNER";
		public const string AnimatedIcon = "ANIMATED_ICON";
		public const string ApplicationCommandPermissionsV2 = "APPLICATION_COMMAND_PERMISSIONS_V2";
		public const string AutoModeration = "AUTO_MODERATION";
		public const string Banner = "BANNER";
		public const string Community = "COMMUNITY";
		public const string CreatorMonetizableProvisional = "CREATOR_MONETIZABLE_PROVISIONAL";
		public const string CreatorStorePage = "CREATOR_STORE_PAGE";
		public const string DeveloperSupportServer = "DEVELOPER_SUPPORT_SERVER";
		public const string Discoverable = "DISCOVERABLE";
		public const string Featurable = "FEATURABLE";
		public const string InvitesDisabled = "INVITES_DISABLED";
		public const string InviteSplash = "INVITE_SPLASH";
		public const string MemberVerificationGateEnabled = "MEMBER_VERIFICATION_GATE_ENABLED";
		public const string MoreStickers = "MORE_STICKERS";
		public const string News = "NEWS";
		public const string Partnered = "PARTNERED";
		public const string PreviewEnabled = "PREVIEW_ENABLED";
		public const string RaidAlertsDisabled = "RAID_ALERTS_DISABLED";
		public const string RoleIcons = "ROLE_ICONS";
		public const string RoleSubscriptionsAvailableForPurchase = "ROLE_SUBSCRIPTIONS_AVAILABLE_FOR_PURCHASE";
		public const string RoleSubscriptionsEnabled = "ROLE_SUBSCRIPTIONS_ENABLED";
		public const string TicketedEventsEnabled = "TICKETED_EVENTS_ENABLED";
		public const string VanityUrl = "VANITY_URL";
		public const string Verified = "VERIFIED";
		public const string VipRegions = "VIP_REGIONS";
		public const string WelcomeScreenEnabled = "WELCOME_SCREEN_ENABLED";

		public static string AsString(this GuildFeature feature)
		{
			return feature switch
			{
				GuildFeature.AnimatedBanner => AnimatedBanner,
				GuildFeature.AnimatedIcon => AnimatedIcon,
				GuildFeature.ApplicationCommandPermissionsV2 => ApplicationCommandPermissionsV2,
				GuildFeature.AutoModeration => AutoModeration,
				GuildFeature.Banner => Banner,
				GuildFeature.Community => Community,
				GuildFeature.CreatorMonetizableProvisional => CreatorMonetizableProvisional,
				GuildFeature.CreatorStorePage => CreatorStorePage,
				GuildFeature.DeveloperSupportServer => DeveloperSupportServer,
				GuildFeature.Discoverable => Discoverable,
				GuildFeature.Featurable => Featurable,
				GuildFeature.InvitesDisabled => InvitesDisabled,
				GuildFeature.InviteSplash => InviteSplash,
				GuildFeature.MemberVerificationGateEnabled => MemberVerificationGateEnabled,
				GuildFeature.MoreStickers => MoreStickers,
				GuildFeature.News => News,
				GuildFeature.Partnered => Partnered,
				GuildFeature.PreviewEnabled => PreviewEnabled,
				GuildFeature.RaidAlertsDisabled => RaidAlertsDisabled,
				GuildFeature.RoleIcons => RoleIcons,
				GuildFeature.RoleSubscriptionsAvailableForPurchase => RoleSubscriptionsAvailableForPurchase,
				GuildFeature.RoleSubscriptionsEnabled => RoleSubscriptionsEnabled,
				GuildFeature.VanityUrl => VanityUrl,
				GuildFeature.Verified => Verified,
				GuildFeature.VipRegions => VipRegions,
				GuildFeature.WelcomeScreenEnabled => WelcomeScreenEnabled,
				_ => throw new ArgumentOutOfRangeException(nameof(feature))
			};
		}
		public static GuildFeature ToGuildFeature(this string feature)
		{
			return feature switch
			{
				AnimatedBanner => GuildFeature.AnimatedBanner,
				AnimatedIcon => GuildFeature.AnimatedIcon,
				ApplicationCommandPermissionsV2 => GuildFeature.ApplicationCommandPermissionsV2,
				AutoModeration => GuildFeature.AutoModeration,
				Banner => GuildFeature.Banner,
				Community => GuildFeature.Community,
				CreatorMonetizableProvisional => GuildFeature.CreatorMonetizableProvisional,
				CreatorStorePage => GuildFeature.CreatorStorePage,
				DeveloperSupportServer => GuildFeature.DeveloperSupportServer,
				Discoverable => GuildFeature.Discoverable,
				Featurable => GuildFeature.Featurable,
				InvitesDisabled => GuildFeature.InvitesDisabled,
				InviteSplash => GuildFeature.InviteSplash,
				MemberVerificationGateEnabled => GuildFeature.MemberVerificationGateEnabled,
				MoreStickers => GuildFeature.MoreStickers,
				News => GuildFeature.News,
				Partnered => GuildFeature.Partnered,
				PreviewEnabled => GuildFeature.PreviewEnabled,
				RaidAlertsDisabled => GuildFeature.RaidAlertsDisabled,
				RoleIcons => GuildFeature.RoleIcons,
				RoleSubscriptionsAvailableForPurchase => GuildFeature.RoleSubscriptionsAvailableForPurchase,
				RoleSubscriptionsEnabled => GuildFeature.RoleSubscriptionsEnabled,
				VanityUrl => GuildFeature.VanityUrl,
				Verified => GuildFeature.Verified,
				VipRegions => GuildFeature.VipRegions,
				WelcomeScreenEnabled => GuildFeature.WelcomeScreenEnabled,
				_ => throw new ArgumentOutOfRangeException(nameof(feature))
			};
		}
	}
}
