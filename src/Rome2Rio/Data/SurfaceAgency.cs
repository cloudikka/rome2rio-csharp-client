namespace Rome2Rio.Data {

    using Newtonsoft.Json;
    using Rome2Rio.Data.Serialization;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    /// <summary>
    /// 
    /// </summary>
    public class SurfaceAgency : Agency {
        [XmlElement(ResponseElementNaming.agency, typeof(int))]
        [JsonProperty(ResponseElementNaming.agency)]
        public int Agency {
            get; set;
        }

        [XmlElement(ResponseElementNaming.frequency, typeof(float))]
        [JsonProperty(ResponseElementNaming.frequency)]
        public float Frequency {
            get; set;
        }

        [XmlElement(ResponseElementNaming.duration, typeof(float))]
        [JsonProperty(ResponseElementNaming.duration)]
        public float Duration {
            get; set;
        }

        [XmlElement(ResponseElementNaming.operatingDays, typeof(Days))]
        [JsonProperty(ResponseElementNaming.operatingDays)]
        public Days OperatingDays {
            get; set;
        }

        [XmlElement(ResponseElementNaming.lineNames, typeof(IEnumerable<string>))]
        [JsonProperty(ResponseElementNaming.lineNames)]
        public IEnumerable<string> LineNames {
            get; set;
        }

        [XmlElement(ResponseElementNaming.lineCodes, typeof(IEnumerable<string>))]
        [JsonProperty(ResponseElementNaming.lineCodes)]
        public IEnumerable<string> LineCodes {
            get; set;
        }

        [XmlElement(ResponseElementNaming.links, typeof(IEnumerable<ExternalLink>))]
        [JsonProperty(ResponseElementNaming.links)]
        public IEnumerable<ExternalLink> Links {
            get; set;
        }
    }
}
