using System.Text.Json.Serialization;

namespace NETDiscord.Api.Common
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/reference#locales">Discord API Documentation</see>
	/// </summary>
	public class Localizations : ApiObject
	{
		[JsonPropertyName("id")]
		public string? Indonesian { get; set; }

		[JsonPropertyName("da")]
		public string? Danish { get; set; }

		[JsonPropertyName("de")]
		public string? German { get; set; }

		[JsonPropertyName("en-GB")]
		public string? EnglishUK { get; set; }

		[JsonPropertyName("en-US")]
		public string? EnglishUS { get; set; }

		[JsonPropertyName("es-ES")]
		public string? Spanish { get; set; }

		[JsonPropertyName("es-419")]
		public string? SpanishLATAM { get; set; }

		[JsonPropertyName("fr")]
		public string? French { get; set; }

		[JsonPropertyName("hr")]
		public string? Croatian { get; set; }

		[JsonPropertyName("it")]
		public string? Italian { get; set; }

		[JsonPropertyName("lt")]
		public string? Lithuanian { get; set; }

		[JsonPropertyName("hu")]
		public string? Hungarian { get; set; }

		[JsonPropertyName("nl")]
		public string? Dutch { get; set; }

		[JsonPropertyName("no")]
		public string? Norwegian { get; set; }

		[JsonPropertyName("pl")]
		public string? Polish { get; set; }

		[JsonPropertyName("pt-BR")]
		public string? PortugueseBR { get; set; }

		[JsonPropertyName("ro")]
		public string? RomanianRO { get; set; }

		[JsonPropertyName("fi")]
		public string? Finnish { get; set; }

		[JsonPropertyName("sv-SE")]
		public string? Swedish { get; set; }

		[JsonPropertyName("vi")]
		public string? Vietnamese { get; set; }

		[JsonPropertyName("tr")]
		public string? Turkish { get; set; }

		[JsonPropertyName("cs")]
		public string? Czech { get; set; }

		[JsonPropertyName("el")]
		public string? Greek { get; set; }

		[JsonPropertyName("bg")]
		public string? Bulgarian { get; set; }

		[JsonPropertyName("ru")]
		public string? Russian { get; set; }

		[JsonPropertyName("uk")]
		public string? Ukrainian { get; set; }

		[JsonPropertyName("hi")]
		public string? Hindi { get; set; }

		[JsonPropertyName("th")]
		public string? Thai { get; set; }

		[JsonPropertyName("zh-CN")]
		public string? ChineseCN { get; set; }

		[JsonPropertyName("ja")]
		public string? Japanese { get; set; }

		[JsonPropertyName("zh-TW")]
		public string? ChineseTW { get; set; }

		[JsonPropertyName("ko")]
		public string? Korean { get; set; }
	}
}