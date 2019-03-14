using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Graph
{
    public static class IGraphServiceClientExtensions
    {
        public static BatchRequestBuilder Batch(this IGraphServiceClient graphServiceClient)
        {
            return new BatchRequestBuilder(graphServiceClient);
        }
    }

}
