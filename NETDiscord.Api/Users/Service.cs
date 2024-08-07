using System;

namespace NETDiscord.Api.Users
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/resources/user#connection-object-services">Discord API documentation</see>
	/// </summary>
	public enum Service
	{
		BattleNet,
		BungieNet,
		Domain,
		EBay,
		EpicGames,
		Facebook,
		GitHub,
		Instagram,
		LeagueOfLegends,
		PayPal,
		PlayStationNetwork,
		Reddit,
		RiotGames,
		Roblox,
		Spotify,
		Skype,
		Steam,
		TikTok,
		Twitch,
		Twitter,
		Xbox,
		YouTube,
	}
	internal static class ServiceExtensions
	{
		public const string BattleNet = "battlenet";
		public const string BungieNet = "bungienet";
		public const string Domain = "domain";
		public const string EBay = "ebay";
		public const string EpicGames = "epicgames";
		public const string Facebook = "facebook";
		public const string GitHub = "github";
		public const string Instagram = "instagram";
		public const string LeagueOfLegends = "leagueoflegends";
		public const string PayPal = "paypal";
		public const string PlayStationNetwork = "playstation";
		public const string Reddit = "reddit";
		public const string RiotGames = "riotgames";
		public const string Roblox = "roblox";
		public const string Spotify = "spotify";
		public const string Skype = "skype";
		public const string Steam = "steam";
		public const string TikTok = "tiktok";
		public const string Twitch = "twitch";
		public const string Twitter = "twitter";
		public const string Xbox = "xbox";
		public const string YouTube = "youtube";

		public static string AsString(this Service service)
		{
			return service switch
			{
				Service.BattleNet => BattleNet,
				Service.BungieNet => BungieNet,
				Service.Domain => Domain,
				Service.EBay => EBay,
				Service.EpicGames => EpicGames,
				Service.Facebook => Facebook,
				Service.GitHub => GitHub,
				Service.Instagram => Instagram,
				Service.LeagueOfLegends => LeagueOfLegends,
				Service.PayPal => PayPal,
				Service.PlayStationNetwork => PlayStationNetwork,
				Service.Reddit => Reddit,
				Service.RiotGames => RiotGames,
				Service.Roblox => Roblox,
				Service.Spotify => Spotify,
				Service.Skype => Skype,
				Service.Steam => Steam,
				Service.TikTok => TikTok,
				Service.Twitch => Twitch,
				Service.Twitter => Twitter,
				Service.Xbox => Xbox,
				Service.YouTube => YouTube,
				_ => throw new ArgumentOutOfRangeException(nameof(service)),
			};
		}
		public static Service ToService(this string service)
		{
			return service switch
			{
				BattleNet => Service.BattleNet,
				BungieNet => Service.BungieNet,
				Domain => Service.Domain,
				EBay => Service.EBay,
				EpicGames => Service.EpicGames,
				Facebook => Service.Facebook,
				GitHub => Service.GitHub,
				Instagram => Service.Instagram,
				LeagueOfLegends => Service.LeagueOfLegends,
				PayPal => Service.PayPal,
				PlayStationNetwork => Service.PlayStationNetwork,
				Reddit => Service.Reddit,
				RiotGames => Service.RiotGames,
				Roblox => Service.Roblox,
				Spotify => Service.Spotify,
				Skype => Service.Skype,
				Steam => Service.Steam,
				TikTok => Service.TikTok,
				Twitch => Service.Twitch,
				Twitter => Service.Twitter,
				Xbox => Service.Xbox,
				YouTube => Service.YouTube,
				_ => throw new ArgumentOutOfRangeException(nameof(service)),
			};
		}
	}
}
