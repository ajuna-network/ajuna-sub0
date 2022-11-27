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
    /// IFastUnstakeStorage interface definition.
    /// </summary>
    public interface IFastUnstakeStorage : IStorage
    {
        
        /// <summary>
        /// >> Head
        ///  The current "head of the queue" being unstaked.
        /// </summary>
        HelloKusama.NetApiExt.Generated.Model.pallet_fast_unstake.types.UnstakeRequest GetHead();
        
        /// <summary>
        /// >> Queue
        ///  The map of all accounts wishing to be unstaked.
        /// 
        ///  Keeps track of `AccountId` wishing to unstake and it's corresponding deposit.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U128 GetQueue(string key);
        
        /// <summary>
        /// >> CounterForQueue
        /// Counter for the related counted storage map
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetCounterForQueue();
        
        /// <summary>
        /// >> ErasToCheckPerBlock
        ///  Number of eras to check per block.
        /// 
        ///  If set to 0, this pallet does absolutely nothing.
        /// 
        ///  Based on the amount of weight available at `on_idle`, up to this many eras of a single
        ///  nominator might be checked.
        /// </summary>
        Ajuna.NetApi.Model.Types.Primitive.U32 GetErasToCheckPerBlock();
    }
    
    /// <summary>
    /// FastUnstakeStorage class definition.
    /// </summary>
    public sealed class FastUnstakeStorage : IFastUnstakeStorage
    {
        
        /// <summary>
        /// _headTypedStorage typed storage field
        /// </summary>
        private TypedStorage<HelloKusama.NetApiExt.Generated.Model.pallet_fast_unstake.types.UnstakeRequest> _headTypedStorage;
        
        /// <summary>
        /// _queueTypedStorage typed storage field
        /// </summary>
        private TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U128> _queueTypedStorage;
        
        /// <summary>
        /// _counterForQueueTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _counterForQueueTypedStorage;
        
        /// <summary>
        /// _erasToCheckPerBlockTypedStorage typed storage field
        /// </summary>
        private TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> _erasToCheckPerBlockTypedStorage;
        
        /// <summary>
        /// FastUnstakeStorage constructor.
        /// </summary>
        public FastUnstakeStorage(IStorageDataProvider storageDataProvider, List<IStorageChangeDelegate> storageChangeDelegates)
        {
            this.HeadTypedStorage = new TypedStorage<HelloKusama.NetApiExt.Generated.Model.pallet_fast_unstake.types.UnstakeRequest>("FastUnstake.Head", storageDataProvider, storageChangeDelegates);
            this.QueueTypedStorage = new TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U128>("FastUnstake.Queue", storageDataProvider, storageChangeDelegates);
            this.CounterForQueueTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("FastUnstake.CounterForQueue", storageDataProvider, storageChangeDelegates);
            this.ErasToCheckPerBlockTypedStorage = new TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32>("FastUnstake.ErasToCheckPerBlock", storageDataProvider, storageChangeDelegates);
        }
        
        /// <summary>
        /// _headTypedStorage property
        /// </summary>
        public TypedStorage<HelloKusama.NetApiExt.Generated.Model.pallet_fast_unstake.types.UnstakeRequest> HeadTypedStorage
        {
            get
            {
                return _headTypedStorage;
            }
            set
            {
                _headTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _queueTypedStorage property
        /// </summary>
        public TypedMapStorage<Ajuna.NetApi.Model.Types.Primitive.U128> QueueTypedStorage
        {
            get
            {
                return _queueTypedStorage;
            }
            set
            {
                _queueTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _counterForQueueTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> CounterForQueueTypedStorage
        {
            get
            {
                return _counterForQueueTypedStorage;
            }
            set
            {
                _counterForQueueTypedStorage = value;
            }
        }
        
        /// <summary>
        /// _erasToCheckPerBlockTypedStorage property
        /// </summary>
        public TypedStorage<Ajuna.NetApi.Model.Types.Primitive.U32> ErasToCheckPerBlockTypedStorage
        {
            get
            {
                return _erasToCheckPerBlockTypedStorage;
            }
            set
            {
                _erasToCheckPerBlockTypedStorage = value;
            }
        }
        
        /// <summary>
        /// Connects to all storages and initializes the change subscription handling.
        /// </summary>
        public async Task InitializeAsync(Ajuna.ServiceLayer.Storage.IStorageDataProvider dataProvider)
        {
            await HeadTypedStorage.InitializeAsync("FastUnstake", "Head");
            await QueueTypedStorage.InitializeAsync("FastUnstake", "Queue");
            await CounterForQueueTypedStorage.InitializeAsync("FastUnstake", "CounterForQueue");
            await ErasToCheckPerBlockTypedStorage.InitializeAsync("FastUnstake", "ErasToCheckPerBlock");
        }
        
        /// <summary>
        /// Implements any storage change for FastUnstake.Head
        /// </summary>
        [StorageChange("FastUnstake", "Head")]
        public void OnUpdateHead(string data)
        {
            HeadTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> Head
        ///  The current "head of the queue" being unstaked.
        /// </summary>
        public HelloKusama.NetApiExt.Generated.Model.pallet_fast_unstake.types.UnstakeRequest GetHead()
        {
            return HeadTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for FastUnstake.Queue
        /// </summary>
        [StorageChange("FastUnstake", "Queue")]
        public void OnUpdateQueue(string key, string data)
        {
            QueueTypedStorage.Update(key, data);
        }
        
        /// <summary>
        /// >> Queue
        ///  The map of all accounts wishing to be unstaked.
        /// 
        ///  Keeps track of `AccountId` wishing to unstake and it's corresponding deposit.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U128 GetQueue(string key)
        {
            if ((key == null))
            {
                return null;
            }
            if (QueueTypedStorage.Dictionary.TryGetValue(key, out Ajuna.NetApi.Model.Types.Primitive.U128 result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        
        /// <summary>
        /// Implements any storage change for FastUnstake.CounterForQueue
        /// </summary>
        [StorageChange("FastUnstake", "CounterForQueue")]
        public void OnUpdateCounterForQueue(string data)
        {
            CounterForQueueTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> CounterForQueue
        /// Counter for the related counted storage map
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetCounterForQueue()
        {
            return CounterForQueueTypedStorage.Get();
        }
        
        /// <summary>
        /// Implements any storage change for FastUnstake.ErasToCheckPerBlock
        /// </summary>
        [StorageChange("FastUnstake", "ErasToCheckPerBlock")]
        public void OnUpdateErasToCheckPerBlock(string data)
        {
            ErasToCheckPerBlockTypedStorage.Update(data);
        }
        
        /// <summary>
        /// >> ErasToCheckPerBlock
        ///  Number of eras to check per block.
        /// 
        ///  If set to 0, this pallet does absolutely nothing.
        /// 
        ///  Based on the amount of weight available at `on_idle`, up to this many eras of a single
        ///  nominator might be checked.
        /// </summary>
        public Ajuna.NetApi.Model.Types.Primitive.U32 GetErasToCheckPerBlock()
        {
            return ErasToCheckPerBlockTypedStorage.Get();
        }
    }
}