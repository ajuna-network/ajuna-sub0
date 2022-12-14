//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.ServiceLayer.Attributes;
using HelloKusama.RestService.Generated.Storage;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace HelloKusama.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// ParaInclusionController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class ParaInclusionController : ControllerBase
    {
        
        private IParaInclusionStorage _paraInclusionStorage;
        
        /// <summary>
        /// ParaInclusionController constructor.
        /// </summary>
        public ParaInclusionController(IParaInclusionStorage paraInclusionStorage)
        {
            _paraInclusionStorage = paraInclusionStorage;
        }
        
        /// <summary>
        /// >> AvailabilityBitfields
        ///  The latest bitfield for each validator, referred to by their index in the validator set.
        /// </summary>
        [HttpGet("AvailabilityBitfields")]
        [ProducesResponseType(typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.AvailabilityBitfieldRecord), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.ParaInclusionStorage), "AvailabilityBitfieldsParams", typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex))]
        public IActionResult GetAvailabilityBitfields(string key)
        {
            return this.Ok(_paraInclusionStorage.GetAvailabilityBitfields(key));
        }
        
        /// <summary>
        /// >> PendingAvailability
        ///  Candidates pending availability by `ParaId`.
        /// </summary>
        [HttpGet("PendingAvailability")]
        [ProducesResponseType(typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.CandidatePendingAvailability), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.ParaInclusionStorage), "PendingAvailabilityParams", typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id))]
        public IActionResult GetPendingAvailability(string key)
        {
            return this.Ok(_paraInclusionStorage.GetPendingAvailability(key));
        }
        
        /// <summary>
        /// >> PendingAvailabilityCommitments
        ///  The commitments of candidates pending availability, by `ParaId`.
        /// </summary>
        [HttpGet("PendingAvailabilityCommitments")]
        [ProducesResponseType(typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CandidateCommitments), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.ParaInclusionStorage), "PendingAvailabilityCommitmentsParams", typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id))]
        public IActionResult GetPendingAvailabilityCommitments(string key)
        {
            return this.Ok(_paraInclusionStorage.GetPendingAvailabilityCommitments(key));
        }
    }
}
