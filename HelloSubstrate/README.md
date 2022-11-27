<h1>Substrate .NET VSCode Setup</h1>

Setting everything up for the simple project HelloSubstrate.

<h2>Development Environment</h2>
- Visual Studio Code, https://code.visualstudio.com/

<h2>Extensions</h2>

- C#, C# for Visual Studio Code (powered by OmniSharp).
    https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp

- NuGet Package Manager, Add or remove .NET Core 1.1+ package references to/from your project's .csproj or .fsproj file using Code's Command Palette.
    https://marketplace.visualstudio.com/items?itemName=jmrog.vscode-nuget-package-manager

Guide https://learn.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-6-0

<h2>Substrate .NET Project</h2>
<p>To start we create a simple project that connect to any substrate-based network, by using the Ajuna.NetApi and using a Logger.</p>

<h3>1. Create New Project</h3>

- Create folder for HelloSubstrate and an initial console project.  

```
mkdir HelloSubstrate
cd HelloSubstrate
dotnet new console --framework net6.0 --use-program-main
```

<h3>2. Add Packages</h3>

- Add Nuget Packages, with the Manager
  - Ajuna.NetApi
  - Serilog
  - Serilog.Sinks.Console
- Your project file *HelloSubstrate.csproj* should have the corresponding ItemGroup elements to include the necessary packages.
```csharp
...
  <ItemGroup>
    <PackageReference Include="Ajuna.NetApi" Version="0.2.7"/>
    <PackageReference Include="Serilog" Version="2.12.0"/>
    <PackageReference Include="Serilog.Sinks.Console" Version="4.1.0"/>
  </ItemGroup>
...
  ```
- Restore the project, to load the newly added packages.


<h3>3. Add your Code</h3>
- Add your code execution in the *Program.cs* file.

```csharp
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
        var client = new SubstrateClient(new Uri(url), 
            ChargeTransactionPayment.Default());
        
        Log.Information("Is connected? {0}", client.IsConnected);

        await client.ConnectAsync();

        Log.Information("Is connected? {0}", client.IsConnected);

        await client.CloseAsync();
    }
}
  ```
<h3>4. Run Project</h3>
- run the project by opening the terminal and typing <code>dotnet run</code> or <code>Run Without Debugging (Ctrl+F5)</code>.
