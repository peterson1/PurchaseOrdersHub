using System;

namespace PurchaseOrdersHub.Common.API.DTOs
{
    public class BuyingCostDTO
    {
        public uint      Id             { get; set; }
        public uint      BundleId       { get; set; }
        public uint      VendorId       { get; set; }
        public double    PesoCost       { get; set; }
        public DateTime  EffectiveDate  { get; set; }
        public string    Remarks        { get; set; }
    }
}
