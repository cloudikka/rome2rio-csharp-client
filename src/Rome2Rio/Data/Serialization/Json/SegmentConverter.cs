using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Newtonsoft.Json.Linq;

namespace Rome2Rio.Data.Serialization.Json {
    public class SegmentConverter : AbstractJsonConverter<Segment> {
        public override bool CanConvert(Type objectType) {
            if(objectType.GetTypeInfo().IsAssignableFrom(typeof(Segment).GetTypeInfo())) {
                return true;
            }

            return false;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            throw new NotImplementedException();
        }

        protected override Segment Create(Type objectType, JObject jObject) {
            var value = GetDiscriminator<string>(jObject, ResponseElementNaming.segmentKind, JTokenType.String);

            SegmentKind kind;

            if(Enum.TryParse<SegmentKind>(value, true, out kind)) {
                switch(kind) {
                    case  SegmentKind.Air:
                        return new AirSegment();
                    case SegmentKind.Surface:
                        return new SurfaceSegment();
                    default:
                        throw new InvalidOperationException();
                }
            }

            throw new InvalidOperationException();
        }

    }
}
