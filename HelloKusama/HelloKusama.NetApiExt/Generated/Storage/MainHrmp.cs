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
    
    
    public sealed class HrmpStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public HrmpStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Hrmp", "HrmpOpenChannelRequests"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId), typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.hrmp.HrmpOpenChannelRequest)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Hrmp", "HrmpOpenChannelRequestsList"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Hrmp", "HrmpOpenChannelRequestCount"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id), typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Hrmp", "HrmpAcceptedChannelRequestCount"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id), typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Hrmp", "HrmpCloseChannelRequests"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId), typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Hrmp", "HrmpCloseChannelRequestsList"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Hrmp", "HrmpWatermarks"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id), typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Hrmp", "HrmpChannels"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId), typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.hrmp.HrmpChannel)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Hrmp", "HrmpIngressChannelsIndex"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id), typeof(Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Hrmp", "HrmpEgressChannelsIndex"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id), typeof(Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Hrmp", "HrmpChannelContents"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId), typeof(Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.InboundHrmpMessage>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Hrmp", "HrmpChannelDigests"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id), typeof(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id>>>)));
        }
        
        /// <summary>
        /// >> HrmpOpenChannelRequestsParams
        ///  The set of pending HRMP open channel requests.
        /// 
        ///  The set is accompanied by a list for iteration.
        /// 
        ///  Invariant:
        ///  - There are no channels that exists in list but not in the set and vice versa.
        /// </summary>
        public static string HrmpOpenChannelRequestsParams(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId key)
        {
            return RequestGenerator.GetStorage("Hrmp", "HrmpOpenChannelRequests", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> HrmpOpenChannelRequests
        ///  The set of pending HRMP open channel requests.
        /// 
        ///  The set is accompanied by a list for iteration.
        /// 
        ///  Invariant:
        ///  - There are no channels that exists in list but not in the set and vice versa.
        /// </summary>
        public async Task<HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.hrmp.HrmpOpenChannelRequest> HrmpOpenChannelRequests(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId key, CancellationToken token)
        {
            string parameters = HrmpStorage.HrmpOpenChannelRequestsParams(key);
            return await _client.GetStorageAsync<HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.hrmp.HrmpOpenChannelRequest>(parameters, token);
        }
        
        /// <summary>
        /// >> HrmpOpenChannelRequestsListParams
        /// </summary>
        public static string HrmpOpenChannelRequestsListParams()
        {
            return RequestGenerator.GetStorage("Hrmp", "HrmpOpenChannelRequestsList", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> HrmpOpenChannelRequestsList
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId>> HrmpOpenChannelRequestsList(CancellationToken token)
        {
            string parameters = HrmpStorage.HrmpOpenChannelRequestsListParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId>>(parameters, token);
        }
        
        /// <summary>
        /// >> HrmpOpenChannelRequestCountParams
        ///  This mapping tracks how many open channel requests are initiated by a given sender para.
        ///  Invariant: `HrmpOpenChannelRequests` should contain the same number of items that has
        ///  `(X, _)` as the number of `HrmpOpenChannelRequestCount` for `X`.
        /// </summary>
        public static string HrmpOpenChannelRequestCountParams(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key)
        {
            return RequestGenerator.GetStorage("Hrmp", "HrmpOpenChannelRequestCount", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> HrmpOpenChannelRequestCount
        ///  This mapping tracks how many open channel requests are initiated by a given sender para.
        ///  Invariant: `HrmpOpenChannelRequests` should contain the same number of items that has
        ///  `(X, _)` as the number of `HrmpOpenChannelRequestCount` for `X`.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> HrmpOpenChannelRequestCount(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key, CancellationToken token)
        {
            string parameters = HrmpStorage.HrmpOpenChannelRequestCountParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> HrmpAcceptedChannelRequestCountParams
        ///  This mapping tracks how many open channel requests were accepted by a given recipient para.
        ///  Invariant: `HrmpOpenChannelRequests` should contain the same number of items `(_, X)` with
        ///  `confirmed` set to true, as the number of `HrmpAcceptedChannelRequestCount` for `X`.
        /// </summary>
        public static string HrmpAcceptedChannelRequestCountParams(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key)
        {
            return RequestGenerator.GetStorage("Hrmp", "HrmpAcceptedChannelRequestCount", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> HrmpAcceptedChannelRequestCount
        ///  This mapping tracks how many open channel requests were accepted by a given recipient para.
        ///  Invariant: `HrmpOpenChannelRequests` should contain the same number of items `(_, X)` with
        ///  `confirmed` set to true, as the number of `HrmpAcceptedChannelRequestCount` for `X`.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> HrmpAcceptedChannelRequestCount(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key, CancellationToken token)
        {
            string parameters = HrmpStorage.HrmpAcceptedChannelRequestCountParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> HrmpCloseChannelRequestsParams
        ///  A set of pending HRMP close channel requests that are going to be closed during the session
        ///  change. Used for checking if a given channel is registered for closure.
        /// 
        ///  The set is accompanied by a list for iteration.
        /// 
        ///  Invariant:
        ///  - There are no channels that exists in list but not in the set and vice versa.
        /// </summary>
        public static string HrmpCloseChannelRequestsParams(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId key)
        {
            return RequestGenerator.GetStorage("Hrmp", "HrmpCloseChannelRequests", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> HrmpCloseChannelRequests
        ///  A set of pending HRMP close channel requests that are going to be closed during the session
        ///  change. Used for checking if a given channel is registered for closure.
        /// 
        ///  The set is accompanied by a list for iteration.
        /// 
        ///  Invariant:
        ///  - There are no channels that exists in list but not in the set and vice versa.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Base.BaseTuple> HrmpCloseChannelRequests(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId key, CancellationToken token)
        {
            string parameters = HrmpStorage.HrmpCloseChannelRequestsParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Base.BaseTuple>(parameters, token);
        }
        
        /// <summary>
        /// >> HrmpCloseChannelRequestsListParams
        /// </summary>
        public static string HrmpCloseChannelRequestsListParams()
        {
            return RequestGenerator.GetStorage("Hrmp", "HrmpCloseChannelRequestsList", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> HrmpCloseChannelRequestsList
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId>> HrmpCloseChannelRequestsList(CancellationToken token)
        {
            string parameters = HrmpStorage.HrmpCloseChannelRequestsListParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId>>(parameters, token);
        }
        
        /// <summary>
        /// >> HrmpWatermarksParams
        ///  The HRMP watermark associated with each para.
        ///  Invariant:
        ///  - each para `P` used here as a key should satisfy `Paras::is_valid_para(P)` within a session.
        /// </summary>
        public static string HrmpWatermarksParams(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key)
        {
            return RequestGenerator.GetStorage("Hrmp", "HrmpWatermarks", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> HrmpWatermarks
        ///  The HRMP watermark associated with each para.
        ///  Invariant:
        ///  - each para `P` used here as a key should satisfy `Paras::is_valid_para(P)` within a session.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> HrmpWatermarks(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key, CancellationToken token)
        {
            string parameters = HrmpStorage.HrmpWatermarksParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> HrmpChannelsParams
        ///  HRMP channel data associated with each para.
        ///  Invariant:
        ///  - each participant in the channel should satisfy `Paras::is_valid_para(P)` within a session.
        /// </summary>
        public static string HrmpChannelsParams(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId key)
        {
            return RequestGenerator.GetStorage("Hrmp", "HrmpChannels", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> HrmpChannels
        ///  HRMP channel data associated with each para.
        ///  Invariant:
        ///  - each participant in the channel should satisfy `Paras::is_valid_para(P)` within a session.
        /// </summary>
        public async Task<HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.hrmp.HrmpChannel> HrmpChannels(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId key, CancellationToken token)
        {
            string parameters = HrmpStorage.HrmpChannelsParams(key);
            return await _client.GetStorageAsync<HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.hrmp.HrmpChannel>(parameters, token);
        }
        
        /// <summary>
        /// >> HrmpIngressChannelsIndexParams
        ///  Ingress/egress indexes allow to find all the senders and receivers given the opposite side.
        ///  I.e.
        /// 
        ///  (a) ingress index allows to find all the senders for a given recipient.
        ///  (b) egress index allows to find all the recipients for a given sender.
        /// 
        ///  Invariants:
        ///  - for each ingress index entry for `P` each item `I` in the index should present in
        ///    `HrmpChannels` as `(I, P)`.
        ///  - for each egress index entry for `P` each item `E` in the index should present in
        ///    `HrmpChannels` as `(P, E)`.
        ///  - there should be no other dangling channels in `HrmpChannels`.
        ///  - the vectors are sorted.
        /// </summary>
        public static string HrmpIngressChannelsIndexParams(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key)
        {
            return RequestGenerator.GetStorage("Hrmp", "HrmpIngressChannelsIndex", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> HrmpIngressChannelsIndex
        ///  Ingress/egress indexes allow to find all the senders and receivers given the opposite side.
        ///  I.e.
        /// 
        ///  (a) ingress index allows to find all the senders for a given recipient.
        ///  (b) egress index allows to find all the recipients for a given sender.
        /// 
        ///  Invariants:
        ///  - for each ingress index entry for `P` each item `I` in the index should present in
        ///    `HrmpChannels` as `(I, P)`.
        ///  - for each egress index entry for `P` each item `E` in the index should present in
        ///    `HrmpChannels` as `(P, E)`.
        ///  - there should be no other dangling channels in `HrmpChannels`.
        ///  - the vectors are sorted.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id>> HrmpIngressChannelsIndex(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key, CancellationToken token)
        {
            string parameters = HrmpStorage.HrmpIngressChannelsIndexParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id>>(parameters, token);
        }
        
        /// <summary>
        /// >> HrmpEgressChannelsIndexParams
        /// </summary>
        public static string HrmpEgressChannelsIndexParams(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key)
        {
            return RequestGenerator.GetStorage("Hrmp", "HrmpEgressChannelsIndex", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> HrmpEgressChannelsIndex
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id>> HrmpEgressChannelsIndex(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key, CancellationToken token)
        {
            string parameters = HrmpStorage.HrmpEgressChannelsIndexParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id>>(parameters, token);
        }
        
        /// <summary>
        /// >> HrmpChannelContentsParams
        ///  Storage for the messages for each channel.
        ///  Invariant: cannot be non-empty if the corresponding channel in `HrmpChannels` is `None`.
        /// </summary>
        public static string HrmpChannelContentsParams(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId key)
        {
            return RequestGenerator.GetStorage("Hrmp", "HrmpChannelContents", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> HrmpChannelContents
        ///  Storage for the messages for each channel.
        ///  Invariant: cannot be non-empty if the corresponding channel in `HrmpChannels` is `None`.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.InboundHrmpMessage>> HrmpChannelContents(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId key, CancellationToken token)
        {
            string parameters = HrmpStorage.HrmpChannelContentsParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.InboundHrmpMessage>>(parameters, token);
        }
        
        /// <summary>
        /// >> HrmpChannelDigestsParams
        ///  Maintains a mapping that can be used to answer the question: What paras sent a message at
        ///  the given block number for a given receiver. Invariants:
        ///  - The inner `Vec<ParaId>` is never empty.
        ///  - The inner `Vec<ParaId>` cannot store two same `ParaId`.
        ///  - The outer vector is sorted ascending by block number and cannot store two items with the
        ///    same block number.
        /// </summary>
        public static string HrmpChannelDigestsParams(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key)
        {
            return RequestGenerator.GetStorage("Hrmp", "HrmpChannelDigests", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> HrmpChannelDigests
        ///  Maintains a mapping that can be used to answer the question: What paras sent a message at
        ///  the given block number for a given receiver. Invariants:
        ///  - The inner `Vec<ParaId>` is never empty.
        ///  - The inner `Vec<ParaId>` cannot store two same `ParaId`.
        ///  - The outer vector is sorted ascending by block number and cannot store two items with the
        ///    same block number.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id>>>> HrmpChannelDigests(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id key, CancellationToken token)
        {
            string parameters = HrmpStorage.HrmpChannelDigestsParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id>>>>(parameters, token);
        }
    }
    
    public sealed class HrmpCalls
    {
        
        /// <summary>
        /// >> hrmp_init_open_channel
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method HrmpInitOpenChannel(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id recipient, Ajuna.NetApi.Model.Types.Primitive.U32 proposed_max_capacity, Ajuna.NetApi.Model.Types.Primitive.U32 proposed_max_message_size)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(recipient.Encode());
            byteArray.AddRange(proposed_max_capacity.Encode());
            byteArray.AddRange(proposed_max_message_size.Encode());
            return new Method(60, "Hrmp", 0, "hrmp_init_open_channel", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> hrmp_accept_open_channel
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method HrmpAcceptOpenChannel(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id sender)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(sender.Encode());
            return new Method(60, "Hrmp", 1, "hrmp_accept_open_channel", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> hrmp_close_channel
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method HrmpCloseChannel(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId channel_id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(channel_id.Encode());
            return new Method(60, "Hrmp", 2, "hrmp_close_channel", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_clean_hrmp
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceCleanHrmp(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id para, Ajuna.NetApi.Model.Types.Primitive.U32 inbound, Ajuna.NetApi.Model.Types.Primitive.U32 outbound)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(para.Encode());
            byteArray.AddRange(inbound.Encode());
            byteArray.AddRange(outbound.Encode());
            return new Method(60, "Hrmp", 3, "force_clean_hrmp", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_process_hrmp_open
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceProcessHrmpOpen(Ajuna.NetApi.Model.Types.Primitive.U32 channels)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(channels.Encode());
            return new Method(60, "Hrmp", 4, "force_process_hrmp_open", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_process_hrmp_close
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceProcessHrmpClose(Ajuna.NetApi.Model.Types.Primitive.U32 channels)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(channels.Encode());
            return new Method(60, "Hrmp", 5, "force_process_hrmp_close", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> hrmp_cancel_open_request
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method HrmpCancelOpenRequest(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HrmpChannelId channel_id, Ajuna.NetApi.Model.Types.Primitive.U32 open_requests)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(channel_id.Encode());
            byteArray.AddRange(open_requests.Encode());
            return new Method(60, "Hrmp", 6, "hrmp_cancel_open_request", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_open_hrmp_channel
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceOpenHrmpChannel(HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id sender, HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id recipient, Ajuna.NetApi.Model.Types.Primitive.U32 max_capacity, Ajuna.NetApi.Model.Types.Primitive.U32 max_message_size)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(sender.Encode());
            byteArray.AddRange(recipient.Encode());
            byteArray.AddRange(max_capacity.Encode());
            byteArray.AddRange(max_message_size.Encode());
            return new Method(60, "Hrmp", 7, "force_open_hrmp_channel", byteArray.ToArray());
        }
    }
    
    public enum HrmpErrors
    {
        
        /// <summary>
        /// >> OpenHrmpChannelToSelf
        /// The sender tried to open a channel to themselves.
        /// </summary>
        OpenHrmpChannelToSelf,
        
        /// <summary>
        /// >> OpenHrmpChannelInvalidRecipient
        /// The recipient is not a valid para.
        /// </summary>
        OpenHrmpChannelInvalidRecipient,
        
        /// <summary>
        /// >> OpenHrmpChannelZeroCapacity
        /// The requested capacity is zero.
        /// </summary>
        OpenHrmpChannelZeroCapacity,
        
        /// <summary>
        /// >> OpenHrmpChannelCapacityExceedsLimit
        /// The requested capacity exceeds the global limit.
        /// </summary>
        OpenHrmpChannelCapacityExceedsLimit,
        
        /// <summary>
        /// >> OpenHrmpChannelZeroMessageSize
        /// The requested maximum message size is 0.
        /// </summary>
        OpenHrmpChannelZeroMessageSize,
        
        /// <summary>
        /// >> OpenHrmpChannelMessageSizeExceedsLimit
        /// The open request requested the message size that exceeds the global limit.
        /// </summary>
        OpenHrmpChannelMessageSizeExceedsLimit,
        
        /// <summary>
        /// >> OpenHrmpChannelAlreadyExists
        /// The channel already exists
        /// </summary>
        OpenHrmpChannelAlreadyExists,
        
        /// <summary>
        /// >> OpenHrmpChannelAlreadyRequested
        /// There is already a request to open the same channel.
        /// </summary>
        OpenHrmpChannelAlreadyRequested,
        
        /// <summary>
        /// >> OpenHrmpChannelLimitExceeded
        /// The sender already has the maximum number of allowed outbound channels.
        /// </summary>
        OpenHrmpChannelLimitExceeded,
        
        /// <summary>
        /// >> AcceptHrmpChannelDoesntExist
        /// The channel from the sender to the origin doesn't exist.
        /// </summary>
        AcceptHrmpChannelDoesntExist,
        
        /// <summary>
        /// >> AcceptHrmpChannelAlreadyConfirmed
        /// The channel is already confirmed.
        /// </summary>
        AcceptHrmpChannelAlreadyConfirmed,
        
        /// <summary>
        /// >> AcceptHrmpChannelLimitExceeded
        /// The recipient already has the maximum number of allowed inbound channels.
        /// </summary>
        AcceptHrmpChannelLimitExceeded,
        
        /// <summary>
        /// >> CloseHrmpChannelUnauthorized
        /// The origin tries to close a channel where it is neither the sender nor the recipient.
        /// </summary>
        CloseHrmpChannelUnauthorized,
        
        /// <summary>
        /// >> CloseHrmpChannelDoesntExist
        /// The channel to be closed doesn't exist.
        /// </summary>
        CloseHrmpChannelDoesntExist,
        
        /// <summary>
        /// >> CloseHrmpChannelAlreadyUnderway
        /// The channel close request is already requested.
        /// </summary>
        CloseHrmpChannelAlreadyUnderway,
        
        /// <summary>
        /// >> CancelHrmpOpenChannelUnauthorized
        /// Canceling is requested by neither the sender nor recipient of the open channel request.
        /// </summary>
        CancelHrmpOpenChannelUnauthorized,
        
        /// <summary>
        /// >> OpenHrmpChannelDoesntExist
        /// The open request doesn't exist.
        /// </summary>
        OpenHrmpChannelDoesntExist,
        
        /// <summary>
        /// >> OpenHrmpChannelAlreadyConfirmed
        /// Cannot cancel an HRMP open channel request because it is already confirmed.
        /// </summary>
        OpenHrmpChannelAlreadyConfirmed,
        
        /// <summary>
        /// >> WrongWitness
        /// The provided witness data is wrong.
        /// </summary>
        WrongWitness,
    }
}
