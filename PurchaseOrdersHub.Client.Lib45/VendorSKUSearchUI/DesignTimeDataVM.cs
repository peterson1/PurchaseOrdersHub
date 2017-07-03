using Repo2.Core.ns11.DataStructures;

namespace PurchaseOrdersHub.Client.Lib45.VendorSKUSearchUI
{
    class DesignTimeDataVM
    {
        public DesignTimeDataVM()
        {
            Filters = new VendorSKUSearchFilterVM();
        }


        public VendorSKUSearchFilterVM Filters { get; }

        public Observables<VendorSKUSearchRow> Rows { get; } = new Observables<VendorSKUSearchRow>();
    }
}
