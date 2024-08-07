using System.Collections.Generic;

namespace NETDiscord.Api.Users
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/user#application-role-connection-object-application-role-connection-structure">Discord API documentation</see>
	/// </summary>
	public class ApplicationRoleConnection : ApiObject
	{
		public string? PlatformName { get; set; }
		public string? PlatformUsername { get; set; }
		public required Dictionary<string, string> Metadata { get; init; }
	}
}
