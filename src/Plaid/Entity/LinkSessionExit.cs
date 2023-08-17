namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing an <a href="https://plaid.com/docs/link/web/#onexit">onExit</a> callback from Link.</para>
/// </summary>
public record LinkSessionExit
{
	/// <summary>
	/// <para>We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;

	/// <summary>
	/// <para>Displayed if a user exits Link without successfully linking an Item.</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public Entity.LinkSessionExitMetadata? Metadata { get; init; } = default!;
}