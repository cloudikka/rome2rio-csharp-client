using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rome2Rio.Data.Serialization.Json {
    public class PositionConverter : JsonConverter {
        public static Type allowedType = typeof(Position);
        public override bool CanConvert(Type objectType) {
            return objectType == allowedType;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) {
            if(reader.TokenType == JsonToken.String && !String.IsNullOrWhiteSpace(reader.Value as string)) {
                var array = (reader.Value as string).Split(',');

                var result = new Position {
                    Latitude = Convert.ToDouble(array[0]),
                    Longitude = Convert.ToDouble(array[1])
                };

                return result;
            }

            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            throw new NotImplementedException();
        }
    }
}
