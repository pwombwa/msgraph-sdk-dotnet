namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class BatchRequest
    {
        public BatchRequest()
        {
            RequestItems = new List<BatchRequestItem>();
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requests", Required = Required.Default)]
        public ICollection<BatchRequestItem> RequestItems { get; set; }
    }
}
