using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using static System.Text.Json.Serialization.JsonIgnoreCondition;
using System.Threading.Tasks;
using NETDiscord.Api.Users;

namespace NETDiscord.Api.Guilds
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/guild#ban-object">Discord API documentation</see>
	/// </summary>
	public class BanObject : ApiObject
	{
		[JsonIgnore(Condition = Never)]
		public string? Reason { get; init; }

		public required UserObject User { get; init; }
	}
}
