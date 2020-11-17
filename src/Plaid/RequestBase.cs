using System.Text.Json.Serialization;

namespace Going.Plaid
{
	/// <summary>
	/// Provides methods and properties for making a standard request.
	/// </summary>
	public abstract class RequestBase
	{
		/// <summary>
		/// Gets or sets the secret.
		/// </summary>
		/// <value>The secret.</value>
		[JsonPropertyName("secret")]
		public string? Secret { get; set; }

		/// <summary>
		/// Gets or sets the client_id.
		/// </summary>
		/// <value>The client identifier.</value>
		[JsonPropertyName("client_id")]
		public string? ClientId { get; set; }

		/// <summary>
		/// Gets or sets the access_token.
		/// </summary>
		/// <value>The access token.</value>
		[JsonPropertyName("access_token")]
		public string? AccessToken { get; set; }

		/// <summary>
		/// Updates the credential values if they have
		/// not already been provided.
		/// </summary>
		/// <param name="secret"></param>
		/// <param name="clientId"></param>
		/// <param name="accessToken"></param>
		public virtual void SetCredentials(
			string? secret,
			string? clientId,
			string? accessToken)
		{
			if (string.IsNullOrWhiteSpace(Secret)) Secret = secret;
			if (string.IsNullOrWhiteSpace(ClientId)) ClientId = clientId;
			if (string.IsNullOrWhiteSpace(AccessToken)) AccessToken = accessToken;
		}
	}
}
