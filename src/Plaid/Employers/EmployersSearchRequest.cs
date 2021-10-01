namespace Going.Plaid.Employers;

/// <summary>
/// <para>EmployersSearchRequest defines the request schema for <c>/employers/search</c>.</para>
/// </summary>
public partial class EmployersSearchRequest : RequestBase
{
	/// <summary>
	/// <para>The employer name to be searched for.</para>
	/// </summary>
	[JsonPropertyName("query")]
	public string Query { get; set; } = default!;

	/// <summary>
	/// <para>The Plaid products the returned employers should support. Currently, this field must be set to <c>"deposit_switch"</c>.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<string> Products { get; set; } = default!;
}