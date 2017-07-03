using Repo2.SDK.WPF45.ViewModelTools;
using System;
using System.Collections.Generic;

namespace PurchaseOrdersHub.Client.Lib45.VendorSKUSearchUI
{
    class VendorSKUSearchFilterVM : TextFilterBase<VendorSKUSearchRow>
    {
        public string   VendorFilter    { get; set; }
        public string   ProductFilter   { get; set; }
        public string   BarcodeFilter   { get; set; }
        public string   UoMFilter       { get; set; }


        protected override Dictionary<string, Func<VendorSKUSearchRow, string>> FilterProperties
            => new Dictionary<string, Func<VendorSKUSearchRow, string>>
            {
                { nameof(VendorFilter ), _ => _.Vendor },
                { nameof(ProductFilter), _ => _.Product},
                { nameof(BarcodeFilter), _ => _.Barcode},
                { nameof(UoMFilter    ), _ => _.UoM    },
            };
    }
}
