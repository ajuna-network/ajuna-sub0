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


namespace HelloKusama.NetApiExt.Generated.Model.sp_runtime
{
    
    
    /// <summary>
    /// >> 447 - Composite[sp_runtime.DispatchErrorWithPostInfo]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class DispatchErrorWithPostInfo : BaseType
    {
        
        /// <summary>
        /// >> post_info
        /// </summary>
        private HelloKusama.NetApiExt.Generated.Model.frame_support.dispatch.PostDispatchInfo _postInfo;
        
        /// <summary>
        /// >> error
        /// </summary>
        private HelloKusama.NetApiExt.Generated.Model.sp_runtime.EnumDispatchError _error;
        
        public HelloKusama.NetApiExt.Generated.Model.frame_support.dispatch.PostDispatchInfo PostInfo
        {
            get
            {
                return this._postInfo;
            }
            set
            {
                this._postInfo = value;
            }
        }
        
        public HelloKusama.NetApiExt.Generated.Model.sp_runtime.EnumDispatchError Error
        {
            get
            {
                return this._error;
            }
            set
            {
                this._error = value;
            }
        }
        
        public override string TypeName()
        {
            return "DispatchErrorWithPostInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(PostInfo.Encode());
            result.AddRange(Error.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            PostInfo = new HelloKusama.NetApiExt.Generated.Model.frame_support.dispatch.PostDispatchInfo();
            PostInfo.Decode(byteArray, ref p);
            Error = new HelloKusama.NetApiExt.Generated.Model.sp_runtime.EnumDispatchError();
            Error.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
