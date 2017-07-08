using PocketHub.Client.Lib.Configuration;
using PocketHub.Client.Lib.ServiceProviders;
using PurchaseOrdersHub.Client.Lib45.Configuration;
using PurchaseOrdersHub.Common.API;
using PurchaseOrdersHub.Common.API.DTOs;
using Repo2.Core.ns11.Exceptions;
using System.Threading.Tasks;

namespace PurchaseOrdersHub.Client.Lib45.HubClients
{
    public class PurchaseOrderHubClient1 : MonoTypeClientBase<PurchaseOrderDTO>, IPurchaseOrderClient
    {
        private PurchaseOrderClientCfg45 _cfg;
        private bool                     _isConnected;


        public PurchaseOrderHubClient1(PurchaseOrderClientCfg45 purchaseOrderClientCfg45)
        {
            _cfg = purchaseOrderClientCfg45;
        }


        async Task<uint> IPurchaseOrderClient.CountAll()
        {
            await ConnectIfNeeded();
            var rep = await base.CountAll();
            ThrowError.IfFailed(rep, "IPurchaseOrderClient.CountAll");
            return rep.Result;
        }


        private async Task ConnectIfNeeded()
        {
            if (_isConnected) return;
            await base.Connect(_cfg);
            _isConnected = true;
        }
    }
}
