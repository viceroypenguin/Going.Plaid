namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Create a new entity watchlist screening to check your customer against watchlists defined in the associated entity watchlist program. If your associated program has ongoing screening enabled, this is the profile information that will be used to monitor your customer over time.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentitycreate" /></remarks>
	public Task<Entity.EntityWatchlistScreening> WatchlistScreeningEntityCreateAsync(WatchlistScreening.CreateEntityScreeningRequest request) =>
		PostAsync("/watchlist_screening/entity/create", request)
			.ParseResponseAsync<Entity.EntityWatchlistScreening>();

	/// <summary>
	/// <para>Retrieve an entity watchlist screening.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentityget" /></remarks>
	public Task<Entity.EntityWatchlistScreening> WatchlistScreeningEntityGetAsync(WatchlistScreening.GetEntityWatchlistScreeningRequest request) =>
		PostAsync("/watchlist_screening/entity/get", request)
			.ParseResponseAsync<Entity.EntityWatchlistScreening>();

	/// <summary>
	/// <para>List all changes to the entity watchlist screening in reverse-chronological order. If the watchlist screening has not been edited, no history will be returned.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentityhistorylist" /></remarks>
	public Task<Entity.PaginatedEntityWatchlistScreeningList> WatchlistScreeningEntityHistoryListAsync(WatchlistScreening.ListWatchlistScreeningEntityHistoryRequest request) =>
		PostAsync("/watchlist_screening/entity/history/list", request)
			.ParseResponseAsync<Entity.PaginatedEntityWatchlistScreeningList>();

	/// <summary>
	/// <para>List all hits for the entity watchlist screening.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentityhitlist" /></remarks>
	public Task<Entity.PaginatedEntityWatchlistScreeningHitList> WatchlistScreeningEntityHitListAsync(WatchlistScreening.ListWatchlistScreeningEntityHitRequest request) =>
		PostAsync("/watchlist_screening/entity/hit/list", request)
			.ParseResponseAsync<Entity.PaginatedEntityWatchlistScreeningHitList>();

	/// <summary>
	/// <para>List all entity screenings.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentitylist" /></remarks>
	public Task<Entity.PaginatedEntityWatchlistScreeningList> WatchlistScreeningEntityListAsync(WatchlistScreening.ListEntityWatchlistScreeningRequest request) =>
		PostAsync("/watchlist_screening/entity/list", request)
			.ParseResponseAsync<Entity.PaginatedEntityWatchlistScreeningList>();

	/// <summary>
	/// <para>Get an entity watchlist screening program</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentityprogramget" /></remarks>
	public Task<Entity.EntityWatchlistProgram> WatchlistScreeningEntityProgramGetAsync(WatchlistScreening.GetWatchlistScreeningEntityProgramRequest request) =>
		PostAsync("/watchlist_screening/entity/program/get", request)
			.ParseResponseAsync<Entity.EntityWatchlistProgram>();

	/// <summary>
	/// <para>List all entity watchlist screening programs</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentityprogramlist" /></remarks>
	public Task<Entity.PaginatedEntityWatchlistProgramList> WatchlistScreeningEntityProgramListAsync(WatchlistScreening.ListWatchlistScreeningEntityProgramsRequest request) =>
		PostAsync("/watchlist_screening/entity/program/list", request)
			.ParseResponseAsync<Entity.PaginatedEntityWatchlistProgramList>();

	/// <summary>
	/// <para>Create a review for an entity watchlist screening. Reviews are compliance reports created by users in your organization regarding the relevance of potential hits found by Plaid.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentityreviewcreate" /></remarks>
	public Task<Entity.EntityWatchlistScreeningReview> WatchlistScreeningEntityReviewCreateAsync(WatchlistScreening.CreateEntityWatchlistScreeningReviewRequest request) =>
		PostAsync("/watchlist_screening/entity/review/create", request)
			.ParseResponseAsync<Entity.EntityWatchlistScreeningReview>();

	/// <summary>
	/// <para>List all reviews for a particular entity watchlist screening. Reviews are compliance reports created by users in your organization regarding the relevance of potential hits found by Plaid.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentityreviewlist" /></remarks>
	public Task<Entity.PaginatedEntityWatchlistScreeningReviewList> WatchlistScreeningEntityReviewListAsync(WatchlistScreening.ListWatchlistScreeningEntityReviewsRequest request) =>
		PostAsync("/watchlist_screening/entity/review/list", request)
			.ParseResponseAsync<Entity.PaginatedEntityWatchlistScreeningReviewList>();

	/// <summary>
	/// <para>Update an entity watchlist screening.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningentityupdate" /></remarks>
	public Task<Entity.EntityWatchlistScreening> WatchlistScreeningEntityUpdateAsync(WatchlistScreening.UpdateEntityScreeningRequest request) =>
		PostAsync("/watchlist_screening/entity/update", request)
			.ParseResponseAsync<Entity.EntityWatchlistScreening>();

	/// <summary>
	/// <para>Create a new Watchlist Screening to check your customer against watchlists defined in the associated Watchlist Program. If your associated program has ongoing screening enabled, this is the profile information that will be used to monitor your customer over time.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividualcreate" /></remarks>
	public Task<Entity.WatchlistScreeningIndividual> WatchlistScreeningIndividualCreateAsync(WatchlistScreening.WatchlistScreeningCreateRequest request) =>
		PostAsync("/watchlist_screening/individual/create", request)
			.ParseResponseAsync<Entity.WatchlistScreeningIndividual>();

	/// <summary>
	/// <para>Retrieve a previously created individual watchlist screening</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividualget" /></remarks>
	public Task<Entity.WatchlistScreeningIndividual> WatchlistScreeningIndividualGetAsync(WatchlistScreening.GetIndividualWatchlistScreeningRequest request) =>
		PostAsync("/watchlist_screening/individual/get", request)
			.ParseResponseAsync<Entity.WatchlistScreeningIndividual>();

	/// <summary>
	/// <para>List all changes to the individual watchlist screening in reverse-chronological order. If the watchlist screening has not been edited, no history will be returned.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividualhistorylist" /></remarks>
	public Task<Entity.PaginatedIndividualWatchlistScreeningList> WatchlistScreeningIndividualHistoryListAsync(WatchlistScreening.ListWatchlistScreeningIndividualHistoryRequest request) =>
		PostAsync("/watchlist_screening/individual/history/list", request)
			.ParseResponseAsync<Entity.PaginatedIndividualWatchlistScreeningList>();

	/// <summary>
	/// <para>List all hits found by Plaid for a particular individual watchlist screening.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividualhitlist" /></remarks>
	public Task<Entity.PaginatedIndividualWatchlistScreeningHitList> WatchlistScreeningIndividualHitListAsync(WatchlistScreening.ListWatchlistScreeningIndividualHitRequest request) =>
		PostAsync("/watchlist_screening/individual/hit/list", request)
			.ParseResponseAsync<Entity.PaginatedIndividualWatchlistScreeningHitList>();

	/// <summary>
	/// <para>List previously created watchlist screenings for individuals</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividuallist" /></remarks>
	public Task<Entity.PaginatedIndividualWatchlistScreeningList> WatchlistScreeningIndividualListAsync(WatchlistScreening.ListIndividualWatchlistScreeningRequest request) =>
		PostAsync("/watchlist_screening/individual/list", request)
			.ParseResponseAsync<Entity.PaginatedIndividualWatchlistScreeningList>();

	/// <summary>
	/// <para>Get an individual watchlist screening program</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividualprogramget" /></remarks>
	public Task<Entity.IndividualWatchlistProgram> WatchlistScreeningIndividualProgramGetAsync(WatchlistScreening.GetWatchlistScreeningIndividualProgramRequest request) =>
		PostAsync("/watchlist_screening/individual/program/get", request)
			.ParseResponseAsync<Entity.IndividualWatchlistProgram>();

	/// <summary>
	/// <para>List all individual watchlist screening programs</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividualprogramlist" /></remarks>
	public Task<Entity.PaginatedIndividualWatchlistProgramList> WatchlistScreeningIndividualProgramListAsync(WatchlistScreening.ListWatchlistScreeningIndividualProgramsRequest request) =>
		PostAsync("/watchlist_screening/individual/program/list", request)
			.ParseResponseAsync<Entity.PaginatedIndividualWatchlistProgramList>();

	/// <summary>
	/// <para>Create a review for the individual watchlist screening. Reviews are compliance reports created by users in your organization regarding the relevance of potential hits found by Plaid.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividualreviewcreate" /></remarks>
	public Task<Entity.WatchlistScreeningReview> WatchlistScreeningIndividualReviewCreateAsync(WatchlistScreening.CreateIndividualWatchlistScreeningReviewRequest request) =>
		PostAsync("/watchlist_screening/individual/review/create", request)
			.ParseResponseAsync<Entity.WatchlistScreeningReview>();

	/// <summary>
	/// <para>List all reviews for the individual watchlist screening.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividualreviewlist" /></remarks>
	public Task<Entity.PaginatedIndividualWatchlistScreeningReviewList> WatchlistScreeningIndividualReviewListAsync(WatchlistScreening.ListWatchlistScreeningIndividualReviewsRequest request) =>
		PostAsync("/watchlist_screening/individual/review/list", request)
			.ParseResponseAsync<Entity.PaginatedIndividualWatchlistScreeningReviewList>();

	/// <summary>
	/// <para>Update a specific individual watchlist screening. This endpoint can be used to add additional customer information, correct outdated information, add a reference id, assign the individual to a reviewer, and update which program it is associated with. Please note that you may not update <c>search_terms</c> and <c>status</c> at the same time since editing <c>search_terms</c> may trigger an automatic <c>status</c> change.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/#watchlist_screeningindividualupdate" /></remarks>
	public Task<Entity.WatchlistScreeningIndividual> WatchlistScreeningIndividualUpdateAsync(WatchlistScreening.UpdateIndividualScreeningRequest request) =>
		PostAsync("/watchlist_screening/individual/update", request)
			.ParseResponseAsync<Entity.WatchlistScreeningIndividual>();
}