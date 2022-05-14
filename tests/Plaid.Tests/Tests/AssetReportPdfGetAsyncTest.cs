using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Going.Plaid.Tests
{
	public class AssetReportPdfGetAsyncTest: IClassFixture<PlaidFixture>
	{
		private readonly PlaidFixture _fixture;
		private readonly ITestOutputHelper _output;

		public AssetReportPdfGetAsyncTest(PlaidFixture fixture, ITestOutputHelper output)
		{
			_fixture = fixture;
			_output = output;
		}

		[Fact]
		public async Task InvalidAssetReportToken()
		{
			string token = "I am very poorly formatted";
			_fixture.PlaidClient.AccessToken = null;
			using var pdf = await _fixture.PlaidClient.AssetReportPdfGetAsync(new() { AssetReportToken = token });

			Assert.NotNull(pdf);
			Assert.NotNull(pdf.Error);
			Assert.Equal(Entity.ErrorType.InvalidInput, pdf.Error!.ErrorType);
			Assert.Equal(Entity.ErrorCode.InvalidAssetReportToken, pdf.Error!.ErrorCode);

			_output.WriteLine("Error: {0}", System.Text.Json.JsonSerializer.Serialize(pdf.Error));
		}
#if false
		public async Task Ok()
		{
			string token = "You can't find me!";
			_fixture.PlaidClient.AccessToken = null;
			using var pdf = await _fixture.PlaidClient.AssetReportPdfGetAsync(new() { AssetReportToken = token });


			if (pdf.Error is not null)
			{
				_output.WriteLine("Error: {0}", System.Text.Json.JsonSerializer.Serialize(pdf.Error));
			}

			Assert.Equal(System.Net.HttpStatusCode.OK, pdf.StatusCode);

			_output.WriteLine("Headers:\n", pdf.Headers.Select(x => $"\t{x.Key}: {string.Join(',', x.Value)}\n"));

			var filename = "AssetReportPdfGetAsync.pdf";
			System.IO.File.Delete(filename);
			using var stream = System.IO.File.OpenWrite(filename);
			pdf.Stream.CopyTo(stream);
		}
#endif
	}
}
