//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloKusama.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2;
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.RestClient.Generated.Interfaces;
   
   public sealed class ParasDisputesControllerClient : BaseClient, IParasDisputesControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public ParasDisputesControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<U32> GetLastPrunedSession()
      {
         return await SendRequestAsync<U32>(_httpClient, "parasdisputes/lastprunedsession");
      }
      public async Task<bool> SubscribeLastPrunedSession()
      {
         return await _subscriptionClient.SubscribeAsync("ParasDisputes.LastPrunedSession");
      }
      public async Task<DisputeState> GetDisputes(BaseTuple<U32, HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash> key)
      {
         return await SendRequestAsync<DisputeState>(_httpClient, "parasdisputes/disputes", HelloKusama.NetApiExt.Generated.Storage.ParasDisputesStorage.DisputesParams(key));
      }
      public async Task<bool> SubscribeDisputes(BaseTuple<U32, HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash> key)
      {
         return await _subscriptionClient.SubscribeAsync("ParasDisputes.Disputes", HelloKusama.NetApiExt.Generated.Storage.ParasDisputesStorage.DisputesParams(key));
      }
      public async Task<U32> GetIncluded(BaseTuple<U32, HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash> key)
      {
         return await SendRequestAsync<U32>(_httpClient, "parasdisputes/included", HelloKusama.NetApiExt.Generated.Storage.ParasDisputesStorage.IncludedParams(key));
      }
      public async Task<bool> SubscribeIncluded(BaseTuple<U32, HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash> key)
      {
         return await _subscriptionClient.SubscribeAsync("ParasDisputes.Included", HelloKusama.NetApiExt.Generated.Storage.ParasDisputesStorage.IncludedParams(key));
      }
      public async Task<BaseVec<U32>> GetSpamSlots(U32 key)
      {
         return await SendRequestAsync<BaseVec<U32>>(_httpClient, "parasdisputes/spamslots", HelloKusama.NetApiExt.Generated.Storage.ParasDisputesStorage.SpamSlotsParams(key));
      }
      public async Task<bool> SubscribeSpamSlots(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("ParasDisputes.SpamSlots", HelloKusama.NetApiExt.Generated.Storage.ParasDisputesStorage.SpamSlotsParams(key));
      }
      public async Task<BaseOpt<U32>> GetFrozen()
      {
         return await SendRequestAsync<BaseOpt<U32>>(_httpClient, "parasdisputes/frozen");
      }
      public async Task<bool> SubscribeFrozen()
      {
         return await _subscriptionClient.SubscribeAsync("ParasDisputes.Frozen");
      }
   }
}
