using Newtonsoft.Json;

namespace Microsoft.Graph
{
    public class BatchResponseItem: BaseBatchItem
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Required.Default)]
        public int Status { get; set; }
    }
}