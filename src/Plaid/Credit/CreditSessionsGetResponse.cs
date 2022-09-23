namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditSessionsGetResponse defines the response schema for <c>/credit/sessions/get</c></para>
/// </summary>
public record CreditSessionsGetResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("sessions")]
	public IReadOnlyList<Entity.CreditSession> Sessions { get; init; } = default!;
}