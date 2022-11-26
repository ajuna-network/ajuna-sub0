Tools
- Visual Studio Code

Extensions

- C#, C# for Visual Studio Code (powered by OmniSharp).
    https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp

- NuGet Package Manager, Add or remove .NET Core 1.1+ package references to/from your project's .csproj or .fsproj file using Code's Command Palette.
    https://marketplace.visualstudio.com/items?itemName=jmrog.vscode-nuget-package-manager

Guide https://learn.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-6-0

<h3>Create the HelloSubstrate project</h3>
<p>To start we create a simple project that connect to any substrate-based network, by using the Ajuna.NetApi and using a Logger.</p>

- Create folder for HelloSubstrate and an initial console project.  

```
mkdir HelloSubstrate
cd HelloSubstrate
dotnet new console --framework net6.0 --use-program-main
```
- Add in the *HelloSubstrate.csproj* file the ItemGroup elements to include the necessary packages.
```csharp
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net6.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Ajuna.NetApi" Version="0.2.7"/>
    <PackageReference Include="Serilog" Version="2.12.0"/>
    <PackageReference Include="Serilog.Sinks.Console" Version="4.1.0"/>
  </ItemGroup>

</Project>
  ```
- Restore the project, to load the newly added packages, and add your code to *Program.cs* file,

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
- run the project by opening the terminal and typing ```dotnet run``` or ```Run Without Debugging (Ctrl+F5)```.
