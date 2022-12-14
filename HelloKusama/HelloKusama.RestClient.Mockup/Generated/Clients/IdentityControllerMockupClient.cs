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
   using HelloKusama.NetApiExt.Generated.Model.pallet_identity.types;
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using HelloKusama.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class IdentityControllerMockupClient : MockupBaseClient, IIdentityControllerMockupClient
   {
      private HttpClient _httpClient;
      public IdentityControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetIdentityOf(Registration value, AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Identity/IdentityOf", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.IdentityStorage.IdentityOfParams(key));
      }
      public async Task<bool> SetSuperOf(BaseTuple<AccountId32, EnumData> value, AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Identity/SuperOf", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.IdentityStorage.SuperOfParams(key));
      }
      public async Task<bool> SetSubsOf(BaseTuple<U128, BoundedVecT22> value, AccountId32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "Identity/SubsOf", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.IdentityStorage.SubsOfParams(key));
      }
      public async Task<bool> SetRegistrars(BoundedVecT23 value)
      {
         return await SendMockupRequestAsync(_httpClient, "Identity/Registrars", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.IdentityStorage.RegistrarsParams());
      }
   }
}
