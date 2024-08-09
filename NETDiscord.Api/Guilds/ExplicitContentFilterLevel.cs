using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#guild-object-explicit-content-filter-level">Discord API documentation</see>
	/// </summary>
	public enum ExplicitContentFilterLevel
	{
		Disabled = 0,
		MembersWithoutRoles = 1,
		AllMembers = 2
	}
}
