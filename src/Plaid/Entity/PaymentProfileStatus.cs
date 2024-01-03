namespace Going.Plaid.Entity;

/// <summary>
/// <para>The status of the given Payment Profile.</para>
/// </summary>
public enum PaymentProfileStatus
{
	/// <summary>
	/// <para>This Payment Profile is not ready to be used. You’ll need to call <c>/link/token/create</c> and provide the <c>payment_profile_token</c> in the <c>transfer.payment_profile_token</c> field to initiate the account linking experience.</para>
	/// </summary>
	[EnumMember(Value = "PENDING")]
	Pending,

	/// <summary>
	/// <para>This Payment Profile is ready to be used to create transfers using <c>/transfer/authorization/create</c> and <c>/transfer/create</c>.</para>
	/// </summary>
	[EnumMember(Value = "READY")]
	Ready,

	/// <summary>
	/// <para>This Payment Profile has been removed.</para>
	/// </summary>
	[EnumMember(Value = "REMOVED")]
	Removed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
