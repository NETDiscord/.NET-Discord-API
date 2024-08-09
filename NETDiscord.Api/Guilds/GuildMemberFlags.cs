using System;
using System.Diagnostics.CodeAnalysis;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#guild-member-object-guild-member-flags">Discord API documentation</see>
	/// </summary>
	[SuppressMessage("Naming", "CA1711: Identifiers should not have incorrect suffix", Justification = "Consistency with the Discord API")]
	[Flags]
	public enum GuildMemberFlags
	{
		DidRejoin = 1 << 0,
		CompletedOnboarding = 1 << 1,
		BypassesVerification = 1 << 2,
		StartedOnboarding = 1 << 3,
	}
}
