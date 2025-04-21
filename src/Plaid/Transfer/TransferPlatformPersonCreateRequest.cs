namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/platform/person/create</c></para>
/// </summary>
public partial class TransferPlatformPersonCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The client ID of the originator</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string OriginatorClientId { get; set; } = default!;

	/// <summary>
	/// <para>The person's legal name</para>
	/// </summary>
	[JsonPropertyName("name")]
	public Entity.TransferPlatformPersonName? Name { get; set; } = default!;

	/// <summary>
	/// <para>A valid email address. Must not have leading or trailing spaces.</para>
	/// </summary>
	[JsonPropertyName("email_address")]
	public string? EmailAddress { get; set; } = default!;

	/// <summary>
	/// <para>A valid phone number in E.164 format.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public string? PhoneNumber { get; set; } = default!;

	/// <summary>
	/// <para>Home address of a person</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.TransferPlatformPersonAddress? Address { get; set; } = default!;

	/// <summary>
	/// <para>ID number of the person</para>
	/// </summary>
	[JsonPropertyName("id_number")]
	public Entity.TransferPlatformPersonIDNumber? IdNumber { get; set; } = default!;

	/// <summary>
	/// <para>The date of birth of the person. Formatted as YYYY-MM-DD.</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public DateOnly? DateOfBirth { get; set; } = default!;

	/// <summary>
	/// <para>The relationship between this person and the originator they are related to.</para>
	/// </summary>
	[JsonPropertyName("relationship_to_originator")]
	public string? RelationshipToOriginator { get; set; } = default!;

	/// <summary>
	/// <para>The percentage of ownership this person has in the onboarding business. Only applicable to beneficial owners with 25% or more ownership.</para>
	/// </summary>
	[JsonPropertyName("ownership_percentage")]
	public int? OwnershipPercentage { get; set; } = default!;

}
