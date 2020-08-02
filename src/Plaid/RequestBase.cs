using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Going.Plaid
{
	/// <summary>
	/// Provides methods and properties for making a standard request.
	/// </summary>
	public abstract class RequestBase
	{
		/// <summary>
		/// Returns a string that represents the current object in JSON format.
		/// </summary>
		public virtual string ToJson() =>
			JsonConvert.SerializeObject(this, new JsonSerializerSettings()
			{
				DateFormatString = "yyyy-MM-dd",
				NullValueHandling = NullValueHandling.Ignore,
				Converters =
				{
					new EnumMemberEnumConverter(),
				},
#if DEBUG
				Formatting = Formatting.Indented
#else
				Formatting = Formatting.None
#endif
			});

		/// <summary>
		/// Gets or sets the secret.
		/// </summary>
		/// <value>The secret.</value>
		[JsonProperty("secret")]
		public string? Secret { get; set; }

		/// <summary>
		/// Gets or sets the client_id.
		/// </summary>
		/// <value>The client identifier.</value>
		[JsonProperty("client_id")]
		public string? ClientId { get; set; }

		/// <summary>
		/// Gets or sets the access_token.
		/// </summary>
		/// <value>The access token.</value>
		[JsonProperty("access_token")]
		public string? AccessToken { get; set; }

		/// <summary>
		/// Determines whether the AccessToken is automatically passed to the server.
		/// </summary>
		protected internal virtual bool UseAccessToken => true;
	}
}
