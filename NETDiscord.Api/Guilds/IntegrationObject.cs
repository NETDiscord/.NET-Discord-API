using NETDiscord.Api.OAuth2;
using NETDiscord.Api.Partial;
using NETDiscord.Api.Users;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using static System.Text.Json.Serialization.JsonIgnoreCondition;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#integration-object">Discord API documentation</see>
	/// </summary>
	public record class IntegrationObject : ApiObject
	{
		public required ulong ID { get; init; }
		public required string Name { get; init; }
		public required string Type { get; init; }
		public required bool Enabled { get; init; }
		public bool? Syncing { get; init; }
		public string? RoleID { get; init; }
		public bool? EnableEmoticons { get; init; }
		public IntegrationExpireBehavior? ExpireBehavior { get; init; }
		public int? ExpireGracePeriod { get; init; }
		public UserObject? User { get; init; }
		public required IntegrationAccountObject Account { get; init; }
		public string? SyncedAt { get; init; }
		public int? SuscriberCount { get; init; }
		public bool? Revoked { get; init; }
		public IntegrationApplicationObject? Application { get; init; }

		[JsonIgnore(Condition = Never)]
		public ImmutableArray<OAuth2Scope>? Scopes { get; init; }
	}
}
