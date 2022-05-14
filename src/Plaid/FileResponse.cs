namespace Going.Plaid;

/// <summary>
/// A file returned from Plaid API
/// </summary>
public record FileResponse : ResponseBase, IDisposable
{
	/// <summary>
	/// Constructor for successful reponse
	/// </summary>
	public FileResponse(HttpStatusCode status, IDictionary<string, IEnumerable<string>> headers, System.IO.Stream stream, IDisposable disposable)
	{
		StatusCode = status;
		Headers = headers;
		Stream = stream;
		_disposable = disposable;
	}

	/// <summary>
	/// Constructor for failed response
	/// </summary>
	public FileResponse(HttpStatusCode status, Errors.PlaidError error)
	{
		StatusCode = status;
		Headers = new Dictionary<string, IEnumerable<string>>(StringComparer.Ordinal);
		Stream = System.IO.Stream.Null;
		_disposable = null;

		base.Error = error;
	}

	/// <summary>
	/// Dispose
	/// </summary>	
	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	/// <summary>
	/// Internal Dispose
	/// </summary>	
	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (_disposable != null)
			{
				_disposable.Dispose();
				_disposable = null;
			}
		}
	}

	/// <summary>
	/// Headers
	/// </summary>	
	public IDictionary<string, IEnumerable<string>> Headers { get; private set; }

	/// <summary>
	/// Content Stream
	/// </summary>	
	public System.IO.Stream Stream { get; private set; }

	private IDisposable? _disposable;
}
