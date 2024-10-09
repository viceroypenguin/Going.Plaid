namespace Going.Plaid.Entity;

/// <summary>
/// <para>A single requirement submission</para>
/// </summary>
public class RequirementSubmission
{
	/// <summary>
	/// <para>The type of requirement being submitted</para>
	/// </summary>
	[JsonPropertyName("requirement_type")]
	public string RequirementType { get; set; } = default!;

	/// <summary>
	/// <para>The value of the requirement, which can be a string or an object depending on the <c>requirement_type</c>. If it is an object, the object should be JSON marshaled into a string. See the documentation on this endpoint for more information and examples.</para>
	/// </summary>
	[JsonPropertyName("value")]
	public string Value { get; set; } = default!;

	/// <summary>
	/// <para>The <c>person_id</c> of the person the requirement submission is related to. A <c>person_id</c> is returned by <c>/transfer/platform/person/create</c>. This field should not be included for requirements that are not related to a person.</para>
	/// </summary>
	[JsonPropertyName("person_id")]
	public string? PersonId { get; set; } = default!;

}
