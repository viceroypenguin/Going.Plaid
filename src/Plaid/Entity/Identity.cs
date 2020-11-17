using System.Text.Json.Serialization;

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
		[JsonPropertyName("names")]
		public string[] Names { get; init; } = null!;

		/// <summary>
		/// A list of addresses associated with the <see cref="Item"/>'s account(s).
		/// </summary>
		[JsonPropertyName("addresses")]
		public Address[] Addresses { get; init; } = null!;

		/// <summary>
		/// A list of emails associated with the <see cref="Item"/>'s account(s).
		/// </summary>
		[JsonPropertyName("emails")]
		public Email[] Emails { get; init; } = null!;

		/// <summary>
		/// A list of phone numbers associated with the <see cref="Item"/>'s account(s).
		/// </summary>
		[JsonPropertyName("phone_numbers")]
		public Phone[] PhoneNumbers { get; init; } = null!;

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
			[JsonPropertyName("primary")]
			public bool IsPrimary { get; init; }

			/// <summary>
			/// The phone number.
			/// </summary>
			[JsonPropertyName("data")]
			public string Number { get; init; }

			/// <summary>
			/// The type of phone number (<c>"mobile"</c> for example).
			/// </summary>
			[JsonPropertyName("type")]
			public string Type { get; init; }
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
			[JsonPropertyName("data")]
			public string Address { get; init; }

			/// <summary>
			/// Gets or sets a value indicating whether this instance is the primary email.
			/// </summary>
			/// <value><c>true</c> if this instance is primary; otherwise, <c>false</c>.</value>
			[JsonPropertyName("primary")]
			public bool IsPrimary { get; init; }

			/// <summary>
			/// Gets or sets the type.
			/// </summary>
			/// <value>The type.</value>
			[JsonPropertyName("type")]
			public string Type { get; init; }
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
			[JsonPropertyName("primary")]
			public bool IsPrimary { get; init; }

			/// <summary>
			/// Gets or sets the address data (city, state, etc).
			/// </summary>
			/// <value>The information.</value>
			[JsonPropertyName("data")]
			public AddressData Data { get; init; }

			/// <summary>
			/// Represents the fields of an address.
			/// </summary>
			public struct AddressData
			{
				/// <summary>
				/// The street of the address.
				/// </summary>
				[JsonPropertyName("street")]
				public string Street { get; init; }

				/// <summary>
				/// The city of the address
				/// </summary>
				[JsonPropertyName("city")]
				public string City { get; init; }

				/// <summary>
				/// The state or region of the address
				/// </summary>
				[JsonPropertyName("region")]
				public string State { get; init; }

				/// <summary>
				/// The Postal Code/Zip Code of the address
				/// </summary>
				/// <value>The zip.</value>
				[JsonPropertyName("postal_code")]
				public string PostalCode { get; init; }

				/// <summary>
				/// The country of the address.
				/// </summary>
				[JsonPropertyName("country")]
				public string Country { get; init; }
			}
		}

		#endregion Structs
	}
}
