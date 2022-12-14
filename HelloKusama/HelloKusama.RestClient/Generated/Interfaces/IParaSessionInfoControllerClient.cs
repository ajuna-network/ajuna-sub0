//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloKusama.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.assignment_app;
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.crypto;
   
   public interface IParaSessionInfoControllerClient
   {
      Task<BaseVec<Public>> GetAssignmentKeysUnsafe();
      Task<bool> SubscribeAssignmentKeysUnsafe();
      Task<U32> GetEarliestStoredSession();
      Task<bool> SubscribeEarliestStoredSession();
      Task<SessionInfo> GetSessions(U32 key);
      Task<bool> SubscribeSessions(U32 key);
      Task<BaseVec<AccountId32>> GetAccountKeys(U32 key);
      Task<bool> SubscribeAccountKeys(U32 key);
   }
}
