using PurchaseOrdersHub.Client.Lib45.Configuration;
using PurchaseOrdersHub.Common.API;
using PurchaseOrdersHub.Common.API.DTOs;
using Repo2.Core.ns11.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurchaseOrdersHub.Client.Lib45.HubClients
{
    public class ProductHeaderClient1 : POHubClientBase<ProductHeaderDTO>, IProductHeaderClient
    {
        public ProductHeaderClient1(PurchaseOrderClientCfg45 purchaseOrderClientCfg45) : base(purchaseOrderClientCfg45)
        {
        }


        public async Task<Dictionary<int, uint>> GetLegacyIdToHubIdDictionary()
        {
            var rep = await base.GetAll();
            ThrowError.IfFailed(rep, "GetAll");

            var dict = new Dictionary<int, uint>();
            var grpdByLegacy = rep.Result.GroupBy(x => x.LegacyId).ToList();

            foreach (var grp in grpdByLegacy)
            {
                if (grp.Count() > 1)
                    throw Fault.MultiMatch<ProductHeaderDTO>(nameof(ProductHeaderDTO.LegacyId), grp.Key);

                dict.Add(grp.Single().LegacyId, grp.Single().Id);
            }
            return dict;
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
