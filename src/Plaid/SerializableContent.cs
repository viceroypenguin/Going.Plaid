using Newtonsoft.Json;

namespace Acklann.Plaid
{
    public abstract class SerializableContent
    {
        protected NullValueHandling NullValueHandling = NullValueHandling.Ignore;

        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings()
            {
                DateFormatString = "yyyy-MM-dd",
                NullValueHandling = this.NullValueHandling,
#if DEBUG
                Formatting = Formatting.Indented
#else
                Formatting = Formatting.None
#endif
            });
        }
    }
}