using Newtonsoft.Json;
using Rome2Rio.Data;
using Rome2Rio.Data.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Rome2Rio.Responses {
    public class AutocompleteResponse {
        [XmlElement(ResponseElementNaming.query, typeof(string))]
        [JsonProperty(ResponseElementNaming.query)]
        public string Term {
            get; set;
        }

        [XmlElement(ResponseElementNaming.countryCode, typeof(string))]
        [JsonProperty(ResponseElementNaming.countryCode)]
        public string CountryCode {
            get; set;
        }

        [XmlElement(ResponseElementNaming.languageCode, typeof(string))]
        [JsonProperty(ResponseElementNaming.languageCode)]
        public string LanguageCode {
            get; set;
        }


        [XmlElement(ResponseElementNaming.places, typeof(IEnumerable<Place>))]
        [JsonProperty(ResponseElementNaming.places)]
        public IEnumerable<Place> Places {
            get; set;
        }
    }
}
