using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Models;
using UltimateTeam.Toolkit.Constants;
using UltimateTeam.Toolkit.Extensions;


namespace UltimateTeam.Toolkit.Requests
{
    internal class ListMessageRequest : FutRequestBase, IFutRequest<ListMessageResponse>
    {
        public async Task<ListMessageResponse> PerformRequestAsync()
        {
            AddCommonHeaders();
            var responseMessage = await HttpClient
                .GetAsync(Resources.FutHome + Resources.LiveMessageList + $"&_={DateTime.Now.ToUnixTime()}")
                .ConfigureAwait(false);

            return await DeserializeAsync<ListMessageResponse>(responseMessage);

        }
    }
}
