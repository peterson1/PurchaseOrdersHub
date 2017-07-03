using Autofac;
using PurchaseOrdersHub.Client.Lib45.AppUpdates;
using PurchaseOrdersHub.Client.Lib45.Configuration;
using PurchaseOrdersHub.Client.Lib45.MainWindows;
using PurchaseOrdersHub.Client.Lib45.VendorSKUSearchUI;
using Repo2.Core.ns11.AppUpdates;
using Repo2.Core.ns11.Authentication;
using Repo2.Core.ns11.FileSystems;
using Repo2.SDK.WPF45.ComponentRegistry;
using Repo2.SDK.WPF45.Configuration;
using Repo2.SDK.WPF45.Extensions.IOCExtensions;
using Repo2.SDK.WPF45.Extensions.ViewModelExtensions;
using System.Windows;

namespace PurchaseOrdersHub.Client.Lib45.ComponentRegistry
{
    public abstract class ClientComponentRegistryBase : ComponentRegistryBase<ClientSettingsN45>
    {
        protected override void RegisterComponents(ContainerBuilder b)
        {
            b.Solo<IAppUpdater, Repo2AppUpdater>();

            b.Solo<MainClientWindowVM>();
            b.Solo<VendorSKUSearchTabVM>();

            b.RegisterInstance<IR2Credentials>(UpdaterCredentials);
        }


        protected abstract IR2Credentials UpdaterCredentials { get; }


        protected override void SetDataTemplates(Application app)
        {
            app.SetTemplate<VendorSKUSearchTabVM, VendorSKUSearchTabUI>();
        }


        protected override ClientSettingsN45 LoadSettingsFile(IFileSystemAccesor fs)
        {
            var loadr = new BesideExeCfgLoader<ClientSettingsN45>(fs);
            return loadr.Load(ClientSettingsN45.CreateDraft());
        }


        protected override object ResolveMainWindowVM(ILifetimeScope scope)
            => scope.Resolve<MainClientWindowVM>();
    }
}
