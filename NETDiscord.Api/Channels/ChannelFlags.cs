using System;
using System.Diagnostics.CodeAnalysis;

namespace NETDiscord.Api.Channels
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/channel#channel-object-channel-flags">Discord API documentation</see>
	/// </summary>
	[SuppressMessage("Naming", "CA1711: Identifiers should not have incorrect suffix", Justification = "Consistency with the Discord API")]
	[Flags]
	public enum ChannelFlags
	{
		Pinned = 1 << 1,
		RequireTag = 1 << 4,
		HideMediaDownloadOptions = 1 << 15
	}
}
