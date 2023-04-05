namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional object to filter <c>/processor/balance/get</c> results.</para>
/// </summary>
public class ProcessorBalanceGetRequestOptions
{
	/// <summary>
	/// <para>Timestamp in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (<c>YYYY-MM-DDTHH:mm:ssZ</c>) indicating the oldest acceptable balance when making a request to <c>/accounts/balance/get</c>.</para>
	/// <para>If the balance that is pulled for <c>ins_128026</c> (Capital One) is older than the given timestamp, an <c>INVALID_REQUEST</c> error with the code of <c>LAST_UPDATED_DATETIME_OUT_OF_RANGE</c> will be returned with the most recent timestamp for the requested account contained in the response.</para>
	/// <para>This field is only used when the institution is <c>ins_128026</c> (Capital One), in which case a value must be provided or an <c>INVALID_REQUEST</c> error with the code of <c>INVALID_FIELD</c> will be returned. For all other institutions, this field is ignored.</para>
	/// </summary>
	[JsonPropertyName("min_last_updated_datetime")]
	public DateTimeOffset? MinLastUpdatedDatetime { get; set; } = default!;
}