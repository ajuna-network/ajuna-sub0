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
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.validator_app;
   
   public interface IParasSharedControllerMockupClient
   {
      Task<bool> SetCurrentSessionIndex(U32 value);
      Task<bool> SetActiveValidatorIndices(BaseVec<ValidatorIndex> value);
      Task<bool> SetActiveValidatorKeys(BaseVec<Public> value);
   }
}
