namespace NETDiscord.Api.Channels
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/voice#voice-region-object">Discord API documentation</see>
	/// </summary>
	public class VoiceRegion : ApiObject
	{
		public required string ID { get; set; }
		public required string Name { get; set; }
		public required bool Optimal { get; set; }
		public required bool Deprecated { get; set; }
		public required bool Custom { get; set; }
	}
}
