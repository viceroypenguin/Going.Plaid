namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the request schema for <c>/transfer/configuration/get</c></para>
/// </summary>
public partial class TransferConfigurationGetRequest : RequestBase
{
	/// <summary>
	/// <para>The Plaid client ID of the transfer originator. Should only be present if <c>client_id</c> is a <a href="https://plaid.com/docs/transfer/application/#originators-vs-platforms">Platform customer</a>.</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string? OriginatorClientId { get; set; } = default!;

}
