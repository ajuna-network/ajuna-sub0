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


namespace HelloKusama.NetApiExt.Generated.Model.pallet_society
{
    
    
    public enum BidKind
    {
        
        Deposit = 0,
        
        Vouch = 1,
    }
    
    /// <summary>
    /// >> 663 - Variant[pallet_society.BidKind]
    /// </summary>
    public sealed class EnumBidKind : BaseEnumExt<BidKind, Ajuna.NetApi.Model.Types.Primitive.U128, BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>>
    {
    }
}
