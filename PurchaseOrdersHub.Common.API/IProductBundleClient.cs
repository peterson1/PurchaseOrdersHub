using PurchaseOrdersHub.Common.API.DTOs;
using Repo2.Core.ns11.ChangeNotification;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PurchaseOrdersHub.Common.API
{
    public interface IProductBundleClient : IStatusChanger
    {
        Task<uint>  CountAllBundles  ();
        Task        ReplaceAll       (IEnumerable<ProductBundleDTO> replacements);
    }
}
