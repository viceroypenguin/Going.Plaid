namespace Going.Plaid.Entity;

/// <summary>
/// <para>A map containing data to pass in for the Card Switch flow.</para>
/// </summary>
public class LinkTokenCreateCardSwitch
{
	/// <summary>
	/// <para>The BIN (Bank Identification Number) of the card to switch.</para>
	/// </summary>
	[JsonPropertyName("card_bin")]
	public string CardBin { get; set; } = default!;

}
