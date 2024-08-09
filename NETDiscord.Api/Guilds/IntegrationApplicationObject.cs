using NETDiscord.Api.Users;
using System.Text.Json.Serialization;
using static System.Text.Json.Serialization.JsonIgnoreCondition;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#integration-application-object">Discord API documentation</see>
	/// </summary>
	public class IntegrationApplicationObject : ApiObject
	{
		public required ulong ID { get; init; }
		public required string Name { get; init; }

		[JsonIgnore(Condition = Never)]
		public string? Icon { get; init; }
		public required string Description { get; init; }
		public UserObject? Bot { get; init; }
	}
}
