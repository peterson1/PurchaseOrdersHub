namespace PurchaseOrdersHub.Common.API.DTOs
{
    public class ProductBundleDTO
    {
        public uint    Id                 { get; set; }
        public uint    ProductId          { get; set; }
        public string  BundleDescription  { get; set; }
        public string  UoM                { get; set; }
        public ulong   Barcode            { get; set; }
    }
}
