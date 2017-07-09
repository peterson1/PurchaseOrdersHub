using PurchaseOrdersHub.Client.Lib45.Configuration;
using PurchaseOrdersHub.Common.API;
using PurchaseOrdersHub.Common.API.DTOs;
using Repo2.Core.ns11.Exceptions;
using System.Threading.Tasks;

namespace PurchaseOrdersHub.Client.Lib45.HubClients
{
    public class PurchaseOrderHubClient1 : POHubClientBase<PurchaseOrderDTO>, IPurchaseOrderClient
    {
        public PurchaseOrderHubClient1(PurchaseOrderClientCfg45 purchaseOrderClientCfg45) : base(purchaseOrderClientCfg45)
        {
        }

        public async Task<uint> CountAllHeaders()
        {
            await ConnectIfNeeded();
            var rep = await base.CountAll();
            ThrowError.IfFailed(rep, "IPurchaseOrderClient.CountAll");
            return rep.Result;
        }
    }
}
