using System.Collections.Generic;

namespace Microsoft.Graph
{
    public static class IBaseRequestExtensions
    {
        public static BatchRequestItem BatchCreate<T>(this T baseRequest, object item) where T : IBaseRequest
        {
            GetRelativeUrl(baseRequest);
            return new BatchRequestItem
            {
                Body = item,
                Url = GetRelativeUrl(baseRequest),
                Headers = new Dictionary<string, string>() { { "Content-Type", "application/json" } },
                Method = "POST",
            };
        }

        public static BatchRequestItem BatchGet<T>(this T baseRequest) where T : IBaseRequest
        {
            GetRelativeUrl(baseRequest);
            return new BatchRequestItem
            {
                Url = GetRelativeUrl(baseRequest),
                Method = "GET"
            };
        }

        public static BatchRequestItem BatchDelete<T>(this T baseRequest) where T : IBaseRequest
        {
            return new BatchRequestItem
            {
                Url = GetRelativeUrl(baseRequest),
                Method = "DELETE",
            };
        }

        public static BatchRequestItem BatchUpdate<T>(this T baseRequest, object item) where T : IBaseRequest
        {
            return new BatchRequestItem
            {
                Body = item,
                Url = GetRelativeUrl(baseRequest),
                Headers = new Dictionary<string, string>() { { "Content-Type", "application/json" } },
                Method = "PATCH",
            };
        }

        private static string GetRelativeUrl(IBaseRequest baseRequest)
        {
            string version = "v1.0";
            if (baseRequest.RequestUrl.Contains("beta"))
                version = "beta";

            return baseRequest.RequestUrl.Substring(baseRequest.RequestUrl.IndexOf(version) + version.ToCharArray().Length);
        }
    }
}
