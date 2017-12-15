namespace Rome2Rio {
    using Data;
    using Data.Serialization;
    using Newtonsoft.Json;
    using Responses;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;

    public class Rome2RioClient {
        private static string Version = "1.4";
        private static ContentType DefaultContentType = ContentType.JSON;
        private HttpClient _HttpClient = new HttpClient();

        public Rome2RioClient(string server, string apiKey, ContentType contentType) {
            if(String.IsNullOrWhiteSpace(apiKey)) {
                throw new ArgumentException(ErrorMessageResource.ArgumentCannotBeNullEmptyOrWhitespace, nameof(apiKey));
            }

            if(String.IsNullOrWhiteSpace(server)) {
                throw new ArgumentException(ErrorMessageResource.ArgumentCannotBeNullEmptyOrWhitespace, nameof(apiKey));
            }

            this.Server = server;
            this.ApiKey = apiKey;
            this.ContentType = contentType == ContentType.Default ? DefaultContentType : contentType;

            var baseUriString = $"http://{this.Server}/api/{Version}/{this.ContentType.ToString().ToLowerInvariant()}/";

            Uri baseUri;

            if(!Uri.TryCreate(baseUriString, UriKind.Absolute, out baseUri)) {
                throw new InvalidOperationException(ErrorMessageResource.UnableToCreateBaseAddress);
            }

            this._HttpClient.BaseAddress = baseUri;
        }

        public string ApiKey {
            get;
            private set;
        }
        public string Server {
            get;
            private set;
        }
        public ContentType ContentType {
            get;
            private set;
        }

        public async Task<SearchResponse> SearchAsync(string originName, string destinationName, Position originPosition, Position destinationPosition, PlaceKind originKind, PlaceKind destinationKind, string currencyCode, string languageCode, SearchOptions options, string customResponseData) {
            var queryParameters = this.CreateQueryParameters(originName, destinationName, originPosition, destinationPosition, originKind, destinationKind, currencyCode, languageCode, options, customResponseData);
            var relativeUri = this.CreateUri("Search", queryParameters);
            return await GetAsync<SearchResponse>(relativeUri);
        }

        public async Task<AutocompleteResponse> AutocompleteAsync(string term, string currencyCode, string languageCode) {
            var queryParameters = this.CreateUriQueryParameters(term, currencyCode, languageCode);
            var relativeUri = this.CreateUri("Autocomplete", queryParameters);
            return await GetAsync<AutocompleteResponse>(relativeUri);
        }

        public async Task<GeocodeResponse> GeocodeAsync(string term, string currencyCode, string languageCode) {
            var queryParameters = this.CreateUriQueryParameters(term, currencyCode, languageCode);
            var relativeUri = this.CreateUri("Geocode", queryParameters);
            return await GetAsync<GeocodeResponse>(relativeUri);
        }

        private IDictionary<string, string> CreateQueryParameters(string originName, string destinationName, Position originPosition, Position destinationPosition, PlaceKind originKind, PlaceKind destinationKind, string currencyCode, string languageCode, SearchOptions options, string customResponseData) {
            var parameters = new Dictionary<string, string>();

            parameters.Add(RequestElementNaming.oName, originName);
            parameters.Add(RequestElementNaming.dName, destinationName);
            parameters.Add(RequestElementNaming.oPos, originPosition?.ToString());
            parameters.Add(RequestElementNaming.dPos, destinationPosition?.ToString());
            parameters.Add(RequestElementNaming.oKind, originKind.ToString());
            parameters.Add(RequestElementNaming.dKind, destinationKind.ToString());
            parameters.Add(RequestElementNaming.currencyCode, currencyCode);
            parameters.Add(RequestElementNaming.languageCode, languageCode);
            parameters.Add(RequestElementNaming.data, customResponseData);

            if(options.HasFlag(SearchOptions.NoAirLegs)) {
                parameters.Add(RequestElementNaming.noAirLeg, String.Empty);
            }

            if(options.HasFlag(SearchOptions.NoAirSegments)) {
                parameters.Add(RequestElementNaming.noAir, String.Empty);
            }

            if(options.HasFlag(SearchOptions.NoBikeshare)) {
                parameters.Add(RequestElementNaming.noBikeshare, String.Empty);
            }

            if(options.HasFlag(SearchOptions.NoBus)) {
                parameters.Add(RequestElementNaming.noBus, String.Empty);
            }

            if(options.HasFlag(SearchOptions.NoCar)) {
                parameters.Add(RequestElementNaming.noCar, String.Empty);
            }

            if(options.HasFlag(SearchOptions.NoCommuter)) {
                parameters.Add(RequestElementNaming.noCommuter, String.Empty);
            }

            if(options.HasFlag(SearchOptions.NoFerry)) {
                parameters.Add(RequestElementNaming.noFerry, String.Empty);
            }

            if(options.HasFlag(SearchOptions.NoMinorEnd)) {
                parameters.Add(RequestElementNaming.noMinorEnd, String.Empty);
            }

            if(options.HasFlag(SearchOptions.NoMinorStart)) {
                parameters.Add(RequestElementNaming.noMinorStart, String.Empty);
            }

            if(options.HasFlag(SearchOptions.NoPath)) {
                parameters.Add(RequestElementNaming.noPath, String.Empty);
            }

            if(options.HasFlag(SearchOptions.NoPrice)) {
                parameters.Add(RequestElementNaming.noPrice, String.Empty);
            }

            if(options.HasFlag(SearchOptions.NoRail)) {
                parameters.Add(RequestElementNaming.noRail, String.Empty);
            }

            if(options.HasFlag(SearchOptions.NoRideshare)) {
                parameters.Add(RequestElementNaming.noRideshare, String.Empty);
            }

            if(options.HasFlag(SearchOptions.NoSpecial)) {
                parameters.Add(RequestElementNaming.noSpecial, String.Empty);
            }

            if(options.HasFlag(SearchOptions.NoTowncar)) {
                parameters.Add(RequestElementNaming.noTowncar, String.Empty);
            }

            return parameters;
        }

        private IDictionary<string, string> CreateUriQueryParameters(string term, string currencyCode, string languageCode) {
            var parameters = new Dictionary<string, string>();

            parameters.Add(RequestElementNaming.query, term);
            parameters.Add(RequestElementNaming.currencyCode, currencyCode);
            parameters.Add(RequestElementNaming.languageCode, languageCode);

            return parameters;
        }

        private Uri CreateUri(string actionName, IDictionary<string, string> values) {
            if(values == null) {
                throw new ArgumentNullException(nameof(values));
            }

            var sb = new StringBuilder($"{actionName}?{RequestElementNaming.key}={this.ApiKey}");

            foreach(var value in values.Where(kvp => !String.IsNullOrWhiteSpace(kvp.Key) && kvp.Value != null)) {
                sb.Append($"&{value.Key}");
                if(!String.IsNullOrWhiteSpace(value.Value)) {
                    sb.Append($"={value.Value}");
                }
            }

            return new Uri(sb.ToString(), UriKind.Relative);
        }

        private async Task<T> GetAsync<T>(Uri relativeUri) {
            var response = await this._HttpClient.GetAsync(relativeUri);

            response.EnsureSuccessStatusCode();

            try {
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<T>(content);
                return result;
            } catch(Exception e) {
                Debug.WriteLine(e.Message);
                throw;
            }
        }
    }
}
