using System;
using System.Text.Json.Serialization;

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
		[JsonPropertyName("client_user_id")]
		public string ClientUserId { get; init; } = null!;

		/// <summary>
		/// The user's full legal name. This is an optional field used in the returning user experience to associate Items to the user.
		/// </summary>
		/// <example>Stuart Turner</example>
		[JsonPropertyName("legal_name")]
		public string? LegalName { get; set; }

		/// <summary>
		/// The user's phone number in E.164 format. This field is optional, but required to enable the <a href="https://plaid.com/docs/link/returning-user">returning user</a> experience.
		/// </summary>
		/// <example>+14155552671</example>
		[JsonPropertyName("phone_number")]
		public string? PhoneNumber { get; set; }

		/// <summary>
		/// <para>
		/// The date and time the phone number was verified. This field is optional, but required to enable any returning user experience.
		/// </para>
		/// <para>
		/// Only pass a verification time for a phone number that you have verified. If you have performed verification but don’t have the time, you may supply a signal value of the start of the UNIX epoch.
		/// </para>
		/// </summary>
		/// <remarks>If parsed from JSON, this value will be in UTC. Conversion to local time may be necessary.</remarks>
		[JsonPropertyName("phone_number_verified_time")]
		public DateTimeOffset? PhoneNumberVerifiedTime { get; set; }

		/// <summary>
		/// The user's email address. This field is optional, but required to enable the pre-authenticated returning user flow.
		/// </summary>
		/// <example>batman@gothamcity.gov</example>
		[JsonPropertyName("email_address")]
		public string? EmailAddress { get; set; }

		/// <summary>
		/// <para>
		/// The date and time the email address was verified. This field is optional, but required to enable any returning user experience.
		/// </para>
		/// <para>
		/// Only pass a verification time for an email address that you have verified. If you have performed verification but don’t have the time, you may supply a signal value of the start of the UNIX epoch.
		/// </para>
		/// </summary>
		/// <remarks>If parsed from JSON, this value will be in UTC. Conversion to local time may be necessary.</remarks>
		[JsonPropertyName("email_address_verified_time")]
		public DateTimeOffset? EmailAddressVerifiedTime { get; set; }

		/// <summary>
		/// To be provided in the format "ddd-dd-dddd". This field is optional and will support not-yet-implemented functionality for new products.
		/// </summary>
		/// <example>183-67-5309</example>
		[JsonPropertyName("ssn")]
		public string? Ssn { get; set; }

		/// <summary>
		/// This field is optional and will support not-yet-implemented functionality for new products.
		/// </summary>
		/// <example>2021-04-22</example>
		[JsonPropertyName("date_of_birth")]
		public DateTime? DateOfBirth { get; set; }
	}
}
