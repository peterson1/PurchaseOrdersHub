using PurchaseOrdersHub.Client.Lib45.Configuration;
using PurchaseOrdersHub.Common.API;
using PurchaseOrdersHub.Common.API.DTOs;
using Repo2.Core.ns11.Exceptions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PurchaseOrdersHub.Client.Lib45.HubClients
{
    public class ProductHeaderClient1 : POHubClientBase<ProductHeaderDTO>, IProductHeaderClient
    {
        public ProductHeaderClient1(PurchaseOrderClientCfg45 purchaseOrderClientCfg45) : base(purchaseOrderClientCfg45)
        {
        }

        public async Task<uint> CountAllHeaders()
        {
            await ConnectIfNeeded();
            var rep = await base.CountAll();
            ThrowError.IfFailed(rep, "CountAllHeaders");
            return rep.Result;
        }


        public async Task ReplaceAll(IEnumerable<ProductHeaderDTO> replacements)
        {
            var rep = await base.DeleteAll();
            ThrowError.IfFailed(rep, "DeleteAll");
            rep = await base.BatchInsert(replacements);
            ThrowError.IfFailed(rep, "BatchInsert");
        }
    }
}
