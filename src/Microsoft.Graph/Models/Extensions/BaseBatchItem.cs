namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class BaseBatchItem
    {
        public BaseBatchItem()
        {
            Headers = new Dictionary<string, string>();
        }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "id", Required = Required.Default)]
        public int Id { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "body", Required = Required.Default)]
        public object Body { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "headers", Required = Required.Default)]
        public Dictionary<string, string> Headers { get; set; }
    }
}
