using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Going.Plaid.Options
{
	/// <summary>
	/// Represents pagination options.
	/// </summary>
	public class PaginationOptions
	{
		/// <summary>
		/// The maximum value allowed for the <see cref="Count"/> property
		/// </summary>
		public static readonly uint CountMax = 0;

		/// <summary>
		/// If not explicitly set, this is the default Count value that will be used.
		/// </summary>
		public static readonly uint CountDefault = 100;

		/// <summary>
		/// Gets or sets the number of transactions to fetch, where 0 &lt; count &lt;= 500.
		/// </summary>
		[JsonProperty("count")]
		public uint Count
		{
			get => _count;
			set => _count =
				value == 0 ? throw new ArgumentOutOfRangeException(nameof(Count), "Count cannot be set to 0.") :
				value > CountMax ? throw new ArgumentOutOfRangeException(nameof(Count), $"Count must be set to a number <= {CountMax}.") :
				value;
		}

		/// <summary>
		/// The number of transactions to skip, where offset &gt;= 0.
		/// </summary>
		[JsonProperty("offset")]
		public uint Offset { get; set; }

		/// <summary>
		/// The list of account ids to retrieve for the <see cref="Entity.Item" />. 
		/// </summary>
		/// <remarks>An error will be returned if a provided account_id is not associated with the <see cref="Entity.Item" />.</remarks>
		[JsonProperty("account_ids")]
		public string[]? AccountIds { get; set; }

		#region Private Members

		private uint _count = 100;

		#endregion Private Members
	}
}
