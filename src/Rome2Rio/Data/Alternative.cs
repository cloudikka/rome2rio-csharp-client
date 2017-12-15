namespace Rome2Rio.Data {

    using Newtonsoft.Json;
    using Rome2Rio.Data.Serialization;
    using System.Xml.Serialization;

    /// <summary>
    /// 
    /// </summary>
    public class Alternative {
        [XmlElement(ResponseElementNaming.firstSegment, typeof(int))]
        [JsonProperty(ResponseElementNaming.firstSegment)]
        public int FirstSegment {
            get; set;
        }

        [XmlElement(ResponseElementNaming.lastSegment, typeof(int))]
        [JsonProperty(ResponseElementNaming.lastSegment)]
        public int LastSegment {
            get; set;
        }

        [XmlElement(ResponseElementNaming.route, typeof(Route))]
        [JsonProperty(ResponseElementNaming.route)]
        public Route Route {
            get; set;
        }
    }
}