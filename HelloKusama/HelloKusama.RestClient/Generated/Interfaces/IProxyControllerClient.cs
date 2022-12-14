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
   using HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IProxyControllerClient
   {
      Task<BaseTuple<BoundedVecT27, U128>> GetProxies(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeProxies(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<BaseTuple<BoundedVecT28, U128>> GetAnnouncements(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeAnnouncements(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
   }
}
