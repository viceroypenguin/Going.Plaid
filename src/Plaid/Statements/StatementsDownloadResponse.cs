namespace Going.Plaid.Statements;

/// <summary>
/// <para>StatementsDownloadResponse defines the response schema for <c>/statements/download</c>. The response will contain a <c>Plaid-Content-Hash</c> header containing a SHA 256 checksum of the statement. This can be used to verify that the file being sent by Plaid is the same file that was downloaded to your systems.</para>
/// </summary>
public record StatementsDownloadResponse : ResponseBase
{
}