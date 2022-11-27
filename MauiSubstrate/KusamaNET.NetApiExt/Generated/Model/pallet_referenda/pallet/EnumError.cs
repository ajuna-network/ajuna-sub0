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


namespace HelloKusama.NetApiExt.Generated.Model.pallet_referenda.pallet
{
    
    
    public enum Error
    {
        
        NotOngoing = 0,
        
        HasDeposit = 1,
        
        BadTrack = 2,
        
        Full = 3,
        
        QueueEmpty = 4,
        
        BadReferendum = 5,
        
        NothingToDo = 6,
        
        NoTrack = 7,
        
        Unfinished = 8,
        
        NoPermission = 9,
        
        NoDeposit = 10,
    }
    
    /// <summary>
    /// >> 646 - Variant[pallet_referenda.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
