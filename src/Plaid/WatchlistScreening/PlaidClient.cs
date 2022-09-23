namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Create a new entity watchlist screening to check your customer against watchlists defined in the associated entity watchlist program. If your associated program has ongoing screening enabled, this is the profile information that will be used to monitor your customer over time.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentitycreate" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningEntityCreateResponse> WatchlistScreeningEntityCreateAsync(WatchlistScreening.WatchlistScreeningEntityCreateRequest request) =>
		PostAsync("/watchlist_screening/entity/create", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningEntityCreateResponse>();

	/// <summary>
	/// <para>Retrieve an entity watchlist screening.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentityget" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningEntityGetResponse> WatchlistScreeningEntityGetAsync(WatchlistScreening.WatchlistScreeningEntityGetRequest request) =>
		PostAsync("/watchlist_screening/entity/get", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningEntityGetResponse>();

	/// <summary>
	/// <para>List all changes to the entity watchlist screening in reverse-chronological order. If the watchlist screening has not been edited, no history will be returned.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentityhistorylist" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningEntityHistoryListResponse> WatchlistScreeningEntityHistoryListAsync(WatchlistScreening.WatchlistScreeningEntityHistoryListRequest request) =>
		PostAsync("/watchlist_screening/entity/history/list", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningEntityHistoryListResponse>();

	/// <summary>
	/// <para>List all hits for the entity watchlist screening.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentityhitlist" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningEntityHitListResponse> WatchlistScreeningEntityHitListAsync(WatchlistScreening.WatchlistScreeningEntityHitListRequest request) =>
		PostAsync("/watchlist_screening/entity/hit/list", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningEntityHitListResponse>();

	/// <summary>
	/// <para>List all entity screenings.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentitylist" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningEntityListResponse> WatchlistScreeningEntityListAsync(WatchlistScreening.WatchlistScreeningEntityListRequest request) =>
		PostAsync("/watchlist_screening/entity/list", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningEntityListResponse>();

	/// <summary>
	/// <para>Get an entity watchlist screening program</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentityprogramget" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningEntityProgramGetResponse> WatchlistScreeningEntityProgramGetAsync(WatchlistScreening.WatchlistScreeningEntityProgramGetRequest request) =>
		PostAsync("/watchlist_screening/entity/program/get", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningEntityProgramGetResponse>();

	/// <summary>
	/// <para>List all entity watchlist screening programs</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentityprogramlist" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningEntityProgramListResponse> WatchlistScreeningEntityProgramListAsync(WatchlistScreening.WatchlistScreeningEntityProgramListRequest request) =>
		PostAsync("/watchlist_screening/entity/program/list", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningEntityProgramListResponse>();

	/// <summary>
	/// <para>Create a review for an entity watchlist screening. Reviews are compliance reports created by users in your organization regarding the relevance of potential hits found by Plaid.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentityreviewcreate" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningEntityReviewCreateResponse> WatchlistScreeningEntityReviewCreateAsync(WatchlistScreening.WatchlistScreeningEntityReviewCreateRequest request) =>
		PostAsync("/watchlist_screening/entity/review/create", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningEntityReviewCreateResponse>();

	/// <summary>
	/// <para>List all reviews for a particular entity watchlist screening. Reviews are compliance reports created by users in your organization regarding the relevance of potential hits found by Plaid.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentityreviewlist" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningEntityReviewListResponse> WatchlistScreeningEntityReviewListAsync(WatchlistScreening.WatchlistScreeningEntityReviewListRequest request) =>
		PostAsync("/watchlist_screening/entity/review/list", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningEntityReviewListResponse>();

	/// <summary>
	/// <para>Update an entity watchlist screening.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentityupdate" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningEntityUpdateResponse> WatchlistScreeningEntityUpdateAsync(WatchlistScreening.WatchlistScreeningEntityUpdateRequest request) =>
		PostAsync("/watchlist_screening/entity/update", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningEntityUpdateResponse>();

	/// <summary>
	/// <para>Create a new Watchlist Screening to check your customer against watchlists defined in the associated Watchlist Program. If your associated program has ongoing screening enabled, this is the profile information that will be used to monitor your customer over time.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividualcreate" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningIndividualCreateResponse> WatchlistScreeningIndividualCreateAsync(WatchlistScreening.WatchlistScreeningIndividualCreateRequest request) =>
		PostAsync("/watchlist_screening/individual/create", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningIndividualCreateResponse>();

	/// <summary>
	/// <para>Retrieve a previously created individual watchlist screening</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividualget" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningIndividualGetResponse> WatchlistScreeningIndividualGetAsync(WatchlistScreening.WatchlistScreeningIndividualGetRequest request) =>
		PostAsync("/watchlist_screening/individual/get", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningIndividualGetResponse>();

	/// <summary>
	/// <para>List all changes to the individual watchlist screening in reverse-chronological order. If the watchlist screening has not been edited, no history will be returned.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividualhistorylist" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningIndividualHistoryListResponse> WatchlistScreeningIndividualHistoryListAsync(WatchlistScreening.WatchlistScreeningIndividualHistoryListRequest request) =>
		PostAsync("/watchlist_screening/individual/history/list", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningIndividualHistoryListResponse>();

	/// <summary>
	/// <para>List all hits found by Plaid for a particular individual watchlist screening.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividualhitlist" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningIndividualHitListResponse> WatchlistScreeningIndividualHitListAsync(WatchlistScreening.WatchlistScreeningIndividualHitListRequest request) =>
		PostAsync("/watchlist_screening/individual/hit/list", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningIndividualHitListResponse>();

	/// <summary>
	/// <para>List previously created watchlist screenings for individuals</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividuallist" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningIndividualListResponse> WatchlistScreeningIndividualListAsync(WatchlistScreening.WatchlistScreeningIndividualListRequest request) =>
		PostAsync("/watchlist_screening/individual/list", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningIndividualListResponse>();

	/// <summary>
	/// <para>Get an individual watchlist screening program</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividualprogramget" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningIndividualProgramGetResponse> WatchlistScreeningIndividualProgramGetAsync(WatchlistScreening.WatchlistScreeningIndividualProgramGetRequest request) =>
		PostAsync("/watchlist_screening/individual/program/get", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningIndividualProgramGetResponse>();

	/// <summary>
	/// <para>List all individual watchlist screening programs</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividualprogramlist" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningIndividualProgramListResponse> WatchlistScreeningIndividualProgramListAsync(WatchlistScreening.WatchlistScreeningIndividualProgramListRequest request) =>
		PostAsync("/watchlist_screening/individual/program/list", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningIndividualProgramListResponse>();

	/// <summary>
	/// <para>Create a review for the individual watchlist screening. Reviews are compliance reports created by users in your organization regarding the relevance of potential hits found by Plaid.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividualreviewcreate" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningIndividualReviewCreateResponse> WatchlistScreeningIndividualReviewCreateAsync(WatchlistScreening.WatchlistScreeningIndividualReviewCreateRequest request) =>
		PostAsync("/watchlist_screening/individual/review/create", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningIndividualReviewCreateResponse>();

	/// <summary>
	/// <para>List all reviews for the individual watchlist screening.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividualreviewlist" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningIndividualReviewListResponse> WatchlistScreeningIndividualReviewListAsync(WatchlistScreening.WatchlistScreeningIndividualReviewListRequest request) =>
		PostAsync("/watchlist_screening/individual/review/list", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningIndividualReviewListResponse>();

	/// <summary>
	/// <para>Update a specific individual watchlist screening. This endpoint can be used to add additional customer information, correct outdated information, add a reference id, assign the individual to a reviewer, and update which program it is associated with. Please note that you may not update <c>search_terms</c> and <c>status</c> at the same time since editing <c>search_terms</c> may trigger an automatic <c>status</c> change.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividualupdate" /></remarks>
	public Task<WatchlistScreening.WatchlistScreeningIndividualUpdateResponse> WatchlistScreeningIndividualUpdateAsync(WatchlistScreening.WatchlistScreeningIndividualUpdateRequest request) =>
		PostAsync("/watchlist_screening/individual/update", request)
			.ParseResponseAsync<WatchlistScreening.WatchlistScreeningIndividualUpdateResponse>();
}