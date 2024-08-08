using NETDiscord.Api.Common;
using System.Text.Json.Serialization;

namespace NETDiscord.Api.Users
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/user#user-object">Discord API documentation</see>
	/// </summary>
	public class UserObject : ApiObject
	{
		public required ulong ID { get; set; }
		public required string Username { get; set; }
		public required string Discriminator { get; set; }

		[JsonIgnore(Condition = JsonIgnoreCondition.Never)]
		public string? GlobalName { get; set; }

		[JsonIgnore(Condition = JsonIgnoreCondition.Never)]
		public string? Avatar { get; set; }

		public bool? Bot { get; set; }
		public bool? System { get; set; }
		public bool? MfaEnabled { get; set; }
		public string? Banner { get; set; }
		public int? AccentColor { get; set; }
		public Locale? Locale { get; set; }
		public bool? Verified { get; set; }
		public string? Email { get; set; }
		public UserFlags? Flags { get; set; }
		public PremiumType? PremiumType { get; set; }
		public UserFlags? PublicFlags { get; set; }
		public AvatarDecotarionDataObject? AvatarDecorationData { get; set; }
	}
}
