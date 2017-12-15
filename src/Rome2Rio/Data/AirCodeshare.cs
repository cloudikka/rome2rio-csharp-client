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
    public class AirCodeshare {
        [XmlElement(ResponseElementNaming.operatingAirline, typeof(string))]
        [JsonProperty(ResponseElementNaming.operatingAirline)]
        public string Airline {
            get; set;
        }

        [XmlElement(ResponseElementNaming.flight, typeof(string))]
        [JsonProperty(ResponseElementNaming.flight)]
        public string Flight {
            get; set;
        }
    }
}
