using Newtonsoft.Json;

namespace Going.Plaid.Income
{
	/// <summary>
	/// Represents a response from plaid's '<c>/income/get</c>' endpoint. The Income endpoint allows you to retrieve information pertaining to a Item’s income. In addition to the annual income, detailed information will be provided for each contributing income stream (or job). Details on each of these fields can be found below.
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public class GetIncomeResponse : ResponseBase
	{
		/// <summary>
		/// The item about which information is requested.
		/// </summary>
		public Entity.Item Item { get; set; } = null!;

		/// <summary>
		/// User income data.
		/// </summary>
		[JsonProperty("income")]
		public Entity.Income Income { get; set; } = null!;
	}
}
