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
		public string[] Names { get; set; } = null!;

		/// <summary>
		/// A list of addresses associated with the <see cref="Item"/>'s account(s).
		/// </summary>
		public Address[] Addresses { get; set; } = null!;

		/// <summary>
		/// A list of emails associated with the <see cref="Item"/>'s account(s).
		/// </summary>
		public Email[] Emails { get; set; } = null!;

		/// <summary>
		/// A list of phone numbers associated with the <see cref="Item"/>'s account(s).
		/// </summary>
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
			public bool IsPrimary { get; set; }

			/// <summary>
			/// The phone number.
			/// </summary>
			public string Number { get; set; }

			/// <summary>
			/// The type of phone number (<c>"mobile"</c> for example).
			/// </summary>
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
			public string Address { get; set; }

			/// <summary>
			/// Gets or sets a value indicating whether this instance is the primary email.
			/// </summary>
			/// <value><c>true</c> if this instance is primary; otherwise, <c>false</c>.</value>
			public bool IsPrimary { get; set; }

			/// <summary>
			/// Gets or sets the type.
			/// </summary>
			/// <value>The type.</value>
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
			public bool IsPrimary { get; set; }

			/// <summary>
			/// Gets or sets the account names.
			/// </summary>
			/// <value>The accounts.</value>
			public string[] Accounts { get; set; }

			/// <summary>
			/// Gets or sets the address data (city, state, etc).
			/// </summary>
			/// <value>The information.</value>
			public Data Info { get; set; }

			/// <summary>
			/// Represents the fields of an address.
			/// </summary>
			public struct Data
			{
				/// <summary>
				/// Gets or sets the street.
				/// </summary>
				/// <value>The street.</value>
				public string Street { get; set; }

				/// <summary>
				/// Gets or sets the city.
				/// </summary>
				/// <value>The city.</value>
				public string City { get; set; }

				/// <summary>
				/// Gets or sets the state.
				/// </summary>
				/// <value>The state.</value>
				public string State { get; set; }

				/// <summary>
				/// Gets or sets the zip.
				/// </summary>
				/// <value>The zip.</value>
				public string Zip { get; set; }
			}
		}

		#endregion Structs
	}
}
