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
   using HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.assignment_app;
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.crypto;
   
   public interface IParaSessionInfoControllerMockupClient
   {
      Task<bool> SetAssignmentKeysUnsafe(BaseVec<Public> value);
      Task<bool> SetEarliestStoredSession(U32 value);
      Task<bool> SetSessions(SessionInfo value, U32 key);
      Task<bool> SetAccountKeys(BaseVec<AccountId32> value, U32 key);
   }
}
