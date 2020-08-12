using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Going.Plaid.Demo.Middleware
{
	public class PlaidCredentials : PlaidOptions
	{
		public string LinkToken { get; set; }
		public string AccessToken { get; set; }
	}
}
