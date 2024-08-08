using System.Collections.Generic;

namespace NETDiscord.Api.Users
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/user#application-role-connection-object">Discord API documentation</see>
	/// </summary>
	public class ApplicationRoleConnectionObject : ApiObject
	{
		public string? PlatformName { get; init; }
		public string? PlatformUsername { get; init; }
		public required Dictionary<string, string> Metadata { get; init; }
	}
}
