using System;

namespace PurchaseOrdersHub.Server.App.Persistence.RecordFormats
{
    internal class POHeaderDBRow
    {
        public uint       Id                 { get; set; }
        public uint       Serial             { get; set; }
        public uint       VendorId           { get; set; }
        public DateTime?  CancellationDate   { get; set; }
        public DateTime?  PostedDate         { get; set; }
        public uint       PostedByUserId     { get; set; }
        public uint       ReceivingBranchId  { get; set; }
    }
}
