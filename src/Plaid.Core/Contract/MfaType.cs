namespace Gigobyte.Plaid.Contract
{
    /// <summary>
    /// Multi-Factor Authentication (MFA) type
    /// </summary>
    public enum MfaType
    {
        /// <summary>
        /// Question-Based MFA.
        /// </summary>
        /// <remarks>
        /// Question-based authentication ( <see cref="PlaidConnectResponse.MfaTypeId"/>=questions)
        /// requires the user to answer a security question. With some financial institutions,
        /// multiple security questions may be required. To handle multiple security questions, it is
        /// recommended that you continue to post to the route until an http code 200 is received.
        /// </remarks>
        Question,

        /// <summary>
        /// The codeCode-Based MFA
        /// </summary>
        /// <remarks>
        /// Some institutions require an MFA code that is sent to your email or phone. If there are
        /// multiple potential delivery methods, we allow you to specify which you'd like to use. To
        /// see a list of delivery options, specify { <see cref="SubmitOptions.List"/>:true.
        /// </remarks>
        Code
    }
}