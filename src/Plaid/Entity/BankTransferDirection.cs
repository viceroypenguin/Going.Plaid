namespace Going.Plaid.Entity;

/// <summary>
/// <para>Indicates the direction of the transfer: <c>outbound</c> for API-initiated transfers, or <c>inbound</c> for payments received by the FBO account.</para>
/// </summary>
public enum BankTransferDirection
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "outbound")]
	Outbound,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "inbound")]
	Inbound,
}