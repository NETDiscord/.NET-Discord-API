using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using static System.Text.Json.Serialization.JsonIgnoreCondition;
using System.Collections.Immutable;
using NETDiscord.Api.Emoji;
using NETDiscord.Api.Sticker;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#guild-preview-object">Discord API documentation</see>
	/// </summary>
	public class GuildPreviewObject : ApiObject
	{
		public required ulong ID { get; init; }
		public required string Name { get; init; }

		[JsonIgnore(Condition = Never)]
		public string? Icon { get; init; }

		[JsonIgnore(Condition = Never)]
		public string? Splash { get; init; }

		[JsonIgnore(Condition = Never)]
		public string? DiscoverySplash { get; init; }

		public ImmutableArray<EmojiObject> Emojis { get; init; }
		public ImmutableArray<GuildFeature> Features { get; init; }
		public required int ApproximateMemberCount { get; init; }
		public required int ApproximatePresenceCount { get; init; }

		[JsonIgnore(Condition = Never)]
		public string? Description { get; init; }

		public ImmutableArray<StickerObject> Stickers { get; init; }
	}
}
