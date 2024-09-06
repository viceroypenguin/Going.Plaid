namespace Going.Plaid.Entity;

/// <summary>
/// <para>Configuration parameters for the Investments Auth Product</para>
/// </summary>
public class LinkTokenInvestmentsAuth
{
	/// <summary>
	/// <para>If <c>true</c>, show institutions that use the manual entry fallback flow.</para>
	/// </summary>
	[JsonPropertyName("manual_entry_enabled")]
	public bool? ManualEntryEnabled { get; set; } = default!;

	/// <summary>
	/// <para>If <c>true</c>, show institutions that use the masked number match fallback flow.</para>
	/// </summary>
	[JsonPropertyName("masked_number_match_enabled")]
	public bool? MaskedNumberMatchEnabled { get; set; } = default!;

	/// <summary>
	/// <para>If <c>true</c>, show institutions that use the stated account number fallback flow.</para>
	/// </summary>
	[JsonPropertyName("stated_account_number_enabled")]
	public bool? StatedAccountNumberEnabled { get; set; } = default!;

}
