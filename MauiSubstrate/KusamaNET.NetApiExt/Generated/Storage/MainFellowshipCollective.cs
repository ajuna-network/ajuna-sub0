//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace HelloKusama.NetApiExt.Generated.Storage
{
    
    
    public sealed class FellowshipCollectiveStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public FellowshipCollectiveStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FellowshipCollective", "MemberCount"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Primitive.U16), typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FellowshipCollective", "Members"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(HelloKusama.NetApiExt.Generated.Model.pallet_ranked_collective.MemberRecord)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FellowshipCollective", "IdToIndex"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U16, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>), typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FellowshipCollective", "IndexToId"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U16, Ajuna.NetApi.Model.Types.Primitive.U32>), typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FellowshipCollective", "Voting"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>), typeof(HelloKusama.NetApiExt.Generated.Model.pallet_ranked_collective.EnumVoteRecord)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FellowshipCollective", "VotingCleanup"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Ajuna.NetApi.Model.Types.Primitive.U32), typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT19)));
        }
        
        /// <summary>
        /// >> MemberCountParams
        ///  The number of members in the collective who have at least the rank according to the index
        ///  of the vec.
        /// </summary>
        public static string MemberCountParams(Ajuna.NetApi.Model.Types.Primitive.U16 key)
        {
            return RequestGenerator.GetStorage("FellowshipCollective", "MemberCount", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> MemberCount
        ///  The number of members in the collective who have at least the rank according to the index
        ///  of the vec.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> MemberCount(Ajuna.NetApi.Model.Types.Primitive.U16 key, CancellationToken token)
        {
            string parameters = FellowshipCollectiveStorage.MemberCountParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> MembersParams
        ///  The current members of the collective.
        /// </summary>
        public static string MembersParams(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("FellowshipCollective", "Members", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Members
        ///  The current members of the collective.
        /// </summary>
        public async Task<HelloKusama.NetApiExt.Generated.Model.pallet_ranked_collective.MemberRecord> Members(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = FellowshipCollectiveStorage.MembersParams(key);
            return await _client.GetStorageAsync<HelloKusama.NetApiExt.Generated.Model.pallet_ranked_collective.MemberRecord>(parameters, token);
        }
        
        /// <summary>
        /// >> IdToIndexParams
        ///  The index of each ranks's member into the group of members who have at least that rank.
        /// </summary>
        public static string IdToIndexParams(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U16, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key)
        {
            return RequestGenerator.GetStorage("FellowshipCollective", "IdToIndex", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> IdToIndex
        ///  The index of each ranks's member into the group of members who have at least that rank.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> IdToIndex(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U16, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key, CancellationToken token)
        {
            string parameters = FellowshipCollectiveStorage.IdToIndexParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> IndexToIdParams
        ///  The members in the collective by index. All indices in the range `0..MemberCount` will
        ///  return `Some`, however a member's index is not guaranteed to remain unchanged over time.
        /// </summary>
        public static string IndexToIdParams(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U16, Ajuna.NetApi.Model.Types.Primitive.U32> key)
        {
            return RequestGenerator.GetStorage("FellowshipCollective", "IndexToId", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> IndexToId
        ///  The members in the collective by index. All indices in the range `0..MemberCount` will
        ///  return `Some`, however a member's index is not guaranteed to remain unchanged over time.
        /// </summary>
        public async Task<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> IndexToId(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U16, Ajuna.NetApi.Model.Types.Primitive.U32> key, CancellationToken token)
        {
            string parameters = FellowshipCollectiveStorage.IndexToIdParams(key);
            return await _client.GetStorageAsync<HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>(parameters, token);
        }
        
        /// <summary>
        /// >> VotingParams
        ///  Votes on a given proposal, if it is ongoing.
        /// </summary>
        public static string VotingParams(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key)
        {
            return RequestGenerator.GetStorage("FellowshipCollective", "Voting", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> Voting
        ///  Votes on a given proposal, if it is ongoing.
        /// </summary>
        public async Task<HelloKusama.NetApiExt.Generated.Model.pallet_ranked_collective.EnumVoteRecord> Voting(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key, CancellationToken token)
        {
            string parameters = FellowshipCollectiveStorage.VotingParams(key);
            return await _client.GetStorageAsync<HelloKusama.NetApiExt.Generated.Model.pallet_ranked_collective.EnumVoteRecord>(parameters, token);
        }
        
        /// <summary>
        /// >> VotingCleanupParams
        /// </summary>
        public static string VotingCleanupParams(Ajuna.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("FellowshipCollective", "VotingCleanup", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> VotingCleanup
        /// </summary>
        public async Task<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT19> VotingCleanup(Ajuna.NetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = FellowshipCollectiveStorage.VotingCleanupParams(key);
            return await _client.GetStorageAsync<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT19>(parameters, token);
        }
    }
    
    public sealed class FellowshipCollectiveCalls
    {
        
        /// <summary>
        /// >> add_member
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method AddMember(HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(22, "FellowshipCollective", 0, "add_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> promote_member
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method PromoteMember(HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(22, "FellowshipCollective", 1, "promote_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> demote_member
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method DemoteMember(HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(22, "FellowshipCollective", 2, "demote_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_member
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveMember(HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who, Ajuna.NetApi.Model.Types.Primitive.U16 min_rank)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(min_rank.Encode());
            return new Method(22, "FellowshipCollective", 3, "remove_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> vote
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Vote(Ajuna.NetApi.Model.Types.Primitive.U32 poll, Ajuna.NetApi.Model.Types.Primitive.Bool aye)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(poll.Encode());
            byteArray.AddRange(aye.Encode());
            return new Method(22, "FellowshipCollective", 4, "vote", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> cleanup_poll
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CleanupPoll(Ajuna.NetApi.Model.Types.Primitive.U32 poll_index, Ajuna.NetApi.Model.Types.Primitive.U32 max)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(poll_index.Encode());
            byteArray.AddRange(max.Encode());
            return new Method(22, "FellowshipCollective", 5, "cleanup_poll", byteArray.ToArray());
        }
    }
    
    public enum FellowshipCollectiveErrors
    {
        
        /// <summary>
        /// >> AlreadyMember
        /// Account is already a member.
        /// </summary>
        AlreadyMember,
        
        /// <summary>
        /// >> NotMember
        /// Account is not a member.
        /// </summary>
        NotMember,
        
        /// <summary>
        /// >> NotPolling
        /// The given poll index is unknown or has closed.
        /// </summary>
        NotPolling,
        
        /// <summary>
        /// >> Ongoing
        /// The given poll is still ongoing.
        /// </summary>
        Ongoing,
        
        /// <summary>
        /// >> NoneRemaining
        /// There are no further records to be removed.
        /// </summary>
        NoneRemaining,
        
        /// <summary>
        /// >> Corruption
        /// Unexpected error in state.
        /// </summary>
        Corruption,
        
        /// <summary>
        /// >> RankTooLow
        /// The member's rank is too low to vote.
        /// </summary>
        RankTooLow,
        
        /// <summary>
        /// >> InvalidWitness
        /// The information provided is incorrect.
        /// </summary>
        InvalidWitness,
        
        /// <summary>
        /// >> NoPermission
        /// The origin is not sufficiently privileged to do the operation.
        /// </summary>
        NoPermission,
    }
}
