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
   using HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IAuthorshipControllerMockupClient
   {
      Task<bool> SetUncles(BoundedVecT5 value);
      Task<bool> SetAuthor(AccountId32 value);
      Task<bool> SetDidSetUncles(Bool value);
   }
}
