namespace Going.Plaid.Entity;

/// <summary>
/// <para>Reason why the item is about to be disconnected.</para>
/// </summary>
public enum PendingDisconnectWebhookReason
{
	/// <summary>
	/// <para>When an institution migrates to API or a different integration, the <c>PENDING_DISCONNECT</c> webhook will be fired 7 days before the existing Item is scheduled for disconnection. It is recommended to send all Items associated with a given institution through update mode if any Item triggers a <c>PENDING_DISCONNECT</c> webhook  with a <c>reason</c> of <c>INSTITUTION_MIGRATION</c>.</para>
	/// </summary>
	[EnumMember(Value = "INSTITUTION_MIGRATION")]
	InstitutionMigration,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
