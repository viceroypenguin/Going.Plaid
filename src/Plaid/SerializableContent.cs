using Newtonsoft.Json;

namespace Going.Plaid
{
	/// <summary>
	/// Provide an method for converting an object to a JSON string.
	/// </summary>
	public abstract class SerializableContent
	{
		/// <summary>
		/// The null value handling.
		/// </summary>
		protected NullValueHandling _nullValueHandling = NullValueHandling.Ignore;

		/// <summary>
		/// Returns a string that represents the current object in JSON format.
		/// </summary>
		public virtual string ToJson() =>
			JsonConvert.SerializeObject(this, new JsonSerializerSettings()
			{
				DateFormatString = "yyyy-MM-dd",
				NullValueHandling = _nullValueHandling,
#if DEBUG
				Formatting = Formatting.Indented
#else
				Formatting = Formatting.None
#endif
			});
	}
}
