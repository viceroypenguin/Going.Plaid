using System;
using System.Text.Json.Serialization;

namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a response from plaid's '<c>/item/remove</c>' endpoint. The POST <c>/item/remove</c> endpoint allows the user to remove an <see cref="Entity.Item"/>.
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public record RemoveItemResponse : ResponseBase { }
}
