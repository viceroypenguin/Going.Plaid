namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para><c>/employers/search</c> allows you the ability to search Plaid’s database of known employers, for use with Deposit Switch. You can use this endpoint to look up a user's employer in order to confirm that they are supported. Users with non-supported employers can then be routed out of the Deposit Switch flow.</para>
	/// <para>The data in the employer database is currently limited. As the Deposit Switch and Income products progress through their respective beta periods, more employers are being regularly added. Because the employer database is frequently updated, we recommend that you do not cache or store data from this endpoint for more than a day.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/employers/#employerssearch" /></remarks>
	public Task<Employers.EmployersSearchResponse> EmployersSearchAsync(Employers.EmployersSearchRequest request) =>
		PostAsync("/employers/search", request)
			.ParseResponseAsync<Employers.EmployersSearchResponse>();

}
