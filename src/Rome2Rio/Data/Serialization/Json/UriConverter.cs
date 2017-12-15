using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Reflection;

namespace Rome2Rio.Data.Serialization.Json {
    public class UriConverter : JsonConverter {
        public override bool CanConvert(Type objectType) {
            return typeof(Uri)
                .GetTypeInfo()
                .IsAssignableFrom(objectType.GetTypeInfo());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            if(reader.TokenType == JsonToken.String && !String.IsNullOrWhiteSpace(reader.Value as string)) {
                if(Uri.IsWellFormedUriString(reader.Value as string, UriKind.RelativeOrAbsolute)) {
                    return new Uri(reader.Value as string, UriKind.RelativeOrAbsolute);
                }
            }

            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            throw new NotImplementedException();
        }
    }
}
