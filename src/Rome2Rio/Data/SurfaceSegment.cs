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
    public class SurfaceSegment : Segment {
        [XmlElement(ResponseElementNaming.path, typeof(IEnumerable<Position>))]
        [JsonProperty(ResponseElementNaming.path)]
        [JsonConverter(typeof(PathConverter))]
        public IEnumerable<Position> Path {
            get; set;
        }

        [XmlElement(ResponseElementNaming.agencies, typeof(IEnumerable<Agency>))]
        [JsonProperty(ResponseElementNaming.agencies)]
        public IEnumerable<SurfaceAgency> Agencies {
            get; set;
        }
    }
}
