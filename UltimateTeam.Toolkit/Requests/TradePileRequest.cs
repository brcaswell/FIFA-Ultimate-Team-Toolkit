using System;
using System.Net.Http;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Constants;
using UltimateTeam.Toolkit.Extensions;
using UltimateTeam.Toolkit.Models;

namespace UltimateTeam.Toolkit.Requests
{
    internal class TradePileRequest : FutRequestBase, IFutRequest<AuctionResponse>
    {
        public async Task<AuctionResponse> PerformRequestAsync()
        {
            var uriString = Resources.FutHome + Resources.TradePile;

            AddCommonHeaders();

            var tradePileResponseMessage = await HttpClient
                .GetAsync(string.Format(uriString))
                .ConfigureAwait(false);

            return await DeserializeAsync<AuctionResponse>(tradePileResponseMessage);
        }
    }
}