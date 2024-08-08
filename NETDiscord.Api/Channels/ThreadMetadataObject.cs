namespace NETDiscord.Api.Channels
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/channel#thread-metadata-object">Discord API documentation</see>
	/// </summary>
	public class ThreadMetadataObject : ApiObject
	{
		public required bool Archived { get; set; }
		public required int AutoArchiveDuration { get; set; }
		public required string ArchiveTimestamp { get; set; }
		public required bool Locked { get; set; }
		public bool? Invitable { get; set; }
		public string? CreateTimestamp { get; set; }
	}
}
