namespace NETDiscord.Api.Users
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/user#avatar-decoration-data-object">Discord API documentation</see>
	/// </summary>
	public class AvatarDecotarionData : ApiObject
	{
		public required string Asset { get; set; }
		public required string SkuID { get; set; }
	}
}
