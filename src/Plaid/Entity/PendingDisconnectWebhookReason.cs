namespace Going.Plaid.Entity;

/// <summary>
/// <para>Reason why the item is about to be disconnected.</para>
/// </summary>
public enum PendingDisconnectWebhookReason
{
	/// <summary>
	/// <para>The institution is moving to API or to a different integration. For example, this can occur when an institution moves from a non-OAuth integration to an OAuth integration.</para>
	/// </summary>
	[EnumMember(Value = "INSTITUTION_MIGRATION")]
	InstitutionMigration,

	/// <summary>
	/// <para>The consent on an Item associated with a US or CA institution is about to expire.</para>
	/// </summary>
	[EnumMember(Value = "INSTITUTION_TOKEN_EXPIRATION")]
	InstitutionTokenExpiration,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
