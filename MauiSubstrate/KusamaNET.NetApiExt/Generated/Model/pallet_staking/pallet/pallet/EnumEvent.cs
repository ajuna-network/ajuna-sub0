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


namespace HelloKusama.NetApiExt.Generated.Model.pallet_staking.pallet.pallet
{
    
    
    public enum Event
    {
        
        EraPaid = 0,
        
        Rewarded = 1,
        
        Slashed = 2,
        
        OldSlashingReportDiscarded = 3,
        
        StakersElected = 4,
        
        Bonded = 5,
        
        Unbonded = 6,
        
        Withdrawn = 7,
        
        Kicked = 8,
        
        StakingElectionFailed = 9,
        
        Chilled = 10,
        
        PayoutStarted = 11,
        
        ValidatorPrefsSet = 12,
    }
    
    /// <summary>
    /// >> 33 - Variant[pallet_staking.pallet.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U128, Ajuna.NetApi.Model.Types.Primitive.U128>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>, Ajuna.NetApi.Model.Types.Primitive.U32, BaseVoid, BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseVoid, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.pallet_staking.ValidatorPrefs>>
    {
    }
}
