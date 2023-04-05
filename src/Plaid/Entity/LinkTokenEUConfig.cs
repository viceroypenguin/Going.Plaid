namespace Going.Plaid.Entity;

/// <summary>
/// <para>Configuration parameters for EU flows</para>
/// </summary>
public class LinkTokenEUConfig
{
	/// <summary>
	/// <para>If <c>true</c>, open Link without an initial UI. Defaults to <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("headless")]
	public bool? Headless { get; set; } = default!;
}