//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace HelloKusama.NetApiExt.Generated.Model.pallet_proxy.pallet
{
    
    
    public enum Event
    {
        
        ProxyExecuted = 0,
        
        PureCreated = 1,
        
        Announced = 2,
        
        ProxyAdded = 3,
        
        ProxyRemoved = 4,
    }
    
    /// <summary>
    /// >> 456 - Variant[pallet_proxy.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, HelloKusama.NetApiExt.Generated.Types.Base.EnumResult, BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.kusama_runtime.EnumProxyType, Ajuna.NetApi.Model.Types.Primitive.U16>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.primitive_types.H256>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.kusama_runtime.EnumProxyType, Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.kusama_runtime.EnumProxyType, Ajuna.NetApi.Model.Types.Primitive.U32>>
    {
    }
}
