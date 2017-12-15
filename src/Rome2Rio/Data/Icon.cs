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
    public class Icon {
        [XmlElement(ResponseElementNaming.url, typeof(Uri))]
        [JsonProperty(ResponseElementNaming.url)]
        [JsonConverter(typeof(UriConverter))]
        public Uri Url {
            get; set;
        }

        [XmlElement(ResponseElementNaming.x, typeof(int))]
        [JsonProperty(ResponseElementNaming.x)]
        public int X {
            get; set;
        }

        [XmlElement(ResponseElementNaming.y, typeof(int))]
        [JsonProperty(ResponseElementNaming.y)]
        public int Y {
            get; set;
        }

        [XmlElement(ResponseElementNaming.w, typeof(int))]
        [JsonProperty(ResponseElementNaming.w)]
        public int Width {
            get; set;
        }

        [XmlElement(ResponseElementNaming.h, typeof(int))]
        [JsonProperty(ResponseElementNaming.h)]
        public int Height {
            get; set;
        }
    }
}
