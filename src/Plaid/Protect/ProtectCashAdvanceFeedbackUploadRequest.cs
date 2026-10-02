namespace Going.Plaid.Protect;

/// <summary>
/// <para>Defines the request schema for <c>/protect/cash_advance/feedback/upload</c></para>
/// </summary>
public partial class ProtectCashAdvanceFeedbackUploadRequest : RequestBase
{
	/// <summary>
	/// <para>The kind of feedback rows the file contains.</para>
	/// </summary>
	[JsonPropertyName("feedback_type")]
	public Entity.CashAdvanceFeedbackType FeedbackType { get; set; } = default!;

	/// <summary>
	/// <para>A CSV file of feedback rows. Maximum 20 MB.</para>
	/// </summary>
	[JsonPropertyName("file")]
	public string File { get; set; } = default!;

}
