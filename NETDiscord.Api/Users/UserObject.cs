using NETDiscord.Api.Common;
using System.Text.Json.Serialization;

namespace NETDiscord.Api.Users
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/user#user-object">Discord API documentation</see>
	/// </summary>
	public class UserObject : ApiObject
	{
		public required ulong ID { get; init; }
		public required string Username { get; init; }
		public required string Discriminator { get; init; }

		[JsonIgnore(Condition = JsonIgnoreCondition.Never)]
		public string? GlobalName { get; init; }

		[JsonIgnore(Condition = JsonIgnoreCondition.Never)]
		public string? Avatar { get; init; }

		public bool? Bot { get; init; }
		public bool? System { get; init; }
		public bool? MfaEnabled { get; init; }
		public string? Banner { get; init; }
		public int? AccentColor { get; init; }
		public Locale? Locale { get; init; }
		public bool? Verified { get; init; }
		public string? Email { get; init; }
		public UserFlags? Flags { get; init; }
		public PremiumType? PremiumType { get; init; }
		public UserFlags? PublicFlags { get; init; }
		public AvatarDecotarionDataObject? AvatarDecorationData { get; init; }
	}
}
