namespace Rome2Rio.Data {

    using Newtonsoft.Json;
    using Serialization;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    /// <summary>
    /// 
    /// </summary>
    public class Route {
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

        [XmlElement(ResponseElementNaming.distance, typeof(float))]
        [JsonProperty(ResponseElementNaming.distance)]
        public float Distance {
            get; set;
        }

        [XmlElement(ResponseElementNaming.totalDuration, typeof(float))]
        [JsonProperty(ResponseElementNaming.totalDuration)]
        public float TotalDuration {
            get; set;
        }

        [XmlElement(ResponseElementNaming.totalTransitDuration, typeof(float))]
        [JsonProperty(ResponseElementNaming.totalTransitDuration)]
        public float TotalTransitDuration {
            get; set;
        }

        [XmlElement(ResponseElementNaming.totalTransferDuration, typeof(float))]
        [JsonProperty(ResponseElementNaming.totalTransferDuration)]
        public float TotalTransferDuration {
            get; set;
        }

        [XmlElement(ResponseElementNaming.name, typeof(string))]
        [JsonProperty(ResponseElementNaming.name)]
        public string Name {
            get; set;
        }

        [XmlElement(ResponseElementNaming.indicativePrices, typeof(IEnumerable<IndicativePrice>))]
        [JsonProperty(ResponseElementNaming.indicativePrices)]
        public IEnumerable<IndicativePrice> IndicativePrices {
            get; set;
        }

        [XmlElement(ResponseElementNaming.segments, typeof(IEnumerable<Segment>))]
        [JsonProperty(ResponseElementNaming.segments)]
        public IEnumerable<Segment> Segments {
            get; set;
        }

        [XmlElement(ResponseElementNaming.alternatives, typeof(IEnumerable<Alternative>))]
        [JsonProperty(ResponseElementNaming.alternatives)]
        public IEnumerable<Alternative> Alternatives {
            get; set;
        }
    }
}
