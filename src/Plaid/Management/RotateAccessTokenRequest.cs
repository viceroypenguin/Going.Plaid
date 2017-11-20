using System;
using System.Collections.Generic;
using System.Text;

namespace Acklann.Plaid.Management
{
    /// <summary>
    /// Represents a request for plaid's '/item/access_token/invalidate'. You can use the '/item/access_token/invalidate' endpoint to rotate the access_token associated with an Item. The endpoint returns a new access_token and immediately invalidates the previous access_token.
    /// </summary>
    /// <seealso cref="Acklann.Plaid.RequestBase" />
    public class RotateAccessTokenRequest : RequestBase
    {
    }
}
