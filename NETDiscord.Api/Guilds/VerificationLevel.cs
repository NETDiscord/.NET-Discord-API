using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#guild-object-verification-level">Discord API documentation</see>
	/// </summary>
	public enum VerificationLevel
	{
		None = 0,
		Low = 1,
		Medium = 2,
		High = 3,
		VeryHigh = 4
	}
}
