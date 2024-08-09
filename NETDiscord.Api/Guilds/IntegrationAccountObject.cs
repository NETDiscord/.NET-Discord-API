namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#integration-account-object">Discord API documentation</see>
	/// </summary>
	public record class IntegrationAccountObject : ApiObject
	{
		public required ulong ID { get; init; }
		public required string Name { get; init; }
	}
}
