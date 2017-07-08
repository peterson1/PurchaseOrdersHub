using PocketHub.Client.Lib.UserInterfaces.Logging;
using PocketHub.Server.Lib.Configuration;
using PocketHub.Server.Lib.Databases;
using PocketHub.Server.Lib.MainTabs.ConnectionsTab;
using PocketHub.Server.Lib.SignalRHubs;
using PocketHub.Server.Lib.UserAccounts;
using PurchaseOrdersHub.Common.API.DTOs;
using Repo2.Core.ns11.FileSystems;

namespace PurchaseOrdersHub.Server.App.SignalRHubs
{
    public class PurchaseOrderHub : MonoTypeHubBase<PurchaseOrderDTO>
    {
        public PurchaseOrderHub(IFileSystemAccesor fileSystemAccesor, MonoTypeLocalDB<PurchaseOrderDTO> localRepoBase, ActivityLogVM activityLogVM, IUserAccountsRepo userAccountsRepo, CurrentClientsVM currentClientsVM, ServerSettings serverSettings) : base(fileSystemAccesor, localRepoBase, activityLogVM, userAccountsRepo, currentClientsVM, serverSettings)
        {
        }
    }
}
