using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Going.Plaid.Demo.Middleware
{
	public class PlaidCredentials
	{
		public PlaidCredentials()
		{
			var secretPath = Path.Combine(System.AppContext.BaseDirectory, "secrets.json");
			var plaid = JObject.Parse(File.ReadAllText(secretPath));

			Environment = Enum.Parse<Environment>(plaid["Environment"].Value<string>());
			ClientId = plaid["ClientId"].Value<string>();
			Secret = plaid["Secret"].Value<string>();
		}

		public Environment Environment { get; }
		public string Secret { get; }
		public string ClientId { get; }

		public string LinkToken { get; set; }
		public string AccessToken { get; set; }
	}
}
