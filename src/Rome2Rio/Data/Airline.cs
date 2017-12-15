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
    public class Airline {
        [XmlElement(ResponseElementNaming.code, typeof(string))]
        [JsonProperty(ResponseElementNaming.code)]
        public string Code {
            get; set;
        }

        [XmlElement(ResponseElementNaming.name, typeof(string))]
        [JsonProperty(ResponseElementNaming.name)]
        public string Name {
            get; set;
        }

        [XmlElement(ResponseElementNaming.url, typeof(Uri))]
        [JsonProperty(ResponseElementNaming.url)]
        [JsonConverter(typeof(UriConverter))]
        public Uri Url {
            get; set;
        }

        [XmlElement(ResponseElementNaming.icon, typeof(Icon))]
        [JsonProperty(ResponseElementNaming.icon)]
        public Icon Icon {
            get; set;
        }
    }
}
