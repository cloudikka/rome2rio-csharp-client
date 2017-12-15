namespace Rome2Rio.Data.Serialization.Json {

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Reflection;

    public abstract class AbstractJsonConverter<T> : JsonConverter {
        protected abstract T Create(Type objectType, JObject jObject);

        public override bool CanConvert(Type objectType) {
            return typeof(T).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            var jObject = JObject.Load(reader);

            T target = Create(objectType, jObject);
            serializer.Populate(jObject.CreateReader(), target);

            return target;
        }

        protected static TDiscriminator GetDiscriminator<TDiscriminator>(JObject jObject, string name, JTokenType type) {
            JToken token;

            if(jObject.TryGetValue(name, out token) && token.Type == type) {
                return token.Value<TDiscriminator>();
            }

            return default(TDiscriminator);
        }
    }

}
