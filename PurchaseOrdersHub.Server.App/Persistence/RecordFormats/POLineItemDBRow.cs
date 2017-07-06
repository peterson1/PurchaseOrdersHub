namespace PurchaseOrdersHub.Server.App.Persistence.RecordFormats
{
    internal class POLineItemDBRow
    {
        public uint  Id          { get; set; }
        public uint  HeaderId    { get; set; }
        public uint  BarcodeId   { get; set; }
        public uint  UnitCostId  { get; set; }
        public uint  Quantity    { get; set; }
    }
}
