using System.Text.Json;
using Xunit;
using Xunit.Abstractions;

namespace Going.Plaid.Tests;

public class AssetReportPdfGetAsyncTest(PlaidFixture fixture, ITestOutputHelper output) : IClassFixture<PlaidFixture>
{
	private readonly PlaidFixture _fixture = fixture;
	private readonly ITestOutputHelper _output = output;

	[Fact]
	public async Task InvalidAssetReportToken()
	{
		var oldToken = _fixture.PlaidClient.AccessToken;
		_fixture.PlaidClient.AccessToken = null;

		var token = "I am very poorly formatted";
		using var pdf = await _fixture.PlaidClient.AssetReportPdfGetAsync(new() { AssetReportToken = token });

		Assert.NotNull(pdf);
		Assert.NotNull(pdf.Error);
		Assert.Equal("INVALID_INPUT", pdf.Error!.ErrorType);
		Assert.Equal("INVALID_ASSET_REPORT_TOKEN", pdf.Error!.ErrorCode);

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

		const int TotalRetries = 15;
		var retries_left = TotalRetries;
		while (retries_left-- > 0 && !(getresponse?.IsSuccessStatusCode ?? false))
		{
			getresponse = await _fixture.PlaidClient.AssetReportGetAsync(getrequest);

			Assert.NotNull(getresponse);

			if (!getresponse.IsSuccessStatusCode)
				await Task.Delay(TimeSpan.FromSeconds(1));
		}

		Assert.True(getresponse!.IsSuccessStatusCode, $"Failed to get report after {TotalRetries} attempts");

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
		await pdfresponse.Stream.CopyToAsync(stream);

		_output.WriteLine($"File: {stream.Name}");
	}
}
