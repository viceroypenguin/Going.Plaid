namespace Going.Plaid.Entity;

/// <summary>
/// <para>Data about military info in the income verification precheck.</para>
/// </summary>
public class IncomeVerificationPrecheckMilitaryInfo
{
	/// <summary>
	/// <para>Is the user currently active duty in the US military</para>
	/// </summary>
	[JsonPropertyName("is_active_duty")]
	public bool? IsActiveDuty { get; set; } = default!;

	/// <summary>
	/// <para>If the user is currently serving in the US military, the branch of the military in which they are serving</para>
	/// <para>Valid values: 'AIR FORCE', 'ARMY', 'COAST GUARD', 'MARINES', 'NAVY', 'UNKNOWN'</para>
	/// </summary>
	[JsonPropertyName("branch")]
	public string? Branch { get; set; } = default!;

}
