using System;

namespace NETDiscord.Api.Common
{
	/// <summary>
	/// <see href="https://discord.com/developers/docs/reference#locales">Discord API Documentation</see>
	/// </summary>
	public enum Locale
	{
		Indonesian,
		Danish,
		German,
		EnglishUK,
		EnglishUS,
		Spanish,
		SpanishLATAM,
		French,
		Croatian,
		Italian,
		Lithuanian,
		Hungarian,
		Dutch,
		Norwegian,
		Polish,
		PortugueseBR,
		RomanianRO,
		Finnish,
		Swedish,
		Vietnamese,
		Turkish,
		Czech,
		Greek,
		Bulgarian,
		Russian,
		Ukrainian,
		Hindi,
		Thai,
		ChineseCN,
		Japanese,
		ChineseTW,
		Korean,
	}
	internal static class LocaleExtensions
	{
		public static string AsString(this Locale locale)
		{
			return locale switch
			{
				Locale.Indonesian => "id",
				Locale.Danish => "da",
				Locale.German => "de",
				Locale.EnglishUK => "en-GB",
				Locale.EnglishUS => "en-US",
				Locale.Spanish => "es-ES",
				Locale.SpanishLATAM => "es-419",
				Locale.French => "fr",
				Locale.Croatian => "hr",
				Locale.Italian => "it",
				Locale.Lithuanian => "lt",
				Locale.Hungarian => "hu",
				Locale.Dutch => "nl",
				Locale.Norwegian => "no",
				Locale.Polish => "pl",
				Locale.PortugueseBR => "pt-BR",
				Locale.RomanianRO => "ro",
				Locale.Finnish => "fi",
				Locale.Swedish => "sv-SE",
				Locale.Vietnamese => "vi",
				Locale.Turkish => "tr",
				Locale.Czech => "cs",
				Locale.Greek => "el",
				Locale.Bulgarian => "bg",
				Locale.Russian => "ru",
				Locale.Ukrainian => "uk",
				Locale.Hindi => "hi",
				Locale.Thai => "th",
				Locale.ChineseCN => "zh-CN",
				Locale.Japanese => "ja",
				Locale.ChineseTW => "zh-TW",
				Locale.Korean => "ko",
				_ => throw new ArgumentOutOfRangeException(nameof(locale))
			};
		}
		public static Locale ToLocale(this string locale)
		{
			return locale switch
			{
				"id" => Locale.Indonesian,
				"da" => Locale.Danish,
				"de" => Locale.German,
				"en-GB" => Locale.EnglishUK,
				"en-US" => Locale.EnglishUS,
				"es-ES" => Locale.Spanish,
				"es-419" => Locale.SpanishLATAM,
				"fr" => Locale.French,
				"hr" => Locale.Croatian,
				"it" => Locale.Italian,
				"lt" => Locale.Lithuanian,
				"hu" => Locale.Hungarian,
				"nl" => Locale.Dutch,
				"no" => Locale.Norwegian,
				"pl" => Locale.Polish,
				"pt-BR" => Locale.PortugueseBR,
				"ro" => Locale.RomanianRO,
				"fi" => Locale.Finnish,
				"sv-SE" => Locale.Swedish,
				"vi" => Locale.Vietnamese,
				"tr" => Locale.Turkish,
				"cs" => Locale.Czech,
				"el" => Locale.Greek,
				"bg" => Locale.Bulgarian,
				"ru" => Locale.Russian,
				"uk" => Locale.Ukrainian,
				"hi" => Locale.Hindi,
				"th" => Locale.Thai,
				"zh-CN" => Locale.ChineseCN,
				"ja" => Locale.Japanese,
				"zh-TW" => Locale.ChineseTW,
				"ko" => Locale.Korean,
				_ => throw new ArgumentOutOfRangeException(nameof(locale))
			};
		}
	}
}