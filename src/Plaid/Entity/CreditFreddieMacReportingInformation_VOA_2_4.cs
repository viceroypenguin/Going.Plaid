namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about an report identifier and a report name.</para>
/// </summary>
public record CreditFreddieMacReportingInformation_VOA_2_4
{
	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("ReportDateTime")]
	public string? Reportdatetime { get; init; } = default!;

	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac. The value can only be "ReportID"</para>
	/// </summary>
	[JsonPropertyName("ReportIdentifierType")]
	public string? Reportidentifiertype { get; init; } = default!;

	/// <summary>
	/// <para>Documentation not found in the MISMO model viewer and not provided by Freddie Mac.</para>
	/// </summary>
	[JsonPropertyName("ReportingInformationIdentifier")]
	public string Reportinginformationidentifier { get; init; } = default!;
}