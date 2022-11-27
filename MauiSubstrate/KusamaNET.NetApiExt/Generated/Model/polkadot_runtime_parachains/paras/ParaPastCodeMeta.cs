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


namespace HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.paras
{
    
    
    /// <summary>
    /// >> 785 - Composite[polkadot_runtime_parachains.paras.ParaPastCodeMeta]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class ParaPastCodeMeta : BaseType
    {
        
        /// <summary>
        /// >> upgrade_times
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.paras.ReplacementTimes> _upgradeTimes;
        
        /// <summary>
        /// >> last_pruned
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32> _lastPruned;
        
        public Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.paras.ReplacementTimes> UpgradeTimes
        {
            get
            {
                return this._upgradeTimes;
            }
            set
            {
                this._upgradeTimes = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32> LastPruned
        {
            get
            {
                return this._lastPruned;
            }
            set
            {
                this._lastPruned = value;
            }
        }
        
        public override string TypeName()
        {
            return "ParaPastCodeMeta";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(UpgradeTimes.Encode());
            result.AddRange(LastPruned.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            UpgradeTimes = new Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.paras.ReplacementTimes>();
            UpgradeTimes.Decode(byteArray, ref p);
            LastPruned = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>();
            LastPruned.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
