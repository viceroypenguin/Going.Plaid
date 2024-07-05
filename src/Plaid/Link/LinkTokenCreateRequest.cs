namespace Going.Plaid.Link;

/// <summary>
/// <para>LinkTokenCreateRequest defines the request schema for <c>/link/token/create</c></para>
/// </summary>
public partial class LinkTokenCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The name of your application, as it should be displayed in Link. Maximum length of 30 characters. If a value longer than 30 characters is provided, Link will display "This Application" instead.</para>
	/// </summary>
	[JsonPropertyName("client_name")]
	public string ClientName { get; set; } = default!;

	/// <summary>
	/// <para>The language that Link should be displayed in. When initializing with Identity Verification, this field is not used; for more details, see <a href="https://www.plaid.com/docs/identity-verification/#supported-languages">Identity Verification supported languages</a>.</para>
	/// <para>When using a Link customization, the language configured here must match the setting in the customization, or the customization will not be applied.</para>
	/// </summary>
	[JsonPropertyName("language")]
	public Language Language { get; set; } = default!;

	/// <summary>
	/// <para>Specify an array of Plaid-supported country codes using the ISO-3166-1 alpha-2 country code standard. Institutions from all listed countries will be shown. For a complete mapping of supported products by country, see https://plaid.com/global/.</para>
	/// <para>If using Identity Verification, <c>country_codes</c> should be set to the country where your company is based, not the country where your user is located. For all other products, <c>country_codes</c> represents the location of your user's financial institution.</para>
	/// <para>If Link is launched with multiple country codes, only products that you are enabled for in all countries will be used by Link. Note that while all countries are enabled by default in Sandbox, in Production only US and Canada are enabled by default. To request access to European institutions, <a href="https://dashboard.plaid.com/support/new/product-and-development/product-troubleshooting/request-product-access">file a product access Support ticket</a> via the Plaid dashboard.</para>
	/// <para>If using a Link customization, make sure the country codes in the customization match those specified in <c>country_codes</c>, or the customization may not be applied.</para>
	/// <para>If using the Auth features Instant Match, Instant Micro-deposits, Same-day Micro-deposits, Automated Micro-deposits, or Database Insights, <c>country_codes</c> must be set to <c>['US']</c>.</para>
	/// </summary>
	[JsonPropertyName("country_codes")]
	public IReadOnlyList<Entity.CountryCode> CountryCodes { get; set; } = default!;

	/// <summary>
	/// <para>An object specifying information about the end user who will be linking their account.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.LinkTokenCreateRequestUser User { get; set; } = default!;

	/// <summary>
	/// <para>List of Plaid product(s) you wish to use. If launching Link in update mode, should be omitted (unless you are using update mode to add Income or Assets to an Item); required otherwise.</para>
	/// <para><c>balance</c> is *not* a valid value, the Balance product does not require explicit initialization and will automatically be initialized when any other product is initialized.</para>
	/// <para>The products specified here will determine which institutions will be available to your users in Link. Only institutions that support *all* requested products can be selected; a if a user attempts to select an institution that does not support a listed product, a "Connectivity not supported" error message will appear in Link. To maximize the number of institutions available, initialize Link with the minimal product set required for your use case. Additional products can be included via the <a href="https://plaid.com/docs/api/tokens/#link-token-create-request-optional-products"><c>optional_products</c></a> or  <a href="https://plaid.com/docs/api/tokens/#link-token-create-request-required-if-supported-products"><c>required_if_supported_products</c></a> fields, or can be initialized by calling the endpoint after obtaining an access token. For details and exceptions, see <a href="https://plaid.com/docs/link/initializing-products/">Choosing when to initialize products</a>.</para>
	/// <para>Note that, unless you have opted to disable Instant Match support, institutions that support Instant Match will also be shown in Link if <c>auth</c> is specified as a product, even though these institutions do not contain <c>auth</c> in their product array.</para>
	/// <para>In Production, you will be billed for each product that you specify when initializing Link. Note that a product cannot be removed from an Item once the Item has been initialized with that product. To stop billing on an Item for subscription-based products, such as Liabilities, Investments, and Transactions, remove the Item via <c>/item/remove</c>.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.Products>? Products { get; set; } = default!;

	/// <summary>
	/// <para>List of Plaid product(s) you wish to use only if the institution and account(s) selected by the user support the product. Institutions that do not support these products will still be shown in Link. The products will only be extracted and billed if the user selects an institution and account type that supports them.</para>
	/// <para>There should be no overlap between this array and the <c>products</c>, <c>optional_products</c>, or <c>additional_consented_products</c> arrays. The <c>products</c> array must have at least one product.</para>
	/// <para>For more details on using this feature, see <a href="https://www.plaid.com/docs/link/initializing-products/#required-if-supported-products">Required if Supported Products</a>.</para>
	/// </summary>
	[JsonPropertyName("required_if_supported_products")]
	public IReadOnlyList<Entity.Products>? RequiredIfSupportedProducts { get; set; } = default!;

	/// <summary>
	/// <para>List of Plaid product(s) that will enhance the consumer's use case, but that your app can function without. Plaid will attempt to fetch data for these products on a best-effort basis, and failure to support these products will not affect Item creation.</para>
	/// <para>There should be no overlap between this array and the <c>products</c>, <c>required_if_supported_products</c>, or <c>additional_consented_products</c> arrays. The <c>products</c> array must have at least one product.</para>
	/// <para>For more details on using this feature, see <a href="https://www.plaid.com/docs/link/initializing-products/#optional-products">Optional Products</a>.</para>
	/// </summary>
	[JsonPropertyName("optional_products")]
	public IReadOnlyList<Entity.Products>? OptionalProducts { get; set; } = default!;

	/// <summary>
	/// <para>List of additional Plaid product(s) you wish to collect consent for to support your use case. These products will not be billed until you start using them by calling the relevant endpoints.</para>
	/// <para><c>balance</c> is *not* a valid value, the Balance product does not require explicit initialization and will automatically have consent collected.</para>
	/// <para>Institutions that do not support these products will still be shown in Link.</para>
	/// <para>There should be no overlap between this array and the <c>products</c> or <c>required_if_supported_products</c> arrays.</para>
	/// </summary>
	[JsonPropertyName("additional_consented_products")]
	public IReadOnlyList<Entity.Products>? AdditionalConsentedProducts { get; set; } = default!;

	/// <summary>
	/// <para>The destination URL to which any webhooks should be sent. Note that webhooks for Payment Initiation (e-wallet transactions only), Transfer, Bank Transfer (including Auth micro-deposit notification webhooks) and Identity Verification are configured via the Dashboard instead.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string? Webhook { get; set; } = default!;

	/// <summary>
	/// <para>A list of access tokens associated with the items to update in Link update mode for the Assets product. Using this instead of the <c>access_token</c> field allows the updating of multiple items at once. This feature is in closed beta, please contact your account manager for more info.</para>
	/// </summary>
	[JsonPropertyName("access_tokens")]
	public IReadOnlyList<string>? AccessTokens { get; set; } = default!;

	/// <summary>
	/// <para>The name of the Link customization from the Plaid Dashboard to be applied to Link. If not specified, the <c>default</c> customization will be used. When using a Link customization, the language in the customization must match the language selected via the <c>language</c> parameter, and the countries in the customization should match the country codes selected via <c>country_codes</c>.</para>
	/// </summary>
	[JsonPropertyName("link_customization_name")]
	public string? LinkCustomizationName { get; set; } = default!;

	/// <summary>
	/// <para>A URI indicating the destination where a user should be forwarded after completing the Link flow; used to support OAuth authentication flows when launching Link in the browser or another app. The <c>redirect_uri</c> should not contain any query parameters. When used in Production, must be an https URI. To specify any subdomain, use <c>*</c> as a wildcard character, e.g. <c>https://*.example.com/oauth.html</c>. Note that any redirect URI must also be added to the Allowed redirect URIs list in the <a href="https://dashboard.plaid.com/team/api">developer dashboard</a>. If initializing on Android, <c>android_package_name</c> must be specified instead and <c>redirect_uri</c> should be left blank. If using Hosted Link, the <c>redirect_uri</c> must be set to <c>https://secure.plaid.com/oauth/redirect</c>.</para>
	/// </summary>
	[JsonPropertyName("redirect_uri")]
	public string? RedirectUri { get; set; } = default!;

	/// <summary>
	/// <para>The name of your app's Android package. Required if using the <c>link_token</c> to initialize Link on Android. Any package name specified here must also be added to the Allowed Android package names setting on the <a href="https://dashboard.plaid.com/team/api">developer dashboard</a>. When creating a <c>link_token</c> for initializing Link on other platforms, <c>android_package_name</c> must be left blank and <c>redirect_uri</c> should be used instead.</para>
	/// </summary>
	[JsonPropertyName("android_package_name")]
	public string? AndroidPackageName { get; set; } = default!;

	/// <summary>
	/// <para>A map containing data used to highlight institutions in Link.</para>
	/// </summary>
	[JsonPropertyName("institution_data")]
	public Entity.LinkTokenCreateInstitutionData? InstitutionData { get; set; } = default!;

	/// <summary>
	/// <para>A map containing data to pass in for the Card Switch flow.</para>
	/// </summary>
	[JsonPropertyName("card_switch")]
	public Entity.LinkTokenCreateCardSwitch? CardSwitch { get; set; } = default!;

	/// <summary>
	/// <para>By default, Link will provide limited account filtering: it will only display Institutions that are compatible with all products supplied in the <c>products</c> parameter of <c>/link/token/create</c>, and, if <c>auth</c> is specified in the <c>products</c> array, will also filter out accounts other than <c>checking</c> and <c>savings</c> accounts on the Account Select pane. You can further limit the accounts shown in Link by using <c>account_filters</c> to specify the account subtypes to be shown in Link. Only the specified subtypes will be shown. This filtering applies to both the Account Select view (if enabled) and the Institution Select view. Institutions that do not support the selected subtypes will be omitted from Link. To indicate that all subtypes should be shown, use the value <c>"all"</c>. If the <c>account_filters</c> filter is used, any account type for which a filter is not specified will be entirely omitted from Link. For a full list of valid types and subtypes, see the <a href="https://plaid.com/docs/api/accounts#account-type-schema">Account schema</a>.</para>
	/// <para>The filter may or may not impact the list of accounts shown by the institution in the OAuth account selection flow, depending on the specific institution. If the user selects excluded account subtypes in the OAuth flow, these accounts will not be added to the Item. If the user selects only excluded account subtypes, the link attempt will fail and the user will be prompted to try again.</para>
	/// </summary>
	[JsonPropertyName("account_filters")]
	public Entity.LinkTokenAccountFilters? AccountFilters { get; set; } = default!;

	/// <summary>
	/// <para>Configuration parameters for EU flows</para>
	/// </summary>
	[JsonPropertyName("eu_config")]
	public Entity.LinkTokenEUConfig? EuConfig { get; set; } = default!;

	/// <summary>
	/// <para>Used for certain Europe-only configurations, as well as certain legacy use cases in other regions.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Payment Initiation (Europe) product. This field is required if <c>payment_initiation</c> is included in the <c>products</c> array. Either <c>payment_id</c> or <c>consent_id</c> must be provided.</para>
	/// </summary>
	[JsonPropertyName("payment_initiation")]
	public Entity.LinkTokenCreateRequestPaymentInitiation? PaymentInitiation { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Deposit Switch (beta) product. This field is required if <c>deposit_switch</c> is included in the <c>products</c> array.</para>
	/// </summary>
	[JsonPropertyName("deposit_switch")]
	public Entity.LinkTokenCreateRequestDepositSwitch? DepositSwitch { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Employment product. This field is required if <c>employment</c> is included in the <c>products</c> array.</para>
	/// </summary>
	[JsonPropertyName("employment")]
	public Entity.LinkTokenCreateRequestEmployment? Employment { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Income product. This field is required if <c>income_verification</c> is included in the <c>products</c> array.</para>
	/// </summary>
	[JsonPropertyName("income_verification")]
	public Entity.LinkTokenCreateRequestIncomeVerification? IncomeVerification { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Base Report product. This field is required if <c>assets</c> is included in the <c>products</c> array and the client is CRA-enabled.</para>
	/// </summary>
	[JsonPropertyName("base_report")]
	public Entity.LinkTokenCreateRequestBaseReport? BaseReport { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Credit Partner Insights product.</para>
	/// </summary>
	[JsonPropertyName("credit_partner_insights")]
	public Entity.LinkTokenCreateRequestCreditPartnerInsights? CreditPartnerInsights { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with Plaid Check products</para>
	/// </summary>
	[JsonPropertyName("cra_options")]
	public Entity.LinkTokenCreateRequestCraOptions? CraOptions { get; set; } = default!;

	/// <summary>
	/// <para>This enum describes the reason you are generating a Consumer Report for this user.</para>
	/// </summary>
	[JsonPropertyName("consumer_report_permissible_purpose")]
	public Entity.ConsumerReportPermissiblePurpose? ConsumerReportPermissiblePurpose { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Auth product. This field can be used to enable or disable extended Auth flows for the resulting Link session. Omitting any field will result in a default that can be configured by your account manager. The default behavior described in the documentation is the default behavior that will apply if you have not requested your account manager to apply a different default.</para>
	/// </summary>
	[JsonPropertyName("auth")]
	public Entity.LinkTokenCreateRequestAuth? Auth { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Transfer product.</para>
	/// </summary>
	[JsonPropertyName("transfer")]
	public Entity.LinkTokenCreateRequestTransfer? Transfer { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for <a href="https://plaid.com/docs/link/update-mode">update mode</a>.</para>
	/// </summary>
	[JsonPropertyName("update")]
	public Entity.LinkTokenCreateRequestUpdate? Update { get; set; } = default!;

	/// <summary>
	/// <para>Specifies option for initializing Link for use with the Identity Verification product.</para>
	/// </summary>
	[JsonPropertyName("identity_verification")]
	public Entity.LinkTokenCreateRequestIdentityVerification? IdentityVerification { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Statements product. This field is required for the statements product.</para>
	/// </summary>
	[JsonPropertyName("statements")]
	public Entity.LinkTokenCreateRequestStatements? Statements { get; set; } = default!;

	/// <summary>
	/// <para>A user token generated using <c>/user/create</c>. Any Item created during the Link session will be associated with the user.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;

	/// <summary>
	/// <para>Configuration parameters for the Investments product</para>
	/// </summary>
	[JsonPropertyName("investments")]
	public Entity.LinkTokenInvestments? Investments { get; set; } = default!;

	/// <summary>
	/// <para>Configuration parameters for the Investments Auth Product</para>
	/// </summary>
	[JsonPropertyName("investments_auth")]
	public Entity.LinkTokenInvestmentsAuth? InvestmentsAuth { get; set; } = default!;

	/// <summary>
	/// <para>Configuration parameters for Hosted Link. To request access to Hosted Link, contact your account manager.</para>
	/// </summary>
	[JsonPropertyName("hosted_link")]
	public Entity.LinkTokenCreateHostedLink? HostedLink { get; set; } = default!;

	/// <summary>
	/// <para>Configuration parameters for the Transactions product</para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public Entity.LinkTokenTransactions? Transactions { get; set; } = default!;

	/// <summary>
	/// <para>If <c>true</c>, request a CRA connection. Defaults to <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("cra_enabled")]
	public bool? CraEnabled { get; set; } = default!;

	/// <summary>
	/// <para>Identity object used to specify document upload</para>
	/// </summary>
	[JsonPropertyName("identity")]
	public Entity.LinkTokenCreateIdentity? Identity { get; set; } = default!;

	/// <summary>
	/// <para>If <c>true</c>, indicates that client supports linking FinanceKit / AppleCard items. Defaults to <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("financekit_supported")]
	public bool? FinancekitSupported { get; set; } = default!;

	/// <summary>
	/// <para>If <c>true</c>, enable linking multiple items in the same Link session. Defaults to <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("enable_multi_item_link")]
	public bool? EnableMultiItemLink { get; set; } = default!;

}
