using System.Diagnostics.CodeAnalysis;

namespace NETDiscord.Api.Channels
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/channel#channel-object-video-quality-modes">Discord API documentation</see>
	/// </summary>
	[SuppressMessage("Design", "CA1008: Enums should have zero value", Justification = "Consistency with the Discord API")]
	public enum VideoQualityMode
	{
		Auto = 1,
		Full = 2
	}
}
