namespace Rome2Rio.Data {

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Xml.Serialization;
    using Newtonsoft.Json;
    using Serialization;


    /// <summary>
    /// 
    /// </summary>
    public class Place {
        [XmlElement(ResponseElementNaming.code, typeof(string))]
        [JsonProperty(ResponseElementNaming.code)]
        public string Code {
            get; set;
        }

        [XmlElement(ResponseElementNaming.countryCode, typeof(string))]
        [JsonProperty(ResponseElementNaming.countryCode)]
        public string CountryCode {
            get; set;
        }

        [XmlElement(ResponseElementNaming.countryName, typeof(string))]
        [JsonProperty(ResponseElementNaming.countryName)]
        public string CountryName {
            get; set;
        }

        [XmlElement(ResponseElementNaming.longName, typeof(string))]
        [JsonProperty(ResponseElementNaming.longName)]
        public string LongName {
            get; set;
        }

        [XmlElement(ResponseElementNaming.kind, typeof(string))]
        [JsonProperty(ResponseElementNaming.kind)]
        public PlaceKind Kind {
            get; set;
        }

        [XmlElement(ResponseElementNaming.lat, typeof(float))]
        [JsonProperty(ResponseElementNaming.lat)]
        public float Latitude {
            get; set;
        }

        [XmlElement(ResponseElementNaming.lng, typeof(float))]
        [JsonProperty(ResponseElementNaming.lng)]
        public float Longitude {
            get; set;
        }

        [XmlElement(ResponseElementNaming.canonicalName, typeof(string))]
        [JsonProperty(ResponseElementNaming.canonicalName)]
        public string CanonicalName {
            get; set;
        }

        [XmlElement(ResponseElementNaming.shortName, typeof(string))]
        [JsonProperty(ResponseElementNaming.shortName)]
        public string ShortName {
            get; set;
        }

        [XmlElement(ResponseElementNaming.rad, typeof(string))]
        [JsonProperty(ResponseElementNaming.rad)]
        public string Radius {
            get; set;
        }

        [XmlElement(ResponseElementNaming.regionCode, typeof(string))]
        [JsonProperty(ResponseElementNaming.regionCode)]
        public string RegionCode {
            get; set;
        }

        [XmlElement(ResponseElementNaming.regionName, typeof(string))]
        [JsonProperty(ResponseElementNaming.regionName)]
        public string RegionName {
            get; set;
        }

        [XmlElement(ResponseElementNaming.timeZone, typeof(string))]
        [JsonProperty(ResponseElementNaming.timeZone)]
        public string TimeZone {
            get; set;
        }
    }
}
