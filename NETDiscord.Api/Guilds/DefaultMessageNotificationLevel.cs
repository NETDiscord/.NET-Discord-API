using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#guild-object-default-message-notification-level">Discord API documentation</see>
	/// </summary>
	public enum DefaultMessageNotificationLevel
	{
		AllMessages = 0,
		OnlyMentions = 1
	}
}
