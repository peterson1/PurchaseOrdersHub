namespace PurchaseOrdersHub.Client.Lib45.VendorSKUSearchUI
{
    class VendorSKUSearchRow
    {
        public VendorSKUSearchRow(string vendor,
                                  string product,
                                  string barcode,
                                  string uom)
        {
            Vendor  = vendor;
            Product = product;
            Barcode = barcode;
            UoM     = uom;
        }

        public string   Vendor    { get; }
        public string   Product   { get; }
        public string   Barcode   { get; }
        public string   UoM       { get; }
    }
}
