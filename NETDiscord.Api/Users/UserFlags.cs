using System;
using System.Diagnostics.CodeAnalysis;

namespace NETDiscord.Api.Users
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/user#user-object-user-flags">Discord API documentation</see>
	/// </summary>
	[SuppressMessage("Naming", "CA1711: Identifiers should not have incorrect suffix", Justification = "Consistency with the Discord API")]
	[Flags]
	public enum UserFlags
	{
		Staff = 1 << 0,
		Partner = 1 << 1,
		Hypesquad = 1 << 2,
		BugHunterLevel1 = 1 << 3,
		HypesquadOnlineHouse1 = 1 << 6,
		HypesquadOnlineHouse2 = 1 << 7,
		HypesquadOnlineHouse3 = 1 << 8,
		PremiumEarlySupporter = 1 << 9,
		TeamPseudoUser = 1 << 10,
		BugHunterLevel2 = 1 << 14,
		VerifiedBot = 1 << 16,
		VerifiedDeveloper = 1 << 17,
		CertifiedModerator = 1 << 18,
		BotHttpInteractions = 1 << 19,
		ActiveDeveloper = 1 << 22
	}
}
