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


namespace HelloKusama.NetApiExt.Generated.Model.pallet_ranked_collective.pallet
{
    
    
    public enum Call
    {
        
        add_member = 0,
        
        promote_member = 1,
        
        demote_member = 2,
        
        remove_member = 3,
        
        vote = 4,
        
        cleanup_poll = 5,
    }
    
    /// <summary>
    /// >> 166 - Variant[pallet_ranked_collective.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress, Ajuna.NetApi.Model.Types.Primitive.U16>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.Bool>, BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>>
    {
    }
}
