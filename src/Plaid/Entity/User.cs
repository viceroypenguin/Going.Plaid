using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents a user being identified during a call to generate a <c>link_token</c>.
	/// </summary>
	public class User
	{
		/// <summary>
		/// Plaid requires that the endpoint used to create a <c>link_token</c> only be available to users that are logged in to your app. 
		/// Once your user is logged in, pass an identifier that uniquely identifies your user into the <see cref="ClientUserId"/> field. 
		/// The value of this id should not be personally identifiable information like an email or phone number.
		///
		/// Using <see cref="ClientUserId"/> will allow for easier debugging in the Dashboard logs.
		/// You will be able to search for Link logs that belong to one of your end users.
		/// </summary>
		[JsonProperty("client_user_id")]
		public string ClientUserId { get; init; } = null!;
	}
}
