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
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.NetApiExt.Generated.Model.pallet_referenda.types;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   
   public interface IFellowshipReferendaControllerClient
   {
      Task<U32> GetReferendumCount();
      Task<bool> SubscribeReferendumCount();
      Task<EnumReferendumInfo> GetReferendumInfoFor(U32 key);
      Task<bool> SubscribeReferendumInfoFor(U32 key);
      Task<BoundedVecT20> GetTrackQueue(U16 key);
      Task<bool> SubscribeTrackQueue(U16 key);
      Task<U32> GetDecidingCount(U16 key);
      Task<bool> SubscribeDecidingCount(U16 key);
   }
}
