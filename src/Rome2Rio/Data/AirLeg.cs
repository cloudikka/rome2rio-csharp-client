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
    public class AirLeg {
        [XmlElement(ResponseElementNaming.days, typeof(Days))]
        [JsonProperty(ResponseElementNaming.days)]
        public Days Days {
            get; set;
        }

        [XmlElement(ResponseElementNaming.hops, typeof(IEnumerable<AirHop>))]
        [JsonProperty(ResponseElementNaming.hops)]
        public IEnumerable<AirHop> Hops {
            get;set;
        }
    }
}
