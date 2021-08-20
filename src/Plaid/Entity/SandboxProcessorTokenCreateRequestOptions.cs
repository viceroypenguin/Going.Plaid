namespace Going.Plaid.Entity;

/// <summary>
/// <para>An optional set of options to be used when configuring the Item. If specified, must not be <c>null</c>.</para>
/// </summary>
public class SandboxProcessorTokenCreateRequestOptions
{
	/// <summary>
	/// <para>Test username to use for the creation of the Sandbox Item. Default value is <c>user_good</c>.</para>
	/// </summary>
	[JsonPropertyName("override_username")]
	public string? OverrideUsername { get; set; } = default!;

	/// <summary>
	/// <para>Test password to use for the creation of the Sandbox Item. Default value is <c>pass_good</c>.</para>
	/// </summary>
	[JsonPropertyName("override_password")]
	public string? OverridePassword { get; set; } = default!;
}