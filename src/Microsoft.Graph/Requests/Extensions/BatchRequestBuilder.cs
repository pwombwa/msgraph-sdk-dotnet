namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class BatchRequestBuilder
    {
        private IBaseClient _client;

        public BatchRequestBuilder(IBaseClient client)
        {
            _client = client;
        }

        public async Task<BatchResponse> PostAsync(BatchRequestContext batchRequest)
        {
            BaseRequest request = new BaseRequest(_client.BaseUrl + "/$batch", _client);
            request.ContentType = "application/json";
            request.Headers.Add(new HeaderOption("Accept", "application/json"));
            request.Method = "POST";

            return await request
                .SendAsync<BatchResponse>(batchRequest.BatchRequest, CancellationToken.None)
                .ConfigureAwait(false);
        }
    }
}
