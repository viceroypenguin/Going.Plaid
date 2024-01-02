namespace Going.Plaid.Categories
{
	public partial class CategoriesGetRequest : RequestBase
	{
		/// <inheritdoc />
		protected internal override bool IncludeAccessToken => false;
		/// <inheritdoc />
		protected internal override bool IncludeSecrets => false;
	}
}

namespace Going.Plaid.Item
{
	public partial class ItemPublicTokenCreateRequest : RequestBase
	{
		/// <inheritdoc />
		protected internal override bool IncludeAccessToken => false;
	}

	public partial class ItemPublicTokenExchangeRequest : RequestBase
	{
		/// <inheritdoc />
		protected internal override bool IncludeAccessToken => false;
	}
}

namespace Going.Plaid.Link
{
	public partial class LinkTokenCreateRequest : RequestBase
	{
		/// <inheritdoc />
		protected internal override bool IncludeAccessToken => false;
	}
}

namespace Going.Plaid.PaymentInitiation
{
	public partial class PaymentInitiationRecipientCreateRequest : RequestBase
	{
		/// <inheritdoc />
		protected internal override bool IncludeAccessToken => false;
	}
}

namespace Going.Plaid.Processor
{
	public partial class ProcessorTokenCreateRequest : RequestBase
	{
		/// <inheritdoc />
		protected internal override bool IncludeAccessToken => false;
	}
}

namespace Going.Plaid.Sandbox
{
	public partial class SandboxPublicTokenCreateRequest : RequestBase
	{
		/// <inheritdoc />
		protected internal override bool IncludeAccessToken => false;
	}

	public partial class SandboxProcessorTokenCreateRequest : RequestBase
	{
		/// <inheritdoc />
		protected internal override bool IncludeAccessToken => false;
	}
}
