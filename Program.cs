using System;
using System.Threading.Tasks;
using Statiq.App;
using Statiq.Web;
using KenticoKontentModels;
using Statiq.Common;
using Microsoft.Extensions.DependencyInjection;
using Kentico.Kontent.Delivery.Extensions;
using Kentico.Kontent.Delivery.Abstractions;

namespace statiq_starter_kontent_lumen
{
    public class Program
    {
        public static async Task<int> Main(string[] args) =>
            await Bootstrapper
                .Factory
                .CreateWeb(args)
                .ConfigureServices((services, config) =>
                {
                    // Add the type provider
                    services.AddSingleton<ITypeProvider, CustomTypeProvider>();
                    // Configure Delivery SDK
                    services.AddDeliveryClient(opts =>
                        opts.WithProjectId("fe1e198a-96eb-01ea-a4c8-477c331d5ed8")
                            .UseProductionApi()
                            .Build());
                })
                .RunAsync();
    }
}
