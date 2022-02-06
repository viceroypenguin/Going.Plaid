namespace Going.Plaid.Entity;

/// <summary>
/// <para>A transaction on the asset report</para>
/// </summary>
public record AssetReportTransaction : Entity.TransactionBase
{
	/// <summary>
	/// <para>The date on which the transaction took place, in IS0 8601 format.</para>
	/// </summary>
	[JsonPropertyName("date_transacted")]
	public string? DateTransacted { get; init; } = default!;
}