using NETDiscord.Api.Permissions;

namespace NETDiscord.Api.Channels
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/channel#overwrite-object">Discord API documentation</see>
	/// </summary>
	public class OverwriteObject : ApiObject
	{
		public required ulong ID { get; set; }
		public required OverwriteType Type { get; set; }
		public required PermissionFlags Allow { get; set; }
		public required PermissionFlags Deny { get; set; }
	}
}
