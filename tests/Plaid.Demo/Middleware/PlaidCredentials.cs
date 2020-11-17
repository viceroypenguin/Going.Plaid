using System;

namespace Going.Plaid.Demo.Middleware
{
	public class PlaidCredentials : PlaidOptions
	{
		public string LinkToken { get; set; }
		public string AccessToken { get; set; }
	}
}
