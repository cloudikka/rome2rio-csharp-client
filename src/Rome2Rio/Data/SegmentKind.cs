using Newtonsoft.Json;
using Rome2Rio.Data.Serialization.Json;

namespace Rome2Rio.Data {
    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(SegmentKindConverter))]
    public enum SegmentKind {
        Unknown = 0,
        Surface = 1,
        Air = 2
    }
}