namespace NETDiscord.Api.Users
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/user#avatar-decoration-data-object">Discord API documentation</see>
	/// </summary>
	public record class AvatarDecotarionDataObject : ApiObject
	{
		public required string Asset { get; init; }
		public required string SkuID { get; init; }
	}
}
