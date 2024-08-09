using System.Collections.Immutable;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#guild-onboarding-object-onboarding-prompt-structure">Discord API documentation</see>
	/// </summary>
	public record class GuildOnboardingPromptObject : ApiObject
	{
		public required ulong ID { get; init; }
		public required PromptType Type { get; init; }
		public required ImmutableArray<PromptOptionObject> Options { get; init; }
		public required string Title { get; init; }
		public required bool SingleSelect { get; init; }
		public required bool Required { get; init; }
		public required bool InOnboarding { get; init; }
	}
}
