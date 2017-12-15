using Newtonsoft.Json;
using Rome2Rio.Data.Serialization;
using Rome2Rio.Data.Serialization.Json;
using System.Xml.Serialization;

namespace Rome2Rio.Data {
    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(PositionConverter))]
    public class Position {
        [XmlElement(ResponseElementNaming.lat, typeof(double))]
        [JsonProperty(ResponseElementNaming.lat)]
        public double Latitude {
            get; set;
        }

        [XmlElement(ResponseElementNaming.lng, typeof(double))]
        [JsonProperty(ResponseElementNaming.lng)]
        public double Longitude {
            get; set;
        }

        public override string ToString() {
            return this.Latitude + "," + this.Longitude;
        }
    }
}