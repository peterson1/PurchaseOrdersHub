using PurchaseOrdersHub.Common.API.DTOs;
using Repo2.Core.ns11.ChangeNotification;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PurchaseOrdersHub.Common.API
{
    public interface IProductHeaderClient : IStatusChanger
    {
        Task<uint>  CountAllHeaders  ();
        Task        ReplaceAll       (IEnumerable<ProductHeaderDTO> replacements);
    }
}
