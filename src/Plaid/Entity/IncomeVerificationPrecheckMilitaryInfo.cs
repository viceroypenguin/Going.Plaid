namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public class IncomeVerificationPrecheckMilitaryInfo
{
	/// <summary>
	/// <para>Is the user currently active duty in the US military</para>
	/// </summary>
	[JsonPropertyName("is_active_duty")]
	public bool? IsActiveDuty { get; set; } = default!;

	/// <summary>
	/// <para>If the user is currently serving in the US military, the branch of the military they are serving in</para>
	/// </summary>
	[JsonPropertyName("branch")]
	public Entity.IncomeVerificationPrecheckMilitaryInfoBranchEnum? Branch { get; set; } = default!;
}