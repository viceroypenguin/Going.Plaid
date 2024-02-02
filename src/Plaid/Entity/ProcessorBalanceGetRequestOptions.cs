namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to filter <c>/processor/balance/get</c> results.</para>
/// </summary>
public class ProcessorBalanceGetRequestOptions
{
	/// <summary>
	/// <para>Timestamp in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (<c>YYYY-MM-DDTHH:mm:ssZ</c>) indicating the oldest acceptable balance when making a request to <c>/accounts/balance/get</c>.</para>
	/// <para>This field is only necessary when the institution is <c>ins_128026</c> (Capital One), *and* the account type is a non-depository account (such as a credit card) in which case a value must be provided or an <c>INVALID_REQUEST</c> error with the code of <c>INVALID_FIELD</c> will be returned. For all other institutions, as well as for depository accounts at Capital One (including all checking and savings accounts) this field is ignored.</para>
	/// <para>If this field is not ignored, and no acceptable balance is available, an <c>INVALID_RESULT</c> error with the code <c>LAST_UPDATED_DATETIME_OUT_OF_RANGE</c> will be returned.</para>
	/// </summary>
	[JsonPropertyName("min_last_updated_datetime")]
	public DateTimeOffset? MinLastUpdatedDatetime { get; set; } = default!;

}
