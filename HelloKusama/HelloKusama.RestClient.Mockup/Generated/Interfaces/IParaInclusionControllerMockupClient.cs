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
   using HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2;
   
   public interface IParaInclusionControllerMockupClient
   {
      Task<bool> SetAvailabilityBitfields(AvailabilityBitfieldRecord value, ValidatorIndex key);
      Task<bool> SetPendingAvailability(CandidatePendingAvailability value, HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key);
      Task<bool> SetPendingAvailabilityCommitments(CandidateCommitments value, HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key);
   }
}
