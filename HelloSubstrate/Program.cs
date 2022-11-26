using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Serilog;

namespace HelloSubstrate;
class Program
{
    static async Task Main(string[] args)
    {

        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo
            .Console()
            .CreateLogger();

        Log.Information("Hello, Substrate!");

        var url = "wss://rpc.polkadot.io";
        var client = new SubstrateClient(new Uri(url), ChargeTransactionPayment.Default());
        
        Log.Information("Is connected? {0}", client.IsConnected);

        await client.ConnectAsync();

        Log.Information("Is connected? {0}", client.IsConnected);

        await client.CloseAsync();
    }
}
