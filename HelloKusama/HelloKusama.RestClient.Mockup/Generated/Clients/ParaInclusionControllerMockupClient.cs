//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloKusama.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2;
   using HelloKusama.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class ParaInclusionControllerMockupClient : MockupBaseClient, IParaInclusionControllerMockupClient
   {
      private HttpClient _httpClient;
      public ParaInclusionControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetAvailabilityBitfields(AvailabilityBitfieldRecord value, ValidatorIndex key)
      {
         return await SendMockupRequestAsync(_httpClient, "ParaInclusion/AvailabilityBitfields", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.ParaInclusionStorage.AvailabilityBitfieldsParams(key));
      }
      public async Task<bool> SetPendingAvailability(CandidatePendingAvailability value, HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key)
      {
         return await SendMockupRequestAsync(_httpClient, "ParaInclusion/PendingAvailability", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.ParaInclusionStorage.PendingAvailabilityParams(key));
      }
      public async Task<bool> SetPendingAvailabilityCommitments(CandidateCommitments value, HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key)
      {
         return await SendMockupRequestAsync(_httpClient, "ParaInclusion/PendingAvailabilityCommitments", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.ParaInclusionStorage.PendingAvailabilityCommitmentsParams(key));
      }
   }
}