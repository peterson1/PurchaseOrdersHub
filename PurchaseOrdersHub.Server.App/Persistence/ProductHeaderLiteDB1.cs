using PocketHub.Client.Lib.UserInterfaces.Logging;
using PocketHub.Server.Lib.Configuration;
using PocketHub.Server.Lib.Databases;
using PurchaseOrdersHub.Common.API.DTOs;
using Repo2.Core.ns11.FileSystems;

namespace PurchaseOrdersHub.Server.App.Persistence
{
    internal class ProductHeaderLiteDB1 : MonoTypeLocalDB<ProductHeaderDTO>
    {
        public ProductHeaderLiteDB1(IFileSystemAccesor fileSystemAccessor, ActivityLogVM activityLogVM, ServerSettings serverSettings) : base(fileSystemAccessor, activityLogVM, serverSettings)
        {
        }
    }
}
