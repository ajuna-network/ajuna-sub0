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


namespace HelloKusama.NetApiExt.Generated.Model.pallet_authorship
{
    
    
    public enum UncleEntryItem
    {
        
        InclusionHeight = 0,
        
        Uncle = 1,
    }
    
    /// <summary>
    /// >> 527 - Variant[pallet_authorship.UncleEntryItem]
    /// </summary>
    public sealed class EnumUncleEntryItem : BaseEnumExt<UncleEntryItem, Ajuna.NetApi.Model.Types.Primitive.U32, BaseTuple<HelloKusama.NetApiExt.Generated.Model.primitive_types.H256, Ajuna.NetApi.Model.Types.Base.BaseOpt<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>>
    {
    }
}
