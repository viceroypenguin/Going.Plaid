namespace Going.Plaid.DepositSwitch;

/// <summary>
/// <para>DepositSwitchGetResponse defines the response schema for <c>/deposit_switch/get</c></para>
/// </summary>
public record DepositSwitchGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The ID of the deposit switch.</para>
	/// </summary>
	[JsonPropertyName("deposit_switch_id")]
	public string DepositSwitchId { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the bank account the direct deposit was switched to.</para>
	/// </summary>
	[JsonPropertyName("target_account_id")]
	public string? TargetAccountId { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the Item the direct deposit was switched to.</para>
	/// </summary>
	[JsonPropertyName("target_item_id")]
	public string? TargetItemId { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("state")]
	public Entity.DepositSwitchGetResponseStateEnum State { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("switch_method")]
	public Entity.DepositSwitchGetResponseSwitchMethodEnum? SwitchMethod { get; init; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, user’s direct deposit goes to multiple banks. When false, user’s direct deposit only goes to the target account. Always <c>null</c> if the deposit switch has not been completed.</para>
	/// </summary>
	[JsonPropertyName("account_has_multiple_allocations")]
	public bool? AccountHasMultipleAllocations { get; init; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, the target account is allocated the remainder of direct deposit after all other allocations have been deducted. When <c>false</c>, user’s direct deposit is allocated as a percent or amount. Always <c>null</c> if the deposit switch has not been completed.</para>
	/// </summary>
	[JsonPropertyName("is_allocated_remainder")]
	public bool? IsAllocatedRemainder { get; init; } = default!;

	/// <summary>
	/// <para>The percentage of direct deposit allocated to the target account. Always <c>null</c> if the target account is not allocated a percentage or if the deposit switch has not been completed or if <c>is_allocated_remainder</c> is true.</para>
	/// </summary>
	[JsonPropertyName("percent_allocated")]
	public decimal? PercentAllocated { get; init; } = default!;

	/// <summary>
	/// <para>The dollar amount of direct deposit allocated to the target account. Always <c>null</c> if the target account is not allocated an amount or if the deposit switch has not been completed.</para>
	/// </summary>
	[JsonPropertyName("amount_allocated")]
	public decimal? AmountAllocated { get; init; } = default!;

	/// <summary>
	/// <para>The name of the employer selected by the user. If the user did not select an employer, the value returned is <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("employer_name")]
	public string? EmployerName { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the employer selected by the user. If the user did not select an employer, the value returned is <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("employer_id")]
	public string? EmployerId { get; init; } = default!;

	/// <summary>
	/// <para>The name of the institution selected by the user. If the user did not select an institution, the value returned is <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("institution_name")]
	public string? InstitutionName { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the institution selected by the user. If the user did not select an institution, the value returned is <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>ISO8601 date the deposit switch was created.</para>
	/// </summary>
	[JsonPropertyName("date_created")]
	public DateOnly DateCreated { get; init; } = default!;

	/// <summary>
	/// <para>ISO8601 date the deposit switch was completed. Always <c>null</c> if the deposit switch has not been completed.</para>
	/// </summary>
	[JsonPropertyName("date_completed")]
	public DateOnly? DateCompleted { get; init; } = default!;
}