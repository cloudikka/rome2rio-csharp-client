using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rome2Rio.Data.Serialization.Json {
    public class PathConverter : JsonConverter {
        public static Type allowedType = typeof(IEnumerable<Position>);
        public override bool CanConvert(Type objectType) {
            return objectType == allowedType;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            if(reader.TokenType == JsonToken.String && !String.IsNullOrWhiteSpace(reader.Value as string)) {
                return EncodedPolylineAlgorithm.Decode(reader.Value as string);
            }

            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            throw new NotImplementedException();
        }
    }
}
