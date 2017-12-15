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
    public class Aircraft {
        [XmlElement(ResponseElementNaming.code, typeof(string))]
        [JsonProperty(ResponseElementNaming.code)]
        public string Code {
            get; set;
        }

        [XmlElement(ResponseElementNaming.manufacturer, typeof(string))]
        [JsonProperty(ResponseElementNaming.manufacturer)]
        public string Manufacturer {
            get; set;
        }

        [XmlElement(ResponseElementNaming.model, typeof(string))]
        [JsonProperty(ResponseElementNaming.model)]
        public string Model {
            get; set;
        }
    }
}
