namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional set of options to be used when configuring the Item. If specified, must not be <c>null</c>.</para>
/// </summary>
public class SandboxPublicTokenCreateRequestOptions
{
	/// <summary>
	/// <para>Specify a webhook to associate with the new Item.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;

	/// <summary>
	/// <para>Test username to use for the creation of the Sandbox Item. Default value is <c>user_good</c>. You can also use a custom test user — either set this to the username of a custom user configured in the Dashboard, or set it to <c>user_custom</c> and pass the JSON-stringified custom user configuration object as <c>override_password</c> to define one entirely via API. See <a href="https://plaid.com/docs/sandbox/user-custom">Sandbox Custom Users</a> for more details.</para>
	/// </summary>
	[JsonPropertyName("override_username")]
	public string? OverrideUsername { get; set; } = default!;

	/// <summary>
	/// <para>Test password to use for the creation of the Sandbox Item. Default value is <c>pass_good</c>. You can also use a custom test user — reference one configured in the Dashboard via <c>override_username</c>, or set <c>override_username</c> to <c>user_custom</c> and pass the JSON-stringified custom user configuration object as this field to define one entirely via API. See <a href="https://plaid.com/docs/sandbox/user-custom">Sandbox Custom Users</a> for more details.</para>
	/// </summary>
	[JsonPropertyName("override_password")]
	public string? OverridePassword { get; set; } = default!;

	/// <summary>
	/// <para>An optional set of parameters corresponding to transactions options.</para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public Entity.SandboxPublicTokenCreateRequestOptionsTransactions? Transactions { get; set; } = default!;

	/// <summary>
	/// <para>An optional set of parameters corresponding to statements options.</para>
	/// </summary>
	[JsonPropertyName("statements")]
	public Entity.SandboxPublicTokenCreateRequestOptionsStatements? Statements { get; set; } = default!;

	/// <summary>
	/// <para>A set of parameters for income verification options. This field is required if <c>income_verification</c> is included in the <c>initial_products</c> array.</para>
	/// </summary>
	[JsonPropertyName("income_verification")]
	public Entity.SandboxPublicTokenCreateRequestOptionsIncomeVerification? IncomeVerification { get; set; } = default!;

}
