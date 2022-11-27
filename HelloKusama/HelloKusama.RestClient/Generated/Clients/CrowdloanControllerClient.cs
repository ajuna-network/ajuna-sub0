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
   using HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_common.crowdloan;
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives;
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.RestClient.Generated.Interfaces;
   
   public sealed class CrowdloanControllerClient : BaseClient, ICrowdloanControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public CrowdloanControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<FundInfo> GetFunds(Id key)
      {
         return await SendRequestAsync<FundInfo>(_httpClient, "crowdloan/funds", HelloKusama.NetApiExt.Generated.Storage.CrowdloanStorage.FundsParams(key));
      }
      public async Task<bool> SubscribeFunds(Id key)
      {
         return await _subscriptionClient.SubscribeAsync("Crowdloan.Funds", HelloKusama.NetApiExt.Generated.Storage.CrowdloanStorage.FundsParams(key));
      }
      public async Task<BaseVec<Id>> GetNewRaise()
      {
         return await SendRequestAsync<BaseVec<Id>>(_httpClient, "crowdloan/newraise");
      }
      public async Task<bool> SubscribeNewRaise()
      {
         return await _subscriptionClient.SubscribeAsync("Crowdloan.NewRaise");
      }
      public async Task<U32> GetEndingsCount()
      {
         return await SendRequestAsync<U32>(_httpClient, "crowdloan/endingscount");
      }
      public async Task<bool> SubscribeEndingsCount()
      {
         return await _subscriptionClient.SubscribeAsync("Crowdloan.EndingsCount");
      }
      public async Task<U32> GetNextFundIndex()
      {
         return await SendRequestAsync<U32>(_httpClient, "crowdloan/nextfundindex");
      }
      public async Task<bool> SubscribeNextFundIndex()
      {
         return await _subscriptionClient.SubscribeAsync("Crowdloan.NextFundIndex");
      }
   }
}