using PocketHub.Server.Lib.MainWindows;
using System.Windows;

namespace PurchaseOrdersHub.Server.App
{
    public partial class App : Application
    {
        const string COUNT_ICO_URI = "pack://application:,,,/PurchaseOrdersHub.Client.Lib45;component/Assets/po_128.ico";

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var win = new MainHubWindow1(COUNT_ICO_URI);
            win.DataContext = new ServerRegistry().CreateMainVM(this);
            win.Show();
        }
    }
}
