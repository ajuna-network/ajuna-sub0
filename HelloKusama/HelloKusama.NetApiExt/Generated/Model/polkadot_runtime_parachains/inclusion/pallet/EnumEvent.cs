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


namespace HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.pallet
{
    
    
    public enum Event
    {
        
        CandidateBacked = 0,
        
        CandidateIncluded = 1,
        
        CandidateTimedOut = 2,
    }
    
    /// <summary>
    /// >> 468 - Variant[polkadot_runtime_parachains.inclusion.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CandidateReceipt, HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HeadData, HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CoreIndex, HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.GroupIndex>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CandidateReceipt, HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HeadData, HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CoreIndex, HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.GroupIndex>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CandidateReceipt, HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HeadData, HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CoreIndex>>
    {
    }
}