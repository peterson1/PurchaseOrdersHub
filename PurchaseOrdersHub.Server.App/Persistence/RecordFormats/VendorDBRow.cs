namespace PurchaseOrdersHub.Server.App.Persistence.RecordFormats
{
    internal class VendorDBRow
    {
        public uint    Id             { get; set; }
        public string  CompanyName    { get; set; }
        public string  CompanyTIN     { get; set; }
        public string  OfficeAddress  { get; set; }
        public string  OfficeNumber   { get; set; }
        public string  MobileNumber   { get; set; }
        public string  FaxNumber      { get; set; }
        public string  EmailAddress   { get; set; }
        public string  ContactPerson  { get; set; }
    }
}
