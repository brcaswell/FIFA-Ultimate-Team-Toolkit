using System;
using System.Net.Http;
using System.Threading.Tasks;
using UltimateTeam.Toolkit.Constants;
using UltimateTeam.Toolkit.Extensions;
using UltimateTeam.Toolkit.Models;

namespace UltimateTeam.Toolkit.Requests
{
    internal class SendItemToClubRequest : FutRequestBase, IFutRequest<SendItemToClubResponse>
    {
        private readonly ItemData _itemData;

        public SendItemToClubRequest(ItemData itemData)
        {
            itemData.ThrowIfNullArgument();
            _itemData = itemData;
        }

        public async Task<SendItemToClubResponse> PerformRequestAsync()
        {
            var uriString = Resources.FutHome + Resources.ListItem;
            Task<HttpResponseMessage> clubResponseMessageTask;

            //Apply Draft-Token & Credits to club
            var content = _itemData.CardSubTypeId == 231
                              ? new StringContent("{\"apply\":[]}")
                              : new StringContent($"{{\"itemData\":[{{\"pile\":\"club\",\"id\":\"{_itemData.Id}\"}}]}}");

            AddCommonHeaders();

            if (_itemData.CardSubTypeId == 231)
            {
                uriString += "/" + _itemData.Id;
                clubResponseMessageTask = HttpClient.PostAsync(uriString, content);
            }
            else
            {
                uriString += $"?_={DateTime.Now.ToUnixTime()}";
                clubResponseMessageTask = HttpClient.PutAsync(uriString, content);
            }

            var clubResponseMessage = await clubResponseMessageTask.ConfigureAwait(false);

            return await DeserializeAsync<SendItemToClubResponse>(clubResponseMessage);
        }
    }
}