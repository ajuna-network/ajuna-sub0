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
   using HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.configuration;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IConfigurationControllerMockupClient
   {
      Task<bool> SetActiveConfig(HostConfiguration value);
      Task<bool> SetPendingConfigs(BaseVec<BaseTuple<U32, HostConfiguration>> value);
      Task<bool> SetBypassConsistencyCheck(Bool value);
   }
}