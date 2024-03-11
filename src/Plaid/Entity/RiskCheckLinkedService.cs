namespace Going.Plaid.Entity;

/// <summary>
/// <para>An enum indicating the type of a linked service. Note that <c>adult_sites</c> refers' to explicit video content, and includes a number of related services.</para>
/// </summary>
public enum RiskCheckLinkedService
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "aboutme")]
	Aboutme,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "adobe")]
	Adobe,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "adult_sites")]
	AdultSites,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "airbnb")]
	Airbnb,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "altbalaji")]
	Altbalaji,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "amazon")]
	Amazon,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "apple")]
	Apple,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "archiveorg")]
	Archiveorg,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "atlassian")]
	Atlassian,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "bitmoji")]
	Bitmoji,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "bodybuilding")]
	Bodybuilding,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "booking")]
	Booking,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "bukalapak")]
	Bukalapak,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "codecademy")]
	Codecademy,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "deliveroo")]
	Deliveroo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "diigo")]
	Diigo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "discord")]
	Discord,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "disneyplus")]
	Disneyplus,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "duolingo")]
	Duolingo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ebay")]
	Ebay,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "envato")]
	Envato,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "eventbrite")]
	Eventbrite,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "evernote")]
	Evernote,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "facebook")]
	Facebook,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "firefox")]
	Firefox,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "flickr")]
	Flickr,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "flipkart")]
	Flipkart,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "foursquare")]
	Foursquare,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "freelancer")]
	Freelancer,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "gaana")]
	Gaana,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "giphy")]
	Giphy,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "github")]
	Github,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "google")]
	Google,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "gravatar")]
	Gravatar,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "hubspot")]
	Hubspot,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "imgur")]
	Imgur,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "instagram")]
	Instagram,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "jdid")]
	Jdid,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "kakao")]
	Kakao,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "kommo")]
	Kommo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "komoot")]
	Komoot,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "lastfm")]
	Lastfm,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "lazada")]
	Lazada,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "line")]
	Line,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "linkedin")]
	Linkedin,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "mailru")]
	Mailru,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "microsoft")]
	Microsoft,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "myspace")]
	Myspace,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "netflix")]
	Netflix,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "nike")]
	Nike,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ok")]
	Ok,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "patreon")]
	Patreon,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "pinterest")]
	Pinterest,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "plurk")]
	Plurk,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "quora")]
	Quora,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "qzone")]
	Qzone,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "rambler")]
	Rambler,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "rappi")]
	Rappi,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "replit")]
	Replit,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "samsung")]
	Samsung,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "seoclerks")]
	Seoclerks,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "shopclues")]
	Shopclues,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "skype")]
	Skype,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "snapchat")]
	Snapchat,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "snapdeal")]
	Snapdeal,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "soundcloud")]
	Soundcloud,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "spotify")]
	Spotify,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "starz")]
	Starz,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "strava")]
	Strava,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "taringa")]
	Taringa,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "telegram")]
	Telegram,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "tiki")]
	Tiki,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "tokopedia")]
	Tokopedia,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "treehouse")]
	Treehouse,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "tumblr")]
	Tumblr,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "twitter")]
	Twitter,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "venmo")]
	Venmo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "viber")]
	Viber,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "vimeo")]
	Vimeo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "vivino")]
	Vivino,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "vkontakte")]
	Vkontakte,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "wattpad")]
	Wattpad,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "weibo")]
	Weibo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "whatsapp")]
	Whatsapp,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "wordpress")]
	Wordpress,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "xing")]
	Xing,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "yahoo")]
	Yahoo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "yandex")]
	Yandex,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "zalo")]
	Zalo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "zoho")]
	Zoho,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
