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
   using HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using HelloKusama.NetApiExt.Generated.Model.pallet_gilt.pallet;
   using HelloKusama.RestClient.Generated.Interfaces;
   
   public sealed class GiltControllerClient : BaseClient, IGiltControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public GiltControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BoundedVecT31> GetQueueTotals()
      {
         return await SendRequestAsync<BoundedVecT31>(_httpClient, "gilt/queuetotals");
      }
      public async Task<bool> SubscribeQueueTotals()
      {
         return await _subscriptionClient.SubscribeAsync("Gilt.QueueTotals");
      }
      public async Task<BoundedVecT32> GetQueues(Ajuna.NetApi.Model.Types.Primitive.U32 key)
      {
         return await SendRequestAsync<BoundedVecT32>(_httpClient, "gilt/queues", HelloKusama.NetApiExt.Generated.Storage.GiltStorage.QueuesParams(key));
      }
      public async Task<bool> SubscribeQueues(Ajuna.NetApi.Model.Types.Primitive.U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Gilt.Queues", HelloKusama.NetApiExt.Generated.Storage.GiltStorage.QueuesParams(key));
      }
      public async Task<ActiveGiltsTotal> GetActiveTotal()
      {
         return await SendRequestAsync<ActiveGiltsTotal>(_httpClient, "gilt/activetotal");
      }
      public async Task<bool> SubscribeActiveTotal()
      {
         return await _subscriptionClient.SubscribeAsync("Gilt.ActiveTotal");
      }
      public async Task<ActiveGilt> GetActive(Ajuna.NetApi.Model.Types.Primitive.U32 key)
      {
         return await SendRequestAsync<ActiveGilt>(_httpClient, "gilt/active", HelloKusama.NetApiExt.Generated.Storage.GiltStorage.ActiveParams(key));
      }
      public async Task<bool> SubscribeActive(Ajuna.NetApi.Model.Types.Primitive.U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Gilt.Active", HelloKusama.NetApiExt.Generated.Storage.GiltStorage.ActiveParams(key));
      }
   }
}
