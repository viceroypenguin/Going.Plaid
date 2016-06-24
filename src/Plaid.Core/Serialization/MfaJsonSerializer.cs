using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Gigobyte.Plaid.Serialization
{
    /// <summary>
    /// Converts json into a <see cref="Contract.Mfa"/> object.
    /// </summary>
    /// <seealso cref="Newtonsoft.Json.JsonConverter"/>
    public class MfaJsonSerializer : JsonConverter
    {
        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        /// <c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.
        /// </returns>
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="T:Newtonsoft.Json.JsonReader"/> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var mfa = new Contract.Mfa();

            var json = JToken.Load(reader);
            switch (json["mfa"].Type)
            {
                case JTokenType.Array:

                    break;

                case JTokenType.Object:
                    break;
            }

            return mfa;
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="T:Newtonsoft.Json.JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}