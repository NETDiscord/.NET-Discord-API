using NETDiscord.Api.Permissions;

namespace NETDiscord.Api.Channels
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/channel#overwrite-object">Discord API documentation</see>
	/// </summary>
	public record class OverwriteObject : ApiObject
	{
		public required ulong ID { get; init; }
		public required OverwriteType Type { get; init; }
		public required PermissionFlags Allow { get; init; }
		public required PermissionFlags Deny { get; init; }
	}
}
