using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Going.Plaid.Link;
using Moq;
using Xunit;
using MOptions = Microsoft.Extensions.Options.Options;

namespace Going.Plaid.Tests
{
	public class DelegatingHandlerStub : DelegatingHandler
	{
		private readonly Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> _handlerFunc;

		public DelegatingHandlerStub()
		{
			_handlerFunc = (request, cancellationToken) =>
				Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));
		}

		public DelegatingHandlerStub(
			Func<HttpRequestMessage, CancellationToken, Task<HttpResponseMessage>> handlerFunc)
		{
			_handlerFunc = handlerFunc;
		}

		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
			CancellationToken cancellationToken)
		{
			return _handlerFunc(request, cancellationToken);
		}
	}

	public class PlaidClientErrorTests
	{
		[Fact]
		public async Task UnknownContentTypesShouldGenerateGenericError()
		{
			var clientHandlerStub = new DelegatingHandlerStub((message, token) =>
				Task.FromResult(new HttpResponseMessage(HttpStatusCode.ServiceUnavailable))
			);

			var client = new HttpClient(clientHandlerStub);

			var mockFactory = new Mock<IHttpClientFactory>();
			mockFactory.Setup(_ => _.CreateClient(It.IsAny<string>())).Returns(client);

			var plaidClient = new PlaidClient(
				MOptions.Create(new PlaidOptions
				{
					Environment = Environment.Development,
					Secret = "",
					ApiVersion = ApiVersion.v20200914,
					ClientId = "",
					DefaultAccessToken = "",
				}),
				mockFactory.Object
			);

			var response = await plaidClient.LinkTokenCreateAsync(new LinkTokenCreateRequest());

			Assert.Equal(HttpStatusCode.ServiceUnavailable, response.StatusCode);
			Assert.Null(response.Error);
		}
	}
}
