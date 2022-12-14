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
   using HelloKusama.NetApiExt.Generated.Model.sp_staking.offence;
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.NetApiExt.Generated.Model.primitive_types;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IOffencesControllerClient
   {
      Task<OffenceDetails> GetReports(H256 key);
      Task<bool> SubscribeReports(H256 key);
      Task<BaseVec<H256>> GetConcurrentReportsIndex(BaseTuple<HelloKusama.NetApiExt.Generated.Types.Base.Arr16U8, BaseVec<U8>> key);
      Task<bool> SubscribeConcurrentReportsIndex(BaseTuple<HelloKusama.NetApiExt.Generated.Types.Base.Arr16U8, BaseVec<U8>> key);
      Task<BaseVec<U8>> GetReportsByKindIndex(HelloKusama.NetApiExt.Generated.Types.Base.Arr16U8 key);
      Task<bool> SubscribeReportsByKindIndex(HelloKusama.NetApiExt.Generated.Types.Base.Arr16U8 key);
   }
}
