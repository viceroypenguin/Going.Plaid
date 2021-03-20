using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Transaction information specific to inter-bank transfers. If the transaction was not an inter-bank transfer, all fields will be <c>null</c>.
	/// </summary>
	/// <remarks>
	/// If the transaction object was returned by a <see cref="Transaction"/>s endpoint such as `/transactions/get`, the <see cref="PaymentMeta"/> key will always appear, but no data elements are guaranteed. If the <see cref="Transaction"/> object was returned by an Assets endpoint such as `/asset_report/get/` or `/asset_report/pdf/get`, this field will only appear in an Asset Report with Insights.
	/// </remarks>
	public class PaymentMeta
	{
		/// <summary>
		/// The transaction reference number supplied by the financial institution.
		/// </summary>
		[JsonPropertyName("reference_number")]
		public string? ReferenceNumber { get; set; }

		/// <summary>
		/// The ACH PPD ID for the payer.
		/// </summary>
		[JsonPropertyName("ppd_id")]
		public string? PpdId { get; set; }

		/// <summary>
		/// For transfers, the party that is receiving the transaction.
		/// </summary>
		[JsonPropertyName("payee")]
		public string? Payee { get; set; }

		/// <summary>
		/// The party initiating a wire transfer. Will be <c>null</c> if the transaction is not a wire transfer.
		/// </summary>
		[JsonPropertyName("by_order_of")]
		public string? ByOrderOf { get; set; }

		/// <summary>
		/// For transfers, the party that is paying the transaction.
		/// </summary>
		[JsonPropertyName("payer")]
		public string? Payer { get; set; }

		/// <summary>
		/// The type of transfer, e.g. 'ACH'
		/// </summary>
		[JsonPropertyName("payment_method")]
		public string? PaymentMethod { get; set; }

		/// <summary>
		/// The name of the payment processor
		/// </summary>
		[JsonPropertyName("payment_processor")]
		public string? PaymentProcessor { get; set; }

		/// <summary>
		/// The payer-supplied description of the transfer.
		/// </summary>
		[JsonPropertyName("reason")]
		public string? Reason { get; set; }
	}
}
