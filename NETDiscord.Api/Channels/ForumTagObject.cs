using System.Text.Json.Serialization;
using static System.Text.Json.Serialization.JsonIgnoreCondition;

namespace NETDiscord.Api.Channels
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/channel#forum-tag-object">Discord API documentation</see>
	/// </summary>
	public record class ForumTagObject : ApiObject
	{
		public required ulong ID { get; init; }
		public required string Name { get; init; }
		public required bool Moderated { get; init; }

		[JsonIgnore(Condition = Never)]
		public required ulong? EmojiID { get; init; }

		[JsonIgnore(Condition = Never)]
		public required string? EmojiName { get; init; }
	}
}
