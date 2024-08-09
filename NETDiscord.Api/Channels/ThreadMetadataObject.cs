namespace NETDiscord.Api.Channels
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/channel#thread-metadata-object">Discord API documentation</see>
	/// </summary>
	public record class ThreadMetadataObject : ApiObject
	{
		public required bool Archived { get; init; }
		public required int AutoArchiveDuration { get; init; }
		public required string ArchiveTimestamp { get; init; }
		public required bool Locked { get; init; }
		public bool? Invitable { get; init; }
		public string? CreateTimestamp { get; init; }
	}
}
