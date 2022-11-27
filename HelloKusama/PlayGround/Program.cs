using Serilog;
using Ajuna.NetApi;
using HelloKusama.NetApiExt.Generated;
using Ajuna.NetApi.Model.Extrinsics;

namespace PlayGround;
class Program
{
    static async Task Main(string[] args)
    {

        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo
            .Console()
            .CreateLogger();

        var cts = new CancellationTokenSource();
        Console.CancelKeyPress += (s, e) =>
        {
            Log.Information("Canceling...");
            cts.Cancel();
            e.Cancel = true;
        };

        try
        {
            Log.Information("Press {0} to end.", "Ctrl+C");
            await MainAsync(cts.Token);
        }
        catch (OperationCanceledException)
        {

        }

        Log.CloseAndFlush();
    }

    private static async Task MainAsync(CancellationToken token)
    {
        var url = "wss://kusama-rpc.polkadot.io";

        Log.Information("Hello, Kusama");

        var client = new SubstrateClientExt(
            new Uri(url), 
            ChargeTransactionPayment.Default());

        await client.ConnectAsync(token);

        if(!client.IsConnected) {
            Log.Warning("Could not connect to {0}!", url);
            return;
        }

        Log.Information("Connected to {0}? {1}", url, client.IsConnected);
        Log.Information("Node: {0}/{1}/{2}/{3} - Genesis: {4}", 
            client.RuntimeVersion.ImplName, 
            client.RuntimeVersion.ImplVersion, 
            client.RuntimeVersion.SpecName, 
            client.RuntimeVersion.SpecVersion,
            client.GenesisHash);

        uint currentBlocknumber = 0;
        while(!token.IsCancellationRequested) {
            
            var blockNumber = await client.SystemStorage.Number(token);

            if (blockNumber == null || currentBlocknumber == blockNumber.Value) {
                Log.Debug("No update or null - {0}", blockNumber);
                Thread.Sleep(1000);
                continue;
            }

            currentBlocknumber = blockNumber.Value;
            Log.Information("Next Block = {0}", currentBlocknumber);
        }
    }
}
