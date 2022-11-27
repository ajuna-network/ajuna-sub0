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
    
    
    public enum Error
    {
        
        InsufficientProposersBalance = 0,
        
        InvalidIndex = 1,
        
        TooManyApprovals = 2,
        
        InsufficientPermission = 3,
        
        ProposalNotApproved = 4,
    }
    
    /// <summary>
    /// >> 606 - Variant[pallet_treasury.pallet.Error]
    /// Error for the treasury pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
