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
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.RestClient.Generated.Interfaces;
   
   public sealed class IndicesControllerClient : BaseClient, IIndicesControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public IndicesControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BaseTuple<AccountId32, U128, Bool>> GetAccounts(U32 key)
      {
         return await SendRequestAsync<BaseTuple<AccountId32, U128, Bool>>(_httpClient, "indices/accounts", HelloKusama.NetApiExt.Generated.Storage.IndicesStorage.AccountsParams(key));
      }
      public async Task<bool> SubscribeAccounts(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("Indices.Accounts", HelloKusama.NetApiExt.Generated.Storage.IndicesStorage.AccountsParams(key));
      }
   }
}
