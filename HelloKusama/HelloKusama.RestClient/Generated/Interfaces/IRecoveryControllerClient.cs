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
   using HelloKusama.NetApiExt.Generated.Model.pallet_recovery;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.crypto;
   
   public interface IRecoveryControllerClient
   {
      Task<RecoveryConfig> GetRecoverable(AccountId32 key);
      Task<bool> SubscribeRecoverable(AccountId32 key);
      Task<ActiveRecovery> GetActiveRecoveries(Ajuna.NetApi.Model.Types.Base.BaseTuple<AccountId32, AccountId32> key);
      Task<bool> SubscribeActiveRecoveries(Ajuna.NetApi.Model.Types.Base.BaseTuple<AccountId32, AccountId32> key);
      Task<AccountId32> GetProxy(AccountId32 key);
      Task<bool> SubscribeProxy(AccountId32 key);
   }
}