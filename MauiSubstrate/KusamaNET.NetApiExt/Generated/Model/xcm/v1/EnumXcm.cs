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


namespace HelloKusama.NetApiExt.Generated.Model.xcm.v1
{
    
    
    public enum Xcm
    {
        
        WithdrawAsset = 0,
        
        ReserveAssetDeposited = 1,
        
        ReceiveTeleportedAsset = 2,
        
        QueryResponse = 3,
        
        TransferAsset = 4,
        
        TransferReserveAsset = 5,
        
        Transact = 6,
        
        HrmpNewChannelOpenRequest = 7,
        
        HrmpChannelAccepted = 8,
        
        HrmpChannelClosing = 9,
        
        RelayedFrom = 10,
        
        SubscribeVersion = 11,
        
        UnsubscribeVersion = 12,
    }
    
    /// <summary>
    /// >> 430 - Variant[xcm.v1.Xcm]
    /// </summary>
    public sealed class EnumXcm : BaseEnumExt<Xcm, BaseTuple<HelloKusama.NetApiExt.Generated.Model.xcm.v1.multiasset.MultiAssets, Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.xcm.v1.order.EnumOrder>>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.xcm.v1.multiasset.MultiAssets, Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.xcm.v1.order.EnumOrder>>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.xcm.v1.multiasset.MultiAssets, Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.xcm.v1.order.EnumOrder>>, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>, HelloKusama.NetApiExt.Generated.Model.xcm.v1.EnumResponse>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.xcm.v1.multiasset.MultiAssets, HelloKusama.NetApiExt.Generated.Model.xcm.v1.multilocation.MultiLocation>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.xcm.v1.multiasset.MultiAssets, HelloKusama.NetApiExt.Generated.Model.xcm.v1.multilocation.MultiLocation, Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.xcm.v1.order.EnumOrder>>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.xcm.v0.EnumOriginKind, Ajuna.NetApi.Model.Types.Primitive.U64, HelloKusama.NetApiExt.Generated.Model.xcm.double_encoded.DoubleEncodedT2>, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>>, BaseTuple<HelloKusama.NetApiExt.Generated.Model.xcm.v1.multilocation.EnumJunctions, HelloKusama.NetApiExt.Generated.Model.xcm.v1.EnumXcm>, BaseTuple<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>>, BaseVoid>
    {
    }
}
