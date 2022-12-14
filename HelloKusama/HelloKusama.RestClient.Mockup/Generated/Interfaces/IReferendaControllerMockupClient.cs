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
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.NetApiExt.Generated.Model.pallet_referenda.types;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec;
   
   public interface IReferendaControllerMockupClient
   {
      Task<bool> SetReferendumCount(U32 value);
      Task<bool> SetReferendumInfoFor(EnumReferendumInfo value, U32 key);
      Task<bool> SetTrackQueue(BoundedVecT18 value, U16 key);
      Task<bool> SetDecidingCount(U32 value, U16 key);
   }
}
