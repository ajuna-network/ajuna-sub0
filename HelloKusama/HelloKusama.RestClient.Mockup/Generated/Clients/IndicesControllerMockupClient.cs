//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloKusama.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class IndicesControllerMockupClient : MockupBaseClient, IIndicesControllerMockupClient
   {
      private HttpClient _httpClient;
      public IndicesControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetAccounts(BaseTuple<AccountId32, U128, Bool> value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Indices/Accounts", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.IndicesStorage.AccountsParams(key));
      }
   }
}
