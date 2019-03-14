using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Graph
{
    public class BatchResponse
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "responses", Required = Required.Default)]
        public ICollection<BatchResponseItem> Responses { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.nextLink", Required = Required.Default)]
        public string NextLink { get; set; }
    }
}
