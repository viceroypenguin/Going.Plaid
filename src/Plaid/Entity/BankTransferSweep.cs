namespace Going.Plaid.Entity;

/// <summary>
/// <para>BankTransferSweep describes a sweep transfer.</para>
/// </summary>
public record BankTransferSweep
{
	/// <summary>
	/// <para>Identifier of the sweep.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public int Id { get; init; } = default!;

	/// <summary>
	/// <para>Identifier of the sweep transfer.</para>
	/// </summary>
	[JsonPropertyName("transfer_id")]
	public string? TransferId { get; init; } = default!;

	/// <summary>
	/// <para>The datetime when the sweep occurred, in RFC 3339 format.</para>
	/// </summary>
	[JsonPropertyName("created_at")]
	public DateTimeOffset CreatedAt { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the sweep.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; init; } = default!;

	/// <summary>
	/// <para>The currency of the sweep, e.g. "USD".</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The account where the funds are swept to.</para>
	/// </summary>
	[JsonPropertyName("sweep_account")]
	public Entity.BankTransferSweepAccount SweepAccount { get; init; } = default!;
}