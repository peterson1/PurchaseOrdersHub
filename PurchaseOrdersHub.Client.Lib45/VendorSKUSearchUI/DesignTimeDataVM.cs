using System;
using System.Collections.Generic;
using Repo2.Core.ns11.DataStructures;

namespace PurchaseOrdersHub.Client.Lib45.VendorSKUSearchUI
{
    class DesignTimeDataVM
    {
        public DesignTimeDataVM()
        {
            Filters = new VendorSKUSearchFilterVM();
            Rows.Swap(CreateSampleRows());
        }


        public VendorSKUSearchFilterVM Filters { get; }

        public Observables<VendorSKUSearchRow> Rows { get; } = new Observables<VendorSKUSearchRow>();


        private IEnumerable<VendorSKUSearchRow> CreateSampleRows()
            => new List<VendorSKUSearchRow>
            {
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
                new VendorSKUSearchRow("vendor_", "sku_", "1234", "PC"),
            };
    }
}
