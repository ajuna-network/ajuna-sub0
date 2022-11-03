# Sub0 Talk: Substrate .NET Toolchain & Unity
![ajuna-Header-1080p_with_logo](https://polkadot.network/content/images/2022/08/image1.jpg)


![presentation_banner](https://github.com/dimitrispaxinos/ajuna-sub0/blob/main/images/Presentation%20Entry%20Screenshot.png?raw=true)

This repo contains the notes for [Ajuna.Network's](https://ajuna.io/) _Substrate .NET Toolchain & Unity_ talk on the sub0 conference.

## Presentation Slides
The presentation slides can be found [here]().

## Agenda

1. **How everything started**   
Brief introduction about what led us to developing the .NET Toolchain.
2. **.NET Toolchain**  
We will explore the main offerings of the toolchain, show its usage and generate the SDK for a substrate node. 
3. **Usage Examples**  
Hands-on Demo to show storage changes polling, subscription to storage changes, extrinsic execution.
4. **Building a working Unity app**  
We will build a small Unity app using the generated SDK of 


## Main Toolchain Repos

#### [Ajuna.NetApi](https://github.com/ajuna-network/Ajuna.NetApi)

`Ajuna.NetApi` is the basic framework for accessing and handling JSON-RPC connections and handling all standard RPC calls exposed by the `rpc.methods()` of every substrate node. It additionally implements Rust primitives and Generics as a C# representation like [U8](https://github.com/ajuna-network/Ajuna.NetApi/blob/master/Ajuna.NetApi/Model/Types/Primitive/U8.cs), [BaseVec](https://github.com/ajuna-network/Ajuna.NetApi/blob/master/Ajuna.NetApi/Model/Types/Base/BaseVec.cs) (Vec<>), or [EnumExt](https://github.com/ajuna-network/Ajuna.NetApi/blob/master/Ajuna.NetApi/Model/Types/Base/BaseEnumExt.cs) (Rust-specific Enums).

#### [Ajuna.SDK](https://github.com/ajuna-network/Ajuna.SDK)
`Ajuna.SDK` is a .NET toolchain featuring .NET framework extensions and code generation utilities to build substrate storage services and clients quickly. This toolchain extends Ajuna.NetApi library, which provides raw access to substrate nodes.

#### [Ajuna.NetWallet](https://github.com/ajuna-network/Ajuna.NetWallet)

`Ajuna.NetWallet` implements the basic functionality to create an account, and encrypt it on a device based filesystem. It also supports mnemonic, AES, SR25519 and ED25519 encryption. Additionally, it encodes and decodes substrate-based address formats in ss58.

## Demo Repos
- [Ajuna.SDK.Demos](https://github.com/ajuna-network/Ajuna.SDK.Demos)
- [SubstrateNET.UnityDemo](https://github.com/ajuna-network/SubstrateNET.UnityDemo)

## Development Tools for the workshop
- Visual Studio Code or Visual Studio
- Unity App
- A running Substrate node

