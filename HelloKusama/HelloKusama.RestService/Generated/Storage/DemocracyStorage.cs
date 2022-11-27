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
using Ajuna.ServiceLayer.Storage;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace HelloKusama.RestService.Generated.Storage
{
    
    
    /// <summary>
    /// IDemocracyStorage interface definition.
    /// </summary>
    public interface IDemocracyStorage : IStorage
    {
        
        /// <summary>
        /// >> PublicPropCount
        ///  The number of (public) proposals that have been made so far.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetPublicPropCount();
        
        /// <summary>
        /// >> PublicProps
        ///  The public proposals. Unsorted. The second item is the proposal.
        /// </summary>
        HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT9 GetPublicProps();
        
        /// <summary>
        /// >> DepositOf
        ///  Those who have locked a deposit.
        /// 
        ///  TWOX-NOTE: Safe, as increasing integer keys are safe.
        /// </summary>
        Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT10, Ajuna.NetApi.Model.Types.Primitive.U128> GetDepositOf(string key);
        
        /// <summary>
        /// >> ReferendumCount
        ///  The next free referendum index, aka the number of referenda started so far.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetReferendumCount();
        
        /// <summary>
        /// >> LowestUnbaked
        ///  The lowest referendum index representing an unbaked referendum. Equal to
        ///  `ReferendumCount` if there isn't a unbaked referendum.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetLowestUnbaked();
        
        /// <summary>
        /// >> ReferendumInfoOf
        ///  Information concerning any given referendum.
        /// 
        ///  TWOX-NOTE: SAFE as indexes are not under an attacker���s control.
        /// </summary>
        HelloKusama.NetApiExt.Generated.Model.pallet_democracy.types.EnumReferendumInfo GetReferendumInfoOf(string key);
        
        /// <summary>
        /// >> VotingOf
        ///  All votes for a particular voter. We store the balance for the number of votes that we
        ///  have recorded. The second item is the total amount of delegations, that will be added.
        /// 
        ///  TWOX-NOTE: SAFE as `AccountId`s are crypto hashes anyway.
        /// </summary>
        HelloKusama.NetApiExt.Generated.Model.pallet_democracy.vote.EnumVoting GetVotingOf(string key);
        
        /// <summary>
        /// >> LastTabledWasExternal
        ///  True if the last referendum tabled was submitted externally. False if it was a public
        ///  proposal.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.Bool GetLastTabledWasExternal();
        
        /// <summary>
        /// >> NextExternal
        ///  The referendum to be tabled whenever it would be valid to table an external proposal.
        ///  This happens when a referendum needs to be tabled and one of two conditions are met:
        ///  - `LastTabledWasExternal` is `false`; or
        ///  - `PublicProps` is empty.
        /// </summary>
        Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.frame_support.traits.preimages.EnumBounded, HelloKusama.NetApiExt.Generated.Model.pallet_democracy.vote_threshold.EnumVoteThreshold> GetNextExternal();
        
        /// <summary>
        /// >> Blacklist
        ///  A record of who vetoed what. Maps proposal hash to a possible existent block number
        ///  (until when it may not be resubmitted) and who vetoed it.
        /// </summary>
        Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT10> GetBlacklist(string key);
        
        /// <summary>
        /// >> Cancellations
        ///  Record of all proposals that have been subject to emergency cancellation.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.Bool GetCancellations(string key);
    }
    
    /// <summary>
    /// DemocracyStorage class definition.
    /// </summary>
    public sealed class DemocracyStorage : IDemocracyStorage
    {
        
        /// <summary>
        /// _publicPropCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _publicPropCountTypedStorage;
        
        /// <summary>
        /// _publicPropsTypedStorage typed storage field
        /// </summary>
        private TypedStorage<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT9> _publicPropsTypedStorage;
        
        /// <summary>
        /// _depositOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT10, Ajuna.NetApi.Model.Types.Primitive.U128>> _depositOfTypedStorage;
        
        /// <summary>
        /// _referendumCountTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _referendumCountTypedStorage;
        
        /// <summary>
        /// _lowestUnbakedTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _lowestUnbakedTypedStorage;
        
        /// <summary>
        /// _referendumInfoOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.pallet_democracy.types.EnumReferendumInfo> _referendumInfoOfTypedStorage;
        
        /// <summary>
        /// _votingOfTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.pallet_democracy.vote.EnumVoting> _votingOfTypedStorage;
        
        /// <summary>
        /// _lastTabledWasExternalTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.Bool> _lastTabledWasExternalTypedStorage;
        
        /// <summary>
        /// _nextExternalTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.frame_support.traits.preimages.EnumBounded, HelloKusama.NetApiExt.Generated.Model.pallet_democracy.vote_threshold.EnumVoteThreshold>> _nextExternalTypedStorage;
        
        /// <summary>
        /// _blacklistTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT10>> _blacklistTypedStorage;
        
        /// <summary>
        /// _cancellationsTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.Bool> _cancellationsTypedStorage;
        
        /// <summary>
        /// DemocracyStorage constructor.
        /// </summary>
        public DemocracyStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.PublicPropCountTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("Democracy.PublicPropCount", storageDataProvider, storageChangeDelegates);
            this.PublicPropsTypedStorage = new TypedStorage<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT9>("Democracy.PublicProps", storageDataProvider, storageChangeDelegates);
            this.DepositOfTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT10, Ajuna.NetApi.Model.Types.Primitive.U128>>("Democracy.DepositOf", storageDataProvider, storageChangeDelegates);
            this.ReferendumCountTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("Democracy.ReferendumCount", storageDataProvider, storageChangeDelegates);
            this.LowestUnbakedTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("Democracy.LowestUnbaked", storageDataProvider, storageChangeDelegates);
            this.ReferendumInfoOfTypedStorage = new TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.pallet_democracy.types.EnumReferendumInfo>("Democracy.ReferendumInfoOf", storageDataProvider, storageChangeDelegates);
            this.VotingOfTypedStorage = new TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.pallet_democracy.vote.EnumVoting>("Democracy.VotingOf", storageDataProvider, storageChangeDelegates);
            this.LastTabledWasExternalTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.Bool>("Democracy.LastTabledWasExternal", storageDataProvider, storageChangeDelegates);
            this.NextExternalTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.frame_support.traits.preimages.EnumBounded, HelloKusama.NetApiExt.Generated.Model.pallet_democracy.vote_threshold.EnumVoteThreshold>>("Democracy.NextExternal", storageDataProvider, storageChangeDelegates);
            this.BlacklistTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT10>>("Democracy.Blacklist", storageDataProvider, storageChangeDelegates);
            this.CancellationsTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.Bool>("Democracy.Cancellations", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _publicPropCountTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> PublicPropCountTypedStorage
        {
            get
            {
                return _publicPropCountTypedStorage;
            }
            set
            {
                _publicPropCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _publicPropsTypedStorage property
        /// </summary>
        public TypedStorage<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT9> PublicPropsTypedStorage
        {
            get
            {
                return _publicPropsTypedStorage;
            }
            set
            {
                _publicPropsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _depositOfTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT10, Ajuna.NetApi.Model.Types.Primitive.U128>> DepositOfTypedStorage
        {
            get
            {
                return _depositOfTypedStorage;
            }
            set
            {
                _depositOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _referendumCountTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> ReferendumCountTypedStorage
        {
            get
            {
                return _referendumCountTypedStorage;
            }
            set
            {
                _referendumCountTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _lowestUnbakedTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> LowestUnbakedTypedStorage
        {
            get
            {
                return _lowestUnbakedTypedStorage;
            }
            set
            {
                _lowestUnbakedTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _referendumInfoOfTypedStorage property
        /// </summary>
        public TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.pallet_democracy.types.EnumReferendumInfo> ReferendumInfoOfTypedStorage
        {
            get
            {
                return _referendumInfoOfTypedStorage;
            }
            set
            {
                _referendumInfoOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _votingOfTypedStorage property
        /// </summary>
        public TypedMapStorage<HelloKusama.NetApiExt.Generated.Model.pallet_democracy.vote.EnumVoting> VotingOfTypedStorage
        {
            get
            {
                return _votingOfTypedStorage;
            }
            set
            {
                _votingOfTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _lastTabledWasExternalTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.Bool> LastTabledWasExternalTypedStorage
        {
            get
            {
                return _lastTabledWasExternalTypedStorage;
            }
            set
            {
                _lastTabledWasExternalTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _nextExternalTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.frame_support.traits.preimages.EnumBounded, HelloKusama.NetApiExt.Generated.Model.pallet_democracy.vote_threshold.EnumVoteThreshold>> NextExternalTypedStorage
        {
            get
            {
                return _nextExternalTypedStorage;
            }
            set
            {
                _nextExternalTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _blacklistTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT10>> BlacklistTypedStorage
        {
            get
            {
                return _blacklistTypedStorage;
            }
            set
            {
                _blacklistTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _cancellationsTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.Bool> CancellationsTypedStorage
        {
            get
            {
                return _cancellationsTypedStorage;
            }
            set
            {
                _cancellationsTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await PublicPropCountTypedStorage.InitializeAsync("Democracy", "PublicPropCount");
            await PublicPropsTypedStorage.InitializeAsync("Democracy", "PublicProps");
            await DepositOfTypedStorage.InitializeAsync("Democracy", "DepositOf");
            await ReferendumCountTypedStorage.InitializeAsync("Democracy", "ReferendumCount");
            await LowestUnbakedTypedStorage.InitializeAsync("Democracy", "LowestUnbaked");
            await ReferendumInfoOfTypedStorage.InitializeAsync("Democracy", "ReferendumInfoOf");
            await VotingOfTypedStorage.InitializeAsync("Democracy", "VotingOf");
            await LastTabledWasExternalTypedStorage.InitializeAsync("Democracy", "LastTabledWasExternal");
            await NextExternalTypedStorage.InitializeAsync("Democracy", "NextExternal");
            await BlacklistTypedStorage.InitializeAsync("Democracy", "Blacklist");
            await CancellationsTypedStorage.InitializeAsync("Democracy", "Cancellations");
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.PublicPropCount
        /// </summary>
        [StorageChange("Democracy", "PublicPropCount")]
        public void OnUpdatePublicPropCount(string data)
        {
            PublicPropCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> PublicPropCount
        ///  The number of (public) proposals that have been made so far.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetPublicPropCount()
        {
            return PublicPropCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.PublicProps
        /// </summary>
        [StorageChange("Democracy", "PublicProps")]
        public void OnUpdatePublicProps(string data)
        {
            PublicPropsTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> PublicProps
        ///  The public proposals. Unsorted. The second item is the proposal.
        /// </summary>
        public HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT9 GetPublicProps()
        {
            return PublicPropsTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.DepositOf
        /// </summary>
        [StorageChange("Democracy", "DepositOf")]
        public void OnUpdateDepositOf(string key, string data)
        {
            DepositOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> DepositOf
        ///  Those who have locked a deposit.
        /// 
        ///  TWOX-NOTE: Safe, as increasing integer keys are safe.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT10, Ajuna.NetApi.Model.Types.Primitive.U128> GetDepositOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (DepositOfTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT10, Ajuna.NetApi.Model.Types.Primitive.U128> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.ReferendumCount
        /// </summary>
        [StorageChange("Democracy", "ReferendumCount")]
        public void OnUpdateReferendumCount(string data)
        {
            ReferendumCountTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ReferendumCount
        ///  The next free referendum index, aka the number of referenda started so far.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetReferendumCount()
        {
            return ReferendumCountTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.LowestUnbaked
        /// </summary>
        [StorageChange("Democracy", "LowestUnbaked")]
        public void OnUpdateLowestUnbaked(string data)
        {
            LowestUnbakedTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> LowestUnbaked
        ///  The lowest referendum index representing an unbaked referendum. Equal to
        ///  `ReferendumCount` if there isn't a unbaked referendum.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetLowestUnbaked()
        {
            return LowestUnbakedTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.ReferendumInfoOf
        /// </summary>
        [StorageChange("Democracy", "ReferendumInfoOf")]
        public void OnUpdateReferendumInfoOf(string key, string data)
        {
            ReferendumInfoOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> ReferendumInfoOf
        ///  Information concerning any given referendum.
        /// 
        ///  TWOX-NOTE: SAFE as indexes are not under an attacker���s control.
        /// </summary>
        public HelloKusama.NetApiExt.Generated.Model.pallet_democracy.types.EnumReferendumInfo GetReferendumInfoOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (ReferendumInfoOfTypedStorage.Dictionary.TryGetValue(key, out HelloKusama.NetApiExt.Generated.Model.pallet_democracy.types.EnumReferendumInfo result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.VotingOf
        /// </summary>
        [StorageChange("Democracy", "VotingOf")]
        public void OnUpdateVotingOf(string key, string data)
        {
            VotingOfTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> VotingOf
        ///  All votes for a particular voter. We store the balance for the number of votes that we
        ///  have recorded. The second item is the total amount of delegations, that will be added.
        /// 
        ///  TWOX-NOTE: SAFE as `AccountId`s are crypto hashes anyway.
        /// </summary>
        public HelloKusama.NetApiExt.Generated.Model.pallet_democracy.vote.EnumVoting GetVotingOf(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (VotingOfTypedStorage.Dictionary.TryGetValue(key, out HelloKusama.NetApiExt.Generated.Model.pallet_democracy.vote.EnumVoting result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.LastTabledWasExternal
        /// </summary>
        [StorageChange("Democracy", "LastTabledWasExternal")]
        public void OnUpdateLastTabledWasExternal(string data)
        {
            LastTabledWasExternalTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> LastTabledWasExternal
        ///  True if the last referendum tabled was submitted externally. False if it was a public
        ///  proposal.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.Bool GetLastTabledWasExternal()
        {
            return LastTabledWasExternalTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.NextExternal
        /// </summary>
        [StorageChange("Democracy", "NextExternal")]
        public void OnUpdateNextExternal(string data)
        {
            NextExternalTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> NextExternal
        ///  The referendum to be tabled whenever it would be valid to table an external proposal.
        ///  This happens when a referendum needs to be tabled and one of two conditions are met:
        ///  - `LastTabledWasExternal` is `false`; or
        ///  - `PublicProps` is empty.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Base.BaseTuple<HelloKusama.NetApiExt.Generated.Model.frame_support.traits.preimages.EnumBounded, HelloKusama.NetApiExt.Generated.Model.pallet_democracy.vote_threshold.EnumVoteThreshold> GetNextExternal()
        {
            return NextExternalTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.Blacklist
        /// </summary>
        [StorageChange("Democracy", "Blacklist")]
        public void OnUpdateBlacklist(string key, string data)
        {
            BlacklistTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Blacklist
        ///  A record of who vetoed what. Maps proposal hash to a possible existent block number
        ///  (until when it may not be resubmitted) and who vetoed it.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT10> GetBlacklist(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (BlacklistTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.sp_core.bounded.bounded_vec.BoundedVecT10> result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for Democracy.Cancellations
        /// </summary>
        [StorageChange("Democracy", "Cancellations")]
        public void OnUpdateCancellations(string key, string data)
        {
            CancellationsTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Cancellations
        ///  Record of all proposals that have been subject to emergency cancellation.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.Bool GetCancellations(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (CancellationsTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.Bool result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}