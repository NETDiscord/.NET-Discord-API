using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#guild-object-system-channel-flags">Discord API documentation</see>
	/// </summary>
	[SuppressMessage("Naming", "CA1711: Identifiers should not have incorrect suffix", Justification = "Consistency with the Discord API")]
	[Flags]
	public enum SystemChannelFlags
	{
		SuppressJoinNotifications = 1 << 0,
		SuppressPremiumSubscriptions = 1 << 1,
		SuppressGuildReminderNotifications = 1 << 2,
		SuppressJoinNotificationReplies = 1 << 3,
		SuppressRoleSubscriptionPurchaseNotifications = 1 << 4,
		SuppressRoleSubscriptionPurchaseNotificationReplies = 1 << 5
	}
}
