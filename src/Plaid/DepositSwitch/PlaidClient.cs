namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>This endpoint creates a deposit switch entity that will be persisted throughout the lifecycle of the switch.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/deposit-switch/reference#deposit_switchcreate" /></remarks>
	public Task<DepositSwitch.DepositSwitchCreateResponse> DepositSwitchCreateAsync(DepositSwitch.DepositSwitchCreateRequest request) =>
		PostAsync("/deposit_switch/create", request)
			.ParseResponseAsync<DepositSwitch.DepositSwitchCreateResponse>();

	/// <summary>
	/// <para>In order for the end user to take action, you will need to create a public token representing the deposit switch. This token is used to initialize Link. It can be used one time and expires after 30 minutes.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/deposit-switch/reference#deposit_switchtokencreate" /></remarks>
	public Task<DepositSwitch.DepositSwitchTokenCreateResponse> DepositSwitchTokenCreateAsync(DepositSwitch.DepositSwitchTokenCreateRequest request) =>
		PostAsync("/deposit_switch/token/create", request)
			.ParseResponseAsync<DepositSwitch.DepositSwitchTokenCreateResponse>();

	/// <summary>
	/// <para>This endpoint returns information related to how the user has configured their payroll allocation and the state of the switch. You can use this information to build logic related to the user's direct deposit allocation preferences.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/deposit-switch/reference#deposit_switchget" /></remarks>
	public Task<DepositSwitch.DepositSwitchGetResponse> DepositSwitchGetAsync(DepositSwitch.DepositSwitchGetRequest request) =>
		PostAsync("/deposit_switch/get", request)
			.ParseResponseAsync<DepositSwitch.DepositSwitchGetResponse>();

	/// <summary>
	/// <para>This endpoint provides an alternative to <c>/deposit_switch/create</c> for customers who have not yet fully integrated with Plaid Exchange. Like <c>/deposit_switch/create</c>, it creates a deposit switch entity that will be persisted throughout the lifecycle of the switch.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/deposit-switch/reference#deposit_switchaltcreate" /></remarks>
	public Task<DepositSwitch.DepositSwitchAltCreateResponse> DepositSwitchAltCreateAsync(DepositSwitch.DepositSwitchAltCreateRequest request) =>
		PostAsync("/deposit_switch/alt/create", request)
			.ParseResponseAsync<DepositSwitch.DepositSwitchAltCreateResponse>();
}