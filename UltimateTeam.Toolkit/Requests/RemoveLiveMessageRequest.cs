using System;
using System.Net.Http;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Constants;
using UltimateTeam.Toolkit.Extensions;
using UltimateTeam.Toolkit.Models;

namespace UltimateTeam.Toolkit.Requests
{
    internal class RemoveLiveMessageRequest : FutRequestBase, IFutRequest<byte>
    {
        private readonly long _id;

        public RemoveLiveMessageRequest(long id)
        {
            _id = id;
        }

        public async Task<byte> PerformRequestAsync()
        {
            var uriString = Resources.FutHome + Resources.LiveMessagePut;

            AddCommonHeaders();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, uriString);
            request.Content = new StringContent($"{{\"idList\":[{_id}]}}", System.Text.Encoding.UTF8, "application/json");

            Task<HttpResponseMessage> messageTask = HttpClient.SendAsync(request);
            var message = await messageTask.ConfigureAwait(false);
            message.EnsureSuccessStatusCode();

            return 0;

        }
    }
}
