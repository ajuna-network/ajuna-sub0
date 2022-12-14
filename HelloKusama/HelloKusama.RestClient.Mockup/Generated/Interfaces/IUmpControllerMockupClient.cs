//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloKusama.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives;
   
   public interface IUmpControllerMockupClient
   {
      Task<bool> SetRelayDispatchQueues(BaseVec<BaseVec<U8>> value, Id key);
      Task<bool> SetRelayDispatchQueueSize(BaseTuple<U32, U32> value, Id key);
      Task<bool> SetNeedsDispatch(BaseVec<Id> value);
      Task<bool> SetNextDispatchRoundStartWith(Id value);
      Task<bool> SetOverweight(BaseTuple<Id, BaseVec<U8>> value, U64 key);
      Task<bool> SetOverweightCount(U64 value);
   }
}
