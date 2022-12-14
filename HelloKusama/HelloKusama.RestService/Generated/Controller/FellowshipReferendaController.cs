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
    /// FellowshipReferendaController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class FellowshipReferendaController : ControllerBase
    {
        
        private IFellowshipReferendaStorage _fellowshipReferendaStorage;
        
        /// <summary>
        /// FellowshipReferendaController constructor.
        /// </summary>
        public FellowshipReferendaController(IFellowshipReferendaStorage fellowshipReferendaStorage)
        {
            _fellowshipReferendaStorage = fellowshipReferendaStorage;
        }
        
        /// <summary>
        /// >> ReferendumCount
        ///  The next free referendum index, aka the number of referenda started so far.
        /// </summary>
        [HttpGet("ReferendumCount")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.FellowshipReferendaStorage), "ReferendumCountParams")]
        public IActionResult GetReferendumCount()
        {
            return this.Ok(_fellowshipReferendaStorage.GetReferendumCount());
        }
        
        /// <summary>
        /// >> ReferendumInfoFor
        ///  Information concerning any given referendum.
        /// </summary>
        [HttpGet("ReferendumInfoFor")]
        [ProducesResponseType(typeof(HelloKusama.NetApiExt.Generated.Model.pallet_referenda.types.EnumReferendumInfo), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.FellowshipReferendaStorage), "ReferendumInfoForParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U32))]
        public IActionResult GetReferendumInfoFor(string key)
        {
            return this.Ok(_fellowshipReferendaStorage.GetReferendumInfoFor(key));
        }
        
        /// <summary>
        /// >> TrackQueue
        ///  The sorted list of referenda ready to be decided but not yet being decided, ordered by
        ///  conviction-weighted approvals.
        /// 
        ///  This should be empty if `DecidingCount` is less than `TrackInfo::max_deciding`.
        /// </summary>
        [HttpGet("TrackQueue")]
        [ProducesResponseType(typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT20), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.FellowshipReferendaStorage), "TrackQueueParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U16))]
        public IActionResult GetTrackQueue(string key)
        {
            return this.Ok(_fellowshipReferendaStorage.GetTrackQueue(key));
        }
        
        /// <summary>
        /// >> DecidingCount
        ///  The number of referenda being decided currently.
        /// </summary>
        [HttpGet("DecidingCount")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Primitive.U32), 200)]
        [StorageKeyBuilder(typeof(HelloKusama.NetApiExt.Generated.Storage.FellowshipReferendaStorage), "DecidingCountParams", typeof(Ajuna.NetApi.Model.Types.Primitive.U16))]
        public IActionResult GetDecidingCount(string key)
        {
            return this.Ok(_fellowshipReferendaStorage.GetDecidingCount(key));
        }
    }
}
