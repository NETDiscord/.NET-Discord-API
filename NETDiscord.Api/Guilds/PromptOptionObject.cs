using NETDiscord.Api.Emoji;
using System.Collections.Immutable;
using System.Text.Json.Serialization;
using static System.Text.Json.Serialization.JsonIgnoreCondition;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#guild-onboarding-object-prompt-option-structure">Discord API documentation</see>
	/// </summary>
	public class PromptOptionObject : ApiObject
	{
		public required ulong ID { get; init; }
		public required ImmutableArray<ulong> ChannelIds { get; init; }
		public required ImmutableArray<ulong> RoleIds { get; init; }
		public EmojiObject? Emoji { get; init; }
		public ulong? EmojiID { get; init; }
		public string? EmojiName { get; init; }
		public bool? EmojiAnimated { get; init; }
		public required string Title { get; init; }

		[JsonIgnore(Condition = Never)]
		public string? Description { get; init; }
	}
}
