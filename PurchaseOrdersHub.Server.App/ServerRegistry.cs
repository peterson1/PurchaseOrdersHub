﻿using Autofac;
using Microsoft.Owin.Hosting;
using PocketHub.Server.Lib.ComponentRegistry;
using PocketHub.Server.Lib.Databases;
using PurchaseOrdersHub.Common.API.DTOs;
using PurchaseOrdersHub.Server.App.Persistence;
using PurchaseOrdersHub.Server.App.SignalRHubs;
using Repo2.SDK.WPF45.Extensions.IOCExtensions;
using System;
using System.Windows;

namespace PurchaseOrdersHub.Server.App
{
    class ServerRegistry : ServerRegistryBase2
    {
        protected override void RegisterServerComponents(ContainerBuilder b, Application app)
        {
            b.Hub<ProductHeaderHub>();
            b.Hub<ProductBundleHub>();
            b.Hub<PurchaseOrderHub>();

            b.Solo<MonoTypeLocalDB<ProductHeaderDTO>, ProductHeaderLiteDB1>();
            b.Solo<MonoTypeLocalDB<ProductBundleDTO>, ProductBundleLiteDB1>();
            b.Solo<MonoTypeLocalDB<PurchaseOrderDTO>, PurchaseOrderLiteDB1>();

            b.Solo<IWebAppStarter, ServerRegistry>();
        }


        public override IDisposable StartWebApp(string hubServerUrl)
            => WebApp.Start<ServerRegistry>(hubServerUrl);
    }
}
