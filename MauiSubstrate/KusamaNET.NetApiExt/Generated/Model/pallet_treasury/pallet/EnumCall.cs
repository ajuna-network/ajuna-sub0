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


namespace HelloKusama.NetApiExt.Generated.Model.pallet_treasury.pallet
{
    
    
    public enum Call
    {
        
        propose_spend = 0,
        
        reject_proposal = 1,
        
        approve_proposal = 2,
        
        spend = 3,
        
        remove_approval = 4,
    }
    
    /// <summary>
    /// >> 142 - Variant[pallet_treasury.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>, HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>, HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>>
    {
    }
}
