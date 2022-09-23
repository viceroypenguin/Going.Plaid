using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Going.Plaid.Tests
{
	public class AssetReportPdfGetAsyncTest : IClassFixture<PlaidFixture>
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
			var oldToken = _fixture.PlaidClient.AccessToken;
			_fixture.PlaidClient.AccessToken = null;

			var token = "I am very poorly formatted";
			using var pdf = await _fixture.PlaidClient.AssetReportPdfGetAsync(new() { AssetReportToken = token });

			Assert.NotNull(pdf);
			Assert.NotNull(pdf.Error);
			Assert.Equal(Entity.ErrorType.InvalidInput, pdf.Error!.ErrorType);
			Assert.Equal(Entity.ErrorCode.InvalidAssetReportToken, pdf.Error!.ErrorCode);

			_fixture.PlaidClient.AccessToken = oldToken;
		}

		[Fact]
		public async Task AssetReportPdfGetAsync()
		{
			// Step 1. Create the report

			var createrequest = new AssetReport.AssetReportCreateRequest()
			{
				AccessTokens = new[] { _fixture.PlaidClient.AccessToken! },
				DaysRequested = 10,
			};
			_fixture.PlaidClient.AccessToken = null;
			var createresponse = await _fixture.PlaidClient.AssetReportCreateAsync(createrequest);

			Assert.NotNull(createresponse);
			Assert.True(createresponse.IsSuccessStatusCode, JsonSerializer.Serialize(createresponse));

			var reporttoken = createresponse.AssetReportToken;

			// Step 2. Get the report in data form
			//
			// This can take a while

			var getrequest = new AssetReport.AssetReportGetRequest() { AssetReportToken = reporttoken };
			AssetReport.AssetReportGetResponse? getresponse = null;
			const int total_retries = 15;
			var retries_left = total_retries;
			while (retries_left-- > 0 && !(getresponse?.IsSuccessStatusCode ?? false))
			{
				getresponse = await _fixture.PlaidClient.AssetReportGetAsync(getrequest);

				Assert.NotNull(getresponse);

				if (!getresponse.IsSuccessStatusCode)
					await Task.Delay(TimeSpan.FromSeconds(1));
			}

			Assert.True(getresponse!.IsSuccessStatusCode, $"Failed to get report after {total_retries} attempts");

			// Step 3. Get the PDF

			var pdfrequest = new AssetReport.AssetReportPdfGetRequest() { AssetReportToken = reporttoken };
			using var pdfresponse = await _fixture.PlaidClient.AssetReportPdfGetAsync(pdfrequest);

			Assert.NotNull(pdfresponse);
			Assert.True(pdfresponse.IsSuccessStatusCode);
			Assert.True(pdfresponse.Error is null, JsonSerializer.Serialize(pdfresponse.Error));
			Assert.NotNull(pdfresponse.Headers);

			_output.WriteLine
			(
				"Headers:\r\n{0}",
				string.Join
				(
					"\r\n",
					pdfresponse
						.Headers
						.Select(x => $"\t{x.Key}: {string.Join(',', x)}")
				)
			);

			Assert.True(pdfresponse.Headers["Content-Type"].Any());
			Assert.Equal("application/pdf", pdfresponse.Headers["Content-Type"].First());

			// Step 4. Write it out

			var filename = "AssetReportPdfGetAsync.pdf";
			File.Delete(filename);
			using var stream = File.OpenWrite(filename);
			pdfresponse.Stream.CopyTo(stream);

			_output.WriteLine($"File: {stream.Name}");
		}
	}
}
