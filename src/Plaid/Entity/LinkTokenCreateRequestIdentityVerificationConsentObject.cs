namespace Going.Plaid.Entity;

/// <summary>
/// <para>A flag specifying whether the end user has already agreed to a privacy policy specifying that their data will be shared with Plaid for verification purposes.</para>
/// <para>If <c>gave_consent</c> is set to <c>true</c>, the <c>accept_tos</c> step will be marked as <c>skipped</c> and the end user's session will start at the next step requirement.</para>
/// </summary>
public class LinkTokenCreateRequestIdentityVerificationConsentObject
{
}
