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
    public class AirHop {
        [XmlElement(ResponseElementNaming.depPlace, typeof(int))]
        [JsonProperty(ResponseElementNaming.depPlace)]
        public int DeparturePlace {
            get; set;
        }

        [XmlElement(ResponseElementNaming.arrPlace, typeof(int))]
        [JsonProperty(ResponseElementNaming.arrPlace)]
        public int ArrivalPlace {
            get; set;
        }

        [XmlElement(ResponseElementNaming.depTerminal, typeof(string))]
        [JsonProperty(ResponseElementNaming.depTerminal)]
        public string DepartureTerminal {
            get; set;
        }

        [XmlElement(ResponseElementNaming.arrTerminal, typeof(string))]
        [JsonProperty(ResponseElementNaming.arrTerminal)]
        public string ArrivalTerminal {
            get; set;
        }

        [XmlElement(ResponseElementNaming.depTime, typeof(string))]
        [JsonProperty(ResponseElementNaming.depTime)]
        public string DepartureTime {
            get; set;
        }

        [XmlElement(ResponseElementNaming.arrTime, typeof(string))]
        [JsonProperty(ResponseElementNaming.arrTime)]
        public string Arrival {
            get; set;
        }

        [XmlElement(ResponseElementNaming.airline, typeof(string))]
        [JsonProperty(ResponseElementNaming.airline)]
        public string Airline {
            get; set;
        }

        [XmlElement(ResponseElementNaming.operatingAirline, typeof(string))]
        [JsonProperty(ResponseElementNaming.operatingAirline)]
        public string OperatingAirline {
            get; set;
        }

        [XmlElement(ResponseElementNaming.flight, typeof(string))]
        [JsonProperty(ResponseElementNaming.flight)]
        public string Flight {
            get; set;
        }

        [XmlElement(ResponseElementNaming.duration, typeof(float))]
        [JsonProperty(ResponseElementNaming.duration)]
        public float Duration {
            get; set;
        }

        [XmlElement(ResponseElementNaming.aircraft, typeof(string))]
        [JsonProperty(ResponseElementNaming.aircraft)]
        public string Aircraft {
            get; set;
        }

        [XmlElement(ResponseElementNaming.dayChange, typeof(int))]
        [JsonProperty(ResponseElementNaming.dayChange)]
        public int DayChange {
            get; set;
        }

        [XmlElement(ResponseElementNaming.layoverDuration, typeof(float))]
        [JsonProperty(ResponseElementNaming.layoverDuration)]
        public float LayoverDuration {
            get; set;
        }

        [XmlElement(ResponseElementNaming.layoverDayChange, typeof(int))]
        [JsonProperty(ResponseElementNaming.layoverDayChange)]
        public int LayoverDayChange {
            get; set;
        }

        [XmlElement(ResponseElementNaming.codeshares, typeof(IEnumerable<AirCodeshare>))]
        [JsonProperty(ResponseElementNaming.codeshares)]
        public IEnumerable<AirCodeshare> Codeshares {
            get; set;
        }
    }
}
