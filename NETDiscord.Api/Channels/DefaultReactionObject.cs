using System.Text.Json.Serialization;
using static System.Text.Json.Serialization.JsonIgnoreCondition;

namespace NETDiscord.Api.Channels
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/channel#default-reaction-object">Discord API documentation</see>
	/// </summary>
	public class DefaultReactionObject : ApiObject
	{
		[JsonIgnore(Condition = Never)]
		public required ulong? EmojiID { get; set; }

		[JsonIgnore(Condition = Never)]
		public required string? EmojiName { get; set; }
	}
}
