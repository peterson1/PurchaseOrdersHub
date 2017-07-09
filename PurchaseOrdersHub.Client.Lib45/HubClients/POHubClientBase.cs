using PocketHub.Client.Lib.ServiceProviders;
using PurchaseOrdersHub.Client.Lib45.Configuration;
using Repo2.Core.ns11.Exceptions;
using System;
using System.Threading.Tasks;

namespace PurchaseOrdersHub.Client.Lib45.HubClients
{
    public class POHubClientBase<T> : MonoTypeClientBase<T>
    {
        private PurchaseOrderClientCfg45 _cfg;
        private bool                     _isConnected;


        public POHubClientBase(PurchaseOrderClientCfg45 purchaseOrderClientCfg45)
        {
            _cfg = purchaseOrderClientCfg45;
        }


        protected async Task ConnectIfNeeded()
        {
            if (_isConnected) return;
            try
            {
                await base.Connect(_cfg);
            }
            catch (Exception ex)
            {
                SetStatus(ex.Info(true, true));
                throw ex;
            }
            _isConnected = true;
        }
    }
}
