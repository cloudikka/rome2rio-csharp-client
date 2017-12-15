using Newtonsoft.Json;
using Rome2Rio.Data.Serialization;
using Rome2Rio.Data.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rome2Rio.Data {
    /// <summary>
    /// 
    /// </summary>
    public class ExternalLink {
        [XmlElement(ResponseElementNaming.text, typeof(string))]
        [JsonProperty(ResponseElementNaming.text)]
        public string Text {
            get; set;
        }

        [XmlElement(ResponseElementNaming.url, typeof(Uri))]
        [JsonProperty(ResponseElementNaming.url)]
        [JsonConverter(typeof(UriConverter))]
        public Uri Url {
            get; set;
        }

        [XmlElement(ResponseElementNaming.displayUrl, typeof(Uri))]
        [JsonProperty(ResponseElementNaming.displayUrl)]
        [JsonConverter(typeof(UriConverter))]
        public Uri DisplayUrl {
            get; set;
        }

        [XmlElement(ResponseElementNaming.moustacheUrl, typeof(Uri))]
        [JsonProperty(ResponseElementNaming.moustacheUrl)]
        [JsonConverter(typeof(UriConverter))]
        public Uri MoustacheUrl {
            get; set;
        }
    }
}
