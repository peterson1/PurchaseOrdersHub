using PurchaseOrdersHub.Client.Lib45.ComponentRegistry;
using Repo2.Core.ns11.Authentication;

namespace PurchaseOrdersHub.Client.SampleApp
{
    class ClientComponents : ClientComponentRegistryBase
    {


        protected override IR2Credentials UpdaterCredentials
            => new R2Credentials
            {
                BaseURL              = "https://192.168.0.201",
                Username             = "username_goes_here",
                Password             = "password_goes_here",
                CertificateThumb     = "thumb_goes_here",
                CheckIntervalSeconds = 60,
            };
    }
}
