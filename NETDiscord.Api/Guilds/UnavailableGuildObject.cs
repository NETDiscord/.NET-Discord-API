namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#unavailable-guild-object">Discord API documentation</see>
	/// </summary>
	public record class UnavailableGuildObject : ApiObject
	{
		public required ulong ID { get; init; }
		public required bool Unavailable { get; init; }
	}
}
