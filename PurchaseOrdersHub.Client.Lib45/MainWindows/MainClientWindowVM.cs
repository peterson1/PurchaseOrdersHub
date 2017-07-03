using PurchaseOrdersHub.Client.Lib45.VendorSKUSearchUI;
using Repo2.Core.ns11.AppUpdates;
using Repo2.Core.ns11.FileSystems;
using Repo2.SDK.WPF45.ViewModelTools;

namespace PurchaseOrdersHub.Client.Lib45.MainWindows
{
    public class MainClientWindowVM : TabbedMainWindowBase
    {
        protected override string CaptionPrefix => "Purchase Order";


        public MainClientWindowVM(IAppUpdater appUpdater,
                                  VendorSKUSearchTabVM vendorSKUSearchTabVM,
            IFileSystemAccesor fs) : base(fs)
        {
            AddAsTab(vendorSKUSearchTabVM);

            Updater = appUpdater;
            //Updater.StartCheckingForUpdates();
        }


        public IAppUpdater Updater { get; }
    }
}
