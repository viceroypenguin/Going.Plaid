namespace Going.Plaid.Entity;

/// <summary>
/// <para>An enum indicating the type of a linked service.</para>
/// </summary>
public enum RiskCheckLinkedService
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "apple")]
	Apple,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ebay")]
	Ebay,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "facebook")]
	Facebook,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "flickr")]
	Flickr,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "foursquare")]
	Foursquare,

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
	[EnumMember(Value = "instagram")]
	Instagram,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "lastfm")]
	Lastfm,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "linkedin")]
	Linkedin,

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
	[EnumMember(Value = "pinterest")]
	Pinterest,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "skype")]
	Skype,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "spotify")]
	Spotify,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "telegram")]
	Telegram,

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
	[EnumMember(Value = "yahoo")]
	Yahoo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "airbnb")]
	Airbnb,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "amazon")]
	Amazon,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "booking")]
	Booking,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "discord")]
	Discord,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "kakao")]
	Kakao,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ok")]
	Ok,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "qzone")]
	Qzone,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "line")]
	Line,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "snapchat")]
	Snapchat,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "zalo")]
	Zalo,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}