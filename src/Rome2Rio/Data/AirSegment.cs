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
    public class AirSegment : Segment {
        [XmlElement(ResponseElementNaming.outbound, typeof(IEnumerable<AirLeg>))]
        [JsonProperty(ResponseElementNaming.outbound)]
        public IEnumerable<AirLeg> Outbound {
            get;set;
        }

        [XmlElement(ResponseElementNaming.@return, typeof(IEnumerable<AirLeg>))]
        [JsonProperty(ResponseElementNaming.@return)]
        public IEnumerable<AirLeg> Return {
            get; set;
        }
    }
}
