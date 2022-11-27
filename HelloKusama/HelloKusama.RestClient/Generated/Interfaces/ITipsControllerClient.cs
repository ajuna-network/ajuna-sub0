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
   using HelloKusama.NetApiExt.Generated.Model.pallet_tips;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface ITipsControllerClient
   {
      Task<OpenTip> GetTips(HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<bool> SubscribeTips(HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<BaseVec<U8>> GetReasons(HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 key);
      Task<bool> SubscribeReasons(HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 key);
   }
}