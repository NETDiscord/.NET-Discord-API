namespace NETDiscord.Api.Channels
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/voice#voice-region-object">Discord API documentation</see>
	/// </summary>
	public record class VoiceRegionObject : ApiObject
	{
		public required string ID { get; init; }
		public required string Name { get; init; }
		public required bool Optimal { get; init; }
		public required bool Deprecated { get; init; }
		public required bool Custom { get; init; }
	}
}
