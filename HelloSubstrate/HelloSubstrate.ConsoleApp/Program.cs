using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Serilog;

namespace HelloSubstrate.ConsoleApp
{
    internal static class Program
    {
        private static readonly ILogger Logger = new LoggerConfiguration()
            .MinimumLevel.Verbose()
            .WriteTo.Console()
            .CreateLogger();

        private static string PolkadotNodeUrl = "wss://rpc.polkadot.io";

        public static async Task Main(string[] args)
        {
            var client = new SubstrateClient(new Uri(PolkadotNodeUrl), ChargeAssetTxPayment.Default());

            Logger.Information("Connected: {IsConnected}", client.IsConnected);

            await client.ConnectAsync();

            Logger.Information("Connected: {IsConnected}", client.IsConnected);

            Logger.Information("{SpecName}", client.RuntimeVersion.SpecName);
            Logger.Information("{ImplName}", client.RuntimeVersion.ImplName);
        }
    }
}