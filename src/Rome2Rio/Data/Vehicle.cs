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
    public class Vehicle {
        [XmlElement(ResponseElementNaming.name, typeof(string))]
        [JsonProperty(ResponseElementNaming.name)]
        public string Name {
            get; set;
        }

        [XmlElement(ResponseElementNaming.kind, typeof(string))]
        [JsonProperty(ResponseElementNaming.kind)]
        public string Kind {
            get; set;
        }
    }
}
