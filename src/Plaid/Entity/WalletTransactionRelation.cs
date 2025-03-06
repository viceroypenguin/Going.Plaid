namespace Going.Plaid.Entity;

/// <summary>
/// <para>Transactions are related when they have a logical connection.</para>
/// <para>For example, a <c>PAYOUT</c> transaction can be returned by the sender, creating a <c>RETURN</c> transaction. Each <c>PAYOUT</c> transaction can have at most one corresponding <c>RETURN</c> transaction in case of reversal.</para>
/// <para>These relationships are bi-directional, meaning that both entities have references to each other. For instance, when a transaction of type RETURN occurs, it is linked to the original transaction being returned. Likewise, the original transaction has a reference back to the RETURN transaction that represents the return.</para>
/// <para>This field is only populated for transactions of type <c>RETURN</c>, <c>FUNDS_SWEEP</c>, <c>REFUND</c> and <c>PAYOUT</c>.</para>
/// <para>The relationship between a <c>PIS_PAY_IN</c> payment and its corresponding <c>REFUND</c> transactions is only available through <c>refund_ids</c> property in the payment object. See<a href="https://plaid.com/docs/api/products/payment-initiation/#payment_initiation-payment-get-response-refund-ids"><c>/payment_initiation/payment/get</c></a>.</para>
/// </summary>
public record WalletTransactionRelation
{
	/// <summary>
	/// <para>The ID of the related transaction.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string? Id { get; init; } = default!;

	/// <summary>
	/// <para>The type of the transaction.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.WalletTransactionRelationTypeEnum? Type { get; init; } = default!;

}
