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
   using HelloKusama.NetApiExt.Generated.Model.pallet_conviction_voting.vote;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   
   public interface IConvictionVotingControllerMockupClient
   {
      Task<bool> SetVotingFor(EnumVoting value, Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U16> key);
      Task<bool> SetClassLocksFor(BoundedVecT17 value, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key);
   }
}
