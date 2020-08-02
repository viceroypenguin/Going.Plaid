using Newtonsoft.Json;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents an account holder information.
	/// </summary>
	public class Identity
	{
		/// <summary>
		/// A list of names associated with the <see cref="Item"/>'s account(s).
		/// </summary>
		[JsonProperty("names")]
		public string[] Names { get; set; } = null!;

		/// <summary>
		/// A list of addresses associated with the <see cref="Item"/>'s account(s).
		/// </summary>
		[JsonProperty("addresses")]
		public Address[] Addresses { get; set; } = null!;

		/// <summary>
		/// A list of emails associated with the <see cref="Item"/>'s account(s).
		/// </summary>
		[JsonProperty("emails")]
		public Email[] Emails { get; set; } = null!;

		/// <summary>
		/// A list of phone numbers associated with the <see cref="Item"/>'s account(s).
		/// </summary>
		[JsonProperty("phone_numbers")]
		public Phone[] PhoneNumbers { get; set; } = null!;

		#region Structs

		/// <summary>
		/// Represents a <see cref="Identity"/> phone number.
		/// </summary>
		public struct Phone
		{
			/// <summary>
			/// A value indicating whether this instance is the primary phone number.
			/// </summary>
			/// <value><c>true</c> if this instance is primary; otherwise, <c>false</c>.</value>
			[JsonProperty("primary")]
			public bool IsPrimary { get; set; }

			/// <summary>
			/// The phone number.
			/// </summary>
			[JsonProperty("data")]
			public string Number { get; set; }

			/// <summary>
			/// The type of phone number (<c>"mobile"</c> for example).
			/// </summary>
			[JsonProperty("type")]
			public string Type { get; set; }
		}

		/// <summary>
		/// Represents and <see cref="Identity"/> email.
		/// </summary>
		public struct Email
		{
			/// <summary>
			/// Gets or sets the address.
			/// </summary>
			/// <value>The address.</value>
			[JsonProperty("data")]
			public string Address { get; set; }

			/// <summary>
			/// Gets or sets a value indicating whether this instance is the primary email.
			/// </summary>
			/// <value><c>true</c> if this instance is primary; otherwise, <c>false</c>.</value>
			[JsonProperty("primary")]
			public bool IsPrimary { get; set; }

			/// <summary>
			/// Gets or sets the type.
			/// </summary>
			/// <value>The type.</value>
			[JsonProperty("type")]
			public string Type { get; set; }
		}

		/// <summary>
		/// Represents an <see cref="Identity"/> address.
		/// </summary>
		public struct Address
		{
			/// <summary>
			/// Gets or sets a value indicating whether this instance is the primary address.
			/// </summary>
			/// <value><c>true</c> if this instance is primary; otherwise, <c>false</c>.</value>
			[JsonProperty("primary")]
			public bool IsPrimary { get; set; }

			/// <summary>
			/// Gets or sets the address data (city, state, etc).
			/// </summary>
			/// <value>The information.</value>
			[JsonProperty("data")]
			public AddressData Data { get; set; }

			/// <summary>
			/// Represents the fields of an address.
			/// </summary>
			public struct AddressData
			{
				/// <summary>
				/// The street of the address.
				/// </summary>
				[JsonProperty("street")]
				public string Street { get; set; }

				/// <summary>
				/// The city of the address
				/// </summary>
				[JsonProperty("city")]
				public string City { get; set; }

				/// <summary>
				/// The state or region of the address
				/// </summary>
				[JsonProperty("region")]
				public string State { get; set; }

				/// <summary>
				/// The Postal Code/Zip Code of the address
				/// </summary>
				/// <value>The zip.</value>
				[JsonProperty("postal_code")]
				public string PostalCode { get; set; }

				/// <summary>
				/// The country of the address.
				/// </summary>
				[JsonProperty("country")]
				public string Country { get; set; }
			}
		}

		#endregion Structs
	}
}
