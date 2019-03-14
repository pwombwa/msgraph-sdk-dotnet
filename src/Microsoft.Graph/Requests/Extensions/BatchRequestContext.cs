using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Graph
{
    public class BatchRequestContext
    {
        public BatchRequest BatchRequest { get; private set; }
        public BatchRequestContext()
        {
            BatchRequest = new BatchRequest();
        }

        public void AddRequest(int id, BatchRequestItem batchRequest, int[] dependsOn)
        {
            batchRequest.Id = id;
            batchRequest.DependsOn = dependsOn;

            BatchRequest.RequestItems.Add(batchRequest);
        }
    }
}
