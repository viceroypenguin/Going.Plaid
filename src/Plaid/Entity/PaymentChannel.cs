using System.Runtime.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// The channel by which a payment was made
	/// </summary>
	public enum PaymentChannel
	{
		/// <summary>
		/// Default/unknown payment channel
		/// </summary>
		Unknown,

		/// <summary>
		/// Online purchase
		/// </summary>
		[EnumMember(Value = "online")]
		Online,

		/// <summary>
		/// In Store purchase
		/// </summary>
		[EnumMember(Value = "in store")]
		InStore,

		/// <summary>
		/// Other type of purchase
		/// </summary>
		[EnumMember(Value = "other")]
		Other,
	}
}
