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
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.NetApiExt.Generated.Model.pallet_election_provider_multi_phase;
   using HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_btree_map;
   using HelloKusama.NetApiExt.Generated.Model.pallet_election_provider_multi_phase.signed;
   using HelloKusama.NetApiExt.Generated.Model.sp_npos_elections;
   using HelloKusama.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class ElectionProviderMultiPhaseControllerMockupClient : MockupBaseClient, IElectionProviderMultiPhaseControllerMockupClient
   {
      private HttpClient _httpClient;
      public ElectionProviderMultiPhaseControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetRound(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/Round", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.ElectionProviderMultiPhaseStorage.RoundParams());
      }
      public async Task<bool> SetCurrentPhase(EnumPhase value)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/CurrentPhase", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.ElectionProviderMultiPhaseStorage.CurrentPhaseParams());
      }
      public async Task<bool> SetQueuedSolution(ReadySolution value)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/QueuedSolution", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.ElectionProviderMultiPhaseStorage.QueuedSolutionParams());
      }
      public async Task<bool> SetSnapshot(RoundSnapshot value)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/Snapshot", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.ElectionProviderMultiPhaseStorage.SnapshotParams());
      }
      public async Task<bool> SetDesiredTargets(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/DesiredTargets", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.ElectionProviderMultiPhaseStorage.DesiredTargetsParams());
      }
      public async Task<bool> SetSnapshotMetadata(SolutionOrSnapshotSize value)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/SnapshotMetadata", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.ElectionProviderMultiPhaseStorage.SnapshotMetadataParams());
      }
      public async Task<bool> SetSignedSubmissionNextIndex(U32 value)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/SignedSubmissionNextIndex", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.ElectionProviderMultiPhaseStorage.SignedSubmissionNextIndexParams());
      }
      public async Task<bool> SetSignedSubmissionIndices(BoundedBTreeMapT1 value)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/SignedSubmissionIndices", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.ElectionProviderMultiPhaseStorage.SignedSubmissionIndicesParams());
      }
      public async Task<bool> SetSignedSubmissionsMap(SignedSubmission value, U32 key)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/SignedSubmissionsMap", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.ElectionProviderMultiPhaseStorage.SignedSubmissionsMapParams(key));
      }
      public async Task<bool> SetMinimumUntrustedScore(ElectionScore value)
      {
         return await SendMockupRequestAsync(_httpClient, "ElectionProviderMultiPhase/MinimumUntrustedScore", value.Encode(), HelloKusama.NetApiExt.Generated.Storage.ElectionProviderMultiPhaseStorage.MinimumUntrustedScoreParams());
      }
   }
}