namespace Going.Plaid.Entity;

/// <summary>
/// <para>Additional information for the <c>kyc_check</c> (Data Source Verification) step. This field will be <c>null</c> unless <c>steps.kyc_check</c> has reached a terminal state of either <c>success</c> or <c>failed</c>.</para>
/// </summary>
public record KYCCheckDetails
{
	/// <summary>
	/// <para>The outcome status for the associated Identity Verification attempt's <c>kyc_check</c> step. This field will always have the same value as <c>steps.kyc_check</c>.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public string Status { get; init; } = default!;

	/// <summary>
	/// <para>Result summary object specifying how the <c>address</c> field matched.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.KYCCheckAddressSummary Address { get; init; } = default!;

	/// <summary>
	/// <para>Result summary object specifying how the <c>name</c> field matched.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public Entity.KYCCheckNameSummary Name { get; init; } = default!;

	/// <summary>
	/// <para>Result summary object specifying how the <c>date_of_birth</c> field matched.</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public Entity.KYCCheckDateOfBirthSummary DateOfBirth { get; init; } = default!;

	/// <summary>
	/// <para>Result summary object specifying how the <c>id_number</c> field matched.</para>
	/// </summary>
	[JsonPropertyName("id_number")]
	public Entity.KYCCheckIDNumberSummary IdNumber { get; init; } = default!;

	/// <summary>
	/// <para>Result summary object specifying how the <c>phone</c> field matched.</para>
	/// </summary>
	[JsonPropertyName("phone_number")]
	public Entity.KYCCheckPhoneSummary PhoneNumber { get; init; } = default!;

}
