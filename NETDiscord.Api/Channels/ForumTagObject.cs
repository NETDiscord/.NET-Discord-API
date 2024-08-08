using System.Text.Json.Serialization;
using static System.Text.Json.Serialization.JsonIgnoreCondition;

namespace NETDiscord.Api.Channels
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/channel#forum-tag-object">Discord API documentation</see>
	/// </summary>
	public class ForumTagObject : ApiObject
	{
		public required ulong ID { get; set; }
		public required string Name { get; set; }
		public required bool Moderated { get; set; }

		[JsonIgnore(Condition = Never)]
		public required ulong? EmojiID { get; set; }

		[JsonIgnore(Condition = Never)]
		public required string? EmojiName { get; set; }
	}
}
