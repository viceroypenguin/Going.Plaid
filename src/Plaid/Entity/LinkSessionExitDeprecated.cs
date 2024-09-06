namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing an <a href="https://plaid.com/docs/link/web/#onexit">onExit</a> callback from Link. This field has been deprecated in favor of <a href="https://plaid.com/docs/api/link/#link-token-get-response-link-sessions-exit"><c>exit</c></a>, for improved naming consistency.</para>
/// </summary>
public record LinkSessionExitDeprecated
{
	/// <summary>
	/// <para>Errors are identified by <c>error_code</c> and categorized by <c>error_type</c>. Use these in preference to HTTP status codes to identify and handle specific errors. HTTP status codes are set and provide the broadest categorization of errors: 4xx codes are for developer- or user-related errors, and 5xx codes are for Plaid-related errors, and the status will be 2xx in non-error cases. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;

	/// <summary>
	/// <para>Displayed if a user exits Link without successfully linking an Item.</para>
	/// </summary>
	[JsonPropertyName("metadata")]
	public Entity.LinkSessionExitMetadata? Metadata { get; init; } = default!;

}
