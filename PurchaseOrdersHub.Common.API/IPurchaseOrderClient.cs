using System.Threading.Tasks;

namespace PurchaseOrdersHub.Common.API
{
    public interface IPurchaseOrderClient
    {
        //Task<List<POHeaderDTO>>  GetAllHeaders  ();
        Task<uint>  CountAll ();
    }
}
