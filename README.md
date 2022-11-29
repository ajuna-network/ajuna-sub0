# Ajuna sub0 Talk: Substrate .NET Toolchain & Unity
![ajuna-Header-1080p_with_logo](https://polkadot.network/content/images/2022/08/image1.jpg)


![presentation_banner](https://github.com/dimitrispaxinos/ajuna-sub0/blob/main/images/Presentation%20Entry%20Screenshot.png?raw=true)

This repo contains:
- The notes for [Ajuna.Network's](https://ajuna.io/) _Substrate .NET Toolchain & Unity_ talk on the sub0 conference 
- A basic demo .NET solution, [HelloSubstrate](https://github.com/ajuna-network/ajuna-sub0/tree/main/HelloSubstrate) showing how we can connect toa Substrate Node using the .NET Toolchain.

## Presentation Slides
The presentation slides can be found [here](https://docs.google.com/presentation/d/166VzGfN7tn6cC1SaqD1wAxx12sB5pyCe/edit?usp=sharing&ouid=116338638740224360478&rtpof=true&sd=true).

## Agenda

1. **How everything started**   
Brief introduction about what led us to develop the .NET Toolchain.
2. **.NET Toolchain**  
We will explore the main offerings of the toolchain, show its usage and generate the SDK for a substrate node. 
3. **Usage Examples**  
Hands-on Demo to show storage changes polling, subscription to storage changes, extrinsic execution.
4. **Building a working Unity app**  
We will build a small Unity app using the generated SDK 


## Main Toolchain Repos

### [Ajuna.NetApi](https://github.com/ajuna-network/Ajuna.NetApi)
`Ajuna.NetApi` is the basic framework for accessing and handling JSON-RPC connections and handling all standard RPC calls exposed by the `rpc.methods()` of every substrate node. It additionally implements Rust primitives and Generics as a C# representation like [U8](https://github.com/ajuna-network/Ajuna.NetApi/blob/master/Ajuna.NetApi/Model/Types/Primitive/U8.cs), [BaseVec](https://github.com/ajuna-network/Ajuna.NetApi/blob/master/Ajuna.NetApi/Model/Types/Base/BaseVec.cs) (Vec<>), or [EnumExt](https://github.com/ajuna-network/Ajuna.NetApi/blob/master/Ajuna.NetApi/Model/Types/Base/BaseEnumExt.cs) (Rust-specific Enums).

### [Ajuna.SDK](https://github.com/ajuna-network/Ajuna.SDK)
`Ajuna.SDK` is a .NET toolchain featuring .NET framework extensions and code generation utilities to build substrate storage services and clients quickly. This toolchain extends Ajuna.NetApi library, which provides raw access to substrate nodes. You can also find the generated projects from each monthly Substrate release in the [SubstrateNet repository](https://github.com/ajuna-network/SubstrateNET).

### [Ajuna.NetWallet](https://github.com/ajuna-network/Ajuna.NetWallet)

`Ajuna.NetWallet` implements the basic functionality to create an account, and encrypt it on a device based filesystem. It also supports mnemonic, AES, SR25519 and ED25519 encryption. Additionally, it encodes and decodes substrate-based address formats in ss58.

## Demo Repos
- [Ajuna.SDK.Demos](https://github.com/ajuna-network/Ajuna.SDK.Demos)  
This repository contains basic examples of how the generated SDK can be used.

- [SubstrateNET.UnityDemo](https://github.com/ajuna-network/SubstrateNET.UnityDemo)  
This is a simple Unity Demo built on top of the Ajuna.SDK

- [MoneyPot Blazor front app](https://github.com/Apolixit/moneypot_blazor)  
This repository is an [ASP.NET Blazor](https://learn.microsoft.com/fr-fr/aspnet/core/blazor) application, written in C#, based on Ajuna SDK generated projects.   
It's a custom front end for the [Money pot pallet](https://github.com/Apolixit/pallet_money_pot) developped with Substrate.


## What you need for the workshop

### 1. Install Rust 

**Windows**  
Download and run [rustup-init.exe](https://static.rust-lang.org/rustup/dist/i686-pc-windows-gnu/rustup-init.exe)

 **macOS / Linux**  
 Execute `curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
`

### 2. Get a Substrate node up and running
The first and most important prerequisite is to have a running Substrate node.

Currently you should find the most recent monthly build with a pre-generated tag in this [repo](https://github.com/paritytech/substrate), so make sure you chose a supported monthly substrate tag (ex. monthly-2022-11)


```bash
git clone -b monthly-2022-11 --single-branch https://github.com/paritytech/substrate.git
cd substrate
cargo build -p node-cli --release
./target/release/node-template --dev
```

### 3. Install Visual Studio Code or Visual Studio
Install [VS Code](https://code.visualstudio.com/Download) with the necessary [setup](https://code.visualstudio.com/docs/languages/dotnet) for .NET development. Alternatively, [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) might be the easies option.

### 4. Install Unity Hub
Download [Unity Hub](https://unity.com/download) and install version _2021.3.7f1_ to be able to run the Unity Demo.  

## Projects
- [HelloSubstrate](https://github.com/ajuna-network/ajuna-sub0/tree/main/HelloSubstrate)
- [HelloKusama](https://github.com/ajuna-network/ajuna-sub0/tree/main/HelloKusama)
- [MauiSubstrate](https://github.com/ajuna-network/ajuna-sub0/tree/main/MauiSubstrate)
- [SubstrateNET.UnityDemo](https://github.com/ajuna-network/SubstrateNET.UnityDemo)
