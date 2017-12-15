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
    public class IndicativePrice {
        [XmlElement(ResponseElementNaming.name, typeof(string))]
        [JsonProperty(ResponseElementNaming.name)]
        public string Name {
            get; set;
        }

        [XmlElement(ResponseElementNaming.price, typeof(float))]
        [JsonProperty(ResponseElementNaming.price)]
        public float Price {
            get; set;
        }

        [XmlElement(ResponseElementNaming.priceLow, typeof(float))]
        [JsonProperty(ResponseElementNaming.priceLow)]
        public float PriceLow {
            get; set;
        }

        [XmlElement(ResponseElementNaming.priceHigh, typeof(float))]
        [JsonProperty(ResponseElementNaming.priceHigh)]
        public float PriceHigh {
            get; set;
        }

        [XmlElement(ResponseElementNaming.currency, typeof(string))]
        [JsonProperty(ResponseElementNaming.currency)]
        public string Currency {
            get; set;
        }

        [XmlElement(ResponseElementNaming.nativePrice, typeof(float))]
        [JsonProperty(ResponseElementNaming.nativePrice)]
        public float NativePrice {
            get; set;
        }
        [XmlElement(ResponseElementNaming.nativePriceLow, typeof(float))]
        [JsonProperty(ResponseElementNaming.nativePriceLow)]
        public float NativePriceLow {
            get; set;
        }
        [XmlElement(ResponseElementNaming.nativePriceHigh, typeof(float))]
        [JsonProperty(ResponseElementNaming.nativePriceHigh)]
        public float NativePriceHigh {
            get; set;
        }

        [XmlElement(ResponseElementNaming.nativeCurrency, typeof(string))]
        [JsonProperty(ResponseElementNaming.nativeCurrency)]
        public string NativeCurrency {
            get; set;
        }
    }
}
