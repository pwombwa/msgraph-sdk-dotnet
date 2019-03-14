namespace Microsoft.Graph.DotnetCore.Test.Requests.Functional
{
    using System;
    using Xunit;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    public class BatchRequestTests : GraphTestBase
    {
        [Fact]
        public async Task BatchRequestPostAsync()
        {
            // STEP 1: Get individual request
            BatchRequestItem request1 = graphClient.Me.Request().BatchGet();
            BatchRequestItem request2 = graphClient.Me.Messages.Request().BatchGet();

            // STEP 2: Specify dependencies, or lack thereof
            BatchRequestContext batchRequestContext = new BatchRequestContext();
            batchRequestContext.AddRequest(1, request1, null);
            batchRequestContext.AddRequest(2, request2, null);

            // STEP 3: Execute batch request
            BatchResponse batchResponse = await graphClient.Batch().PostAsync(batchRequestContext);
        }
    }
}
