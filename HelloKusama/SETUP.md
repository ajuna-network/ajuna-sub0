<h1>Substrate .NET Kusama SDK</h1>

Setting everything up for the Kusama SDK. Make sure that you are familiar with the general setup with .NET and the Ajuna.NetApi.

<h2>Kusama .NET SDK</h2>
<h3>1. Create New Project</h3>

- Create folder for HelloSubstrate and an initial console project.  

```
mkdir HelloKusama
cd HelloKusama
dotnet new --install Ajuna.DotNet.Template
dotnet new sln
dotnet new ajuna --sdk_version 0.1.27 --rest_service HelloKusama.RestService --net_api HelloKusama.NetApiExt --rest_client HelloKusama.RestClient --metadata_websocket ws://kusama-rpc.polkadot.io --force --allow-scripts yes
```

<h3>2. Create Console Application</h3>

``` 
dotnet new console --framework net6.0 --use-program-main --name PlayGround
dotnet sln add PlayGround\PlayGround.csproj
cd PlayGround
dotnet add reference ../HelloKusama.NetApiExt/HelloKusama.NetApiExt.csproj
dotnet add package Serilog
dotnet add package Serilog.Sinks.Console
```

<h3>3. Add your Code</h3>
- Add your code execution in the *Program.cs* file.

```csharp
using Serilog;
using Ajuna.NetApi;

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

        Log.Information("Hello, Kusama!");
    }
}
  ```
<h3>4. Run Project</h3>
- run the project by opening the terminal and typing ```dotnet run``` or ```Run Without Debugging (Ctrl+F5)```.
