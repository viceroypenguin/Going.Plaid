namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxPaymentSimulateResponse defines the response schema for <c>/sandbox/payment/simulate</c></para>
/// </summary>
public record SandboxPaymentSimulateResponse : ResponseBase
{
	/// <summary>
	/// <para>The status of the payment.</para>
	/// </summary>
	[JsonPropertyName("old_status")]
	public Entity.PaymentInitiationPaymentStatus OldStatus { get; init; } = default!;

	/// <summary>
	/// <para>The status of the payment.</para>
	/// </summary>
	[JsonPropertyName("new_status")]
	public Entity.PaymentInitiationPaymentStatus NewStatus { get; init; } = default!;

}
