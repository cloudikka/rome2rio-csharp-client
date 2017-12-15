namespace Rome2Rio.Data {
    using Newtonsoft.Json;
    using Serialization;
    using Serialization.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(SegmentConverter))]
    public abstract class Segment {
        [XmlElement(ResponseElementNaming.segmentKind, typeof(SegmentKind))]
        [JsonProperty(ResponseElementNaming.segmentKind)]
        public SegmentKind Kind {
            get; set;
        }

        [XmlElement(ResponseElementNaming.depPlace, typeof(string))]
        [JsonProperty(ResponseElementNaming.depPlace)]
        public int Departure {
            get; set;
        }

        [XmlElement(ResponseElementNaming.arrPlace, typeof(string))]
        [JsonProperty(ResponseElementNaming.arrPlace)]
        public string Arrival {
            get; set;
        }

        [XmlElement(ResponseElementNaming.vehicle, typeof(int))]
        [JsonProperty(ResponseElementNaming.vehicle)]
        public int Vehicle {
            get; set;
        }

        [XmlElement(ResponseElementNaming.distance, typeof(float))]
        [JsonProperty(ResponseElementNaming.distance)]
        public float Distance {
            get; set;
        }

        [XmlElement(ResponseElementNaming.transitDuration, typeof(float))]
        [JsonProperty(ResponseElementNaming.transitDuration)]
        public float TransitDuration {
            get; set;
        }

        [XmlElement(ResponseElementNaming.transferDuration, typeof(float))]
        [JsonProperty(ResponseElementNaming.transferDuration)]
        public float TransferDuration {
            get; set;
        }

        [XmlElement(ResponseElementNaming.indicativePrice, typeof(IndicativePrice))]
        [JsonProperty(ResponseElementNaming.indicativePrice)]
        public IndicativePrice IndicativePrice {
            get; set;
        }
    }
}
