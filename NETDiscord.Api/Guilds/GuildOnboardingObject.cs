using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#guild-onboarding-object">Discord API documentation</see>
	/// </summary>
	public class GuildOnboardingObject : ApiObject
	{
		public required ulong GuildID { get; init; }
		public required ImmutableArray<GuildOnboardingPromptObject> Prompts { get; init; }
		public required ImmutableArray<ulong> DefaultChannelIds { get; init; }
		public required bool Enabled { get; init; }
		public required OnboardingMode Mode { get; init; }
	}
}
