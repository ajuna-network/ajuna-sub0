//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Attributes;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace HelloKusama.NetApiExt.Generated.Model.frame_system.extensions.check_non_zero_sender
{
    
    
    /// <summary>
    /// >> 840 - Composite[frame_system.extensions.check_non_zero_sender.CheckNonZeroSender]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class CheckNonZeroSender : BaseType
    {
        
        public override string TypeName()
        {
            return "CheckNonZeroSender";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            TypeSize = p - start;
        }
    }
}
