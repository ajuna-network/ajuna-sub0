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


namespace HelloKusama.NetApiExt.Generated.Model.pallet_recovery.pallet
{
    
    
    public enum Event
    {
        
        RecoveryCreated = 0,
        
        RecoveryInitiated = 1,
        
        RecoveryVouched = 2,
        
        RecoveryClosed = 3,
        
        AccountRecovered = 4,
        
        RecoveryRemoved = 5,
    }
    
    /// <summary>
    /// >> 452 - Variant[pallet_recovery.pallet.Event]
    /// Events type.
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>
    {
    }
}
