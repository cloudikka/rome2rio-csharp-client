using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rome2Rio.Data.Serialization.Json {
    public class SegmentKindConverter : JsonConverter {
        public override bool CanConvert(Type objectType) {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            if(reader.TokenType == JsonToken.String && objectType == typeof(SegmentKind)) {
                var value = reader.Value as string;

                SegmentKind result;

                if(Enum.TryParse<SegmentKind>(value, true, out result)) {
                    return result;
                }
            }

            throw new InvalidOperationException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            throw new NotImplementedException();
        }
    }
}
