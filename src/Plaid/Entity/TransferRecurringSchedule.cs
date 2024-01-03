namespace Going.Plaid.Entity;

/// <summary>
/// <para>The schedule that the recurring transfer will be executed on.</para>
/// </summary>
public class TransferRecurringSchedule
{
	/// <summary>
	/// <para>The unit of the recurring interval.</para>
	/// </summary>
	[JsonPropertyName("interval_unit")]
	public Entity.TransferScheduleIntervalUnit IntervalUnit { get; set; } = default!;

	/// <summary>
	/// <para>The number of recurring <c>interval_units</c> between originations. The recurring interval (before holiday adjustment) is calculated by multiplying <c>interval_unit</c> and <c>interval_count</c>.</para>
	/// <para>For example, to schedule a recurring transfer which originates once every two weeks, set <c>interval_unit</c> = <c>week</c> and <c>interval_count</c> = 2.</para>
	/// </summary>
	[JsonPropertyName("interval_count")]
	public int IntervalCount { get; set; } = default!;

	/// <summary>
	/// <para>The day of the interval on which to schedule the transfer.</para>
	/// <para>If the <c>interval_unit</c> is <c>week</c>, <c>interval_execution_day</c> should be an integer from 1 (Monday) to 5 (Friday).</para>
	/// <para>If the <c>interval_unit</c> is <c>month</c>, <c>interval_execution_day</c> should be an integer indicating which day of the month to make the transfer on. Integers from 1 to 28 can be used to make a transfer on that day of the month. Negative integers from -1 to -5 can be used to make a transfer relative to the end of the month. To make a transfer on the last day of the month, use -1; to make the transfer on the second-to-last day, use -2, and so on.</para>
	/// <para>The transfer will be originated on the next available banking day if the designated day is a non banking day.</para>
	/// </summary>
	[JsonPropertyName("interval_execution_day")]
	public int IntervalExecutionDay { get; set; } = default!;

	/// <summary>
	/// <para>A date in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DD). The recurring transfer will begin on the first <c>interval_execution_day</c> on or after the <c>start_date</c>.</para>
	/// <para>If the first <c>interval_execution_day</c> on or after the start date is also the same day that <c>/transfer/recurring/create</c> was called, the bank *may* make the first payment on that day, but it is not guaranteed to do so.</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly StartDate { get; set; } = default!;

	/// <summary>
	/// <para>A date in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DD). The recurring transfer will end on the last <c>interval_execution_day</c> on or before the <c>end_date</c>.</para>
	/// <para>If the <c>interval_execution_day</c> between the start date and the end date (inclusive) is also the same day that <c>/transfer/recurring/create</c> was called, the bank *may* make a payment on that day, but it is not guaranteed to do so.</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly? EndDate { get; set; } = default!;

}
