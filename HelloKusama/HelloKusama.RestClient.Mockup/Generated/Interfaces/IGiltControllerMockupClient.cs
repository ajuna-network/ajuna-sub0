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
   using HelloKusama.NetApiExt.Generated.Model.pallet_gilt.pallet;
   
   public interface IGiltControllerMockupClient
   {
      Task<bool> SetQueueTotals(BoundedVecT31 value);
      Task<bool> SetQueues(BoundedVecT32 value, Ajuna.NetApi.Model.Types.Primitive.U32 key);
      Task<bool> SetActiveTotal(ActiveGiltsTotal value);
      Task<bool> SetActive(ActiveGilt value, Ajuna.NetApi.Model.Types.Primitive.U32 key);
   }
}