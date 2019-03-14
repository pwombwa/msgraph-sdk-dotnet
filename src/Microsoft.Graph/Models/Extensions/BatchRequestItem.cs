using System;
namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Text;
    public class BatchRequestItem : BaseBatchItem
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "url", Required = Required.Default)]
        public string Url { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "method", Required = Required.Default)]
        public string Method { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dependsOn", Required = Required.Default)]
        public int[] DependsOn { get; set; }
    }
}
