using Going.Plaid.Entity;

namespace Going.Plaid.Liabilities
{
	public record GetLiabilitiesResponse : ResponseBase
	{
		/// <summary>
		/// Gets or sets the bank accounts.
		/// </summary>
		/// <value>The accounts.</value>
		[JsonProperty("accounts")]
		public Entity.Account[] Accounts { get; set; }

		/// <summary>
		/// Gets or sets the item.
		/// </summary>
		/// <value>The item.</value>
		[JsonProperty("item")]
		public Entity.Item Item { get; set; }

		[JsonProperty("liabilities")]
		public Entity.Liabilities Liabilities { get; set; }
	}
}
