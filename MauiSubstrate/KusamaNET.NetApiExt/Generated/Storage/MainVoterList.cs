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
    
    
    public sealed class VoterListStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public VoterListStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("VoterList", "ListNodes"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(HelloKusama.NetApiExt.Generated.Model.pallet_bags_list.list.Node)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("VoterList", "CounterForListNodes"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("VoterList", "ListBags"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Primitive.U64), typeof(HelloKusama.NetApiExt.Generated.Model.pallet_bags_list.list.Bag)));
        }
        
        /// <summary>
        /// >> ListNodesParams
        ///  A single node, within some bag.
        /// 
        ///  Nodes store links forward and back within their respective bags.
        /// </summary>
        public static string ListNodesParams(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("VoterList", "ListNodes", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ListNodes
        ///  A single node, within some bag.
        /// 
        ///  Nodes store links forward and back within their respective bags.
        /// </summary>
        public async Task<HelloKusama.NetApiExt.Generated.Model.pallet_bags_list.list.Node> ListNodes(HelloKusama.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = VoterListStorage.ListNodesParams(key);
            return await _client.GetStorageAsync<HelloKusama.NetApiExt.Generated.Model.pallet_bags_list.list.Node>(parameters, token);
        }
        
        /// <summary>
        /// >> CounterForListNodesParams
        /// Counter for the related counted storage map
        /// </summary>
        public static string CounterForListNodesParams()
        {
            return RequestGenerator.GetStorage("VoterList", "CounterForListNodes", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CounterForListNodes
        /// Counter for the related counted storage map
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> CounterForListNodes(CancellationToken token)
        {
            string parameters = VoterListStorage.CounterForListNodesParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> ListBagsParams
        ///  A bag stored in storage.
        /// 
        ///  Stores a `Bag` struct, which stores head and tail pointers to itself.
        /// </summary>
        public static string ListBagsParams(Ajuna.NetApi.Model.Types.Primitive.U64 key)
        {
            return RequestGenerator.GetStorage("VoterList", "ListBags", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ListBags
        ///  A bag stored in storage.
        /// 
        ///  Stores a `Bag` struct, which stores head and tail pointers to itself.
        /// </summary>
        public async Task<HelloKusama.NetApiExt.Generated.Model.pallet_bags_list.list.Bag> ListBags(Ajuna.NetApi.Model.Types.Primitive.U64 key, CancellationToken token)
        {
            string parameters = VoterListStorage.ListBagsParams(key);
            return await _client.GetStorageAsync<HelloKusama.NetApiExt.Generated.Model.pallet_bags_list.list.Bag>(parameters, token);
        }
    }
    
    public sealed class VoterListCalls
    {
        
        /// <summary>
        /// >> rebag
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Rebag(HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dislocated)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dislocated.Encode());
            return new Method(39, "VoterList", 0, "rebag", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> put_in_front_of
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method PutInFrontOf(HelloKusama.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress lighter)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(lighter.Encode());
            return new Method(39, "VoterList", 1, "put_in_front_of", byteArray.ToArray());
        }
    }
    
    public enum VoterListErrors
    {
        
        /// <summary>
        /// >> List
        /// A error in the list interface implementation.
        /// </summary>
        List,
    }
}
