using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Rome2Rio.Data;
using Rome2Rio.Data.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rome2Rio.Responses {
    public class SearchResponse {
        [XmlElement(ResponseElementNaming.elapsedTime, typeof(string))]
        [JsonProperty(ResponseElementNaming.elapsedTime)]
        public string ElapsedTime {
            get; set;
        }

        [XmlElement(ResponseElementNaming.currencyCode, typeof(string))]
        [JsonProperty(ResponseElementNaming.currencyCode)]
        public string CurrencyCode {
            get; set;
        }

        [XmlElement(ResponseElementNaming.languageCode, typeof(string))]
        [JsonProperty(ResponseElementNaming.languageCode)]
        public string LanguageCode {
            get; set;
        }
        
        [XmlElement(ResponseElementNaming.data, typeof(string))]
        [JsonProperty(ResponseElementNaming.data)]
        public string Data {
            get; set;
        }

        [XmlElement(ResponseElementNaming.places, typeof(IEnumerable<Place>))]
        [JsonProperty(ResponseElementNaming.places)]
        public IEnumerable<Place> Places {
            get; set;
        }

        [XmlElement(ResponseElementNaming.airlines, typeof(IEnumerable<Airline>))]
        [JsonProperty(ResponseElementNaming.airlines)]
        public IEnumerable<Airline> Airlines {
            get; set;
        }


        [XmlElement(ResponseElementNaming.aircrafts, typeof(IEnumerable<Aircraft>))]
        [JsonProperty(ResponseElementNaming.aircrafts)]
        public IEnumerable<Aircraft> Aircrafts {
            get; set;
        }


        [XmlElement(ResponseElementNaming.agencies, typeof(IEnumerable<Agency>))]
        [JsonProperty(ResponseElementNaming.agencies)]
        public IEnumerable<Agency> Agencies {
            get; set;
        }

        [XmlElement(ResponseElementNaming.vehicles, typeof(IEnumerable<Vehicle>))]
        [JsonProperty(ResponseElementNaming.vehicles)]
        public IEnumerable<Vehicle> Vehicles {
            get; set;
        }

        [XmlElement(ResponseElementNaming.routes, typeof(IEnumerable<Route>))]
        [JsonProperty(ResponseElementNaming.routes)]
        public IEnumerable<Route> Routes {
            get; set;
        }       
    }
}
