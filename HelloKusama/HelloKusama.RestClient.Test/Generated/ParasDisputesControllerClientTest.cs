//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloKusama.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using HelloKusama.RestClient.Mockup.Generated.Clients;
   using HelloKusama.RestClient.Generated.Clients;
   using Ajuna.NetApi.Model.Types.Primitive;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2;
   using Ajuna.NetApi.Model.Types.Base;
   
   public class ParasDisputesControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      [Test()]
      public async System.Threading.Tasks.Task TestLastPrunedSession()
      {
         // Construct new Mockup client to test with.
         ParasDisputesControllerMockupClient mockupClient = new ParasDisputesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ParasDisputesControllerClient rpcClient = new ParasDisputesControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();


         Assert.IsTrue(await rpcClient.SubscribeLastPrunedSession());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetLastPrunedSession(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetLastPrunedSession();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.DisputeState GetTestValue3()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.DisputeState result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.DisputeState();
         result.ValidatorsFor = new Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0>();
         result.ValidatorsFor = this.GetTestValue4();
         result.ValidatorsAgainst = new Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0>();
         result.ValidatorsAgainst = this.GetTestValue5();
         result.Start = this.GetTestValueU32();
         result.ConcludedAt = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.ConcludedAt.Create(this.GetTestValueU32());
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0> GetTestValue4()
      {
         Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0>();
         // NOT IMPLEMENTED >> Initialize Ajuna.NetApi.Model.Types.Base.BaseBitSeq`2[[Ajuna.NetApi.Model.Types.Primitive.U8, Ajuna.NetApi, Version=0.2.7.0, Culture=neutral, PublicKeyToken=null],[HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0, HelloKusama.NetApiExt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0> GetTestValue5()
      {
         Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0>();
         // NOT IMPLEMENTED >> Initialize Ajuna.NetApi.Model.Types.Base.BaseBitSeq`2[[Ajuna.NetApi.Model.Types.Primitive.U8, Ajuna.NetApi, Version=0.2.7.0, Culture=neutral, PublicKeyToken=null],[HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0, HelloKusama.NetApiExt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash> GetTestValue6()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash>();
         result.Create(this.GetTestValueU32(), this.GetTestValue7());
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash GetTestValue7()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash();
         result.Value = new HelloKusama.NetApiExt.Generated.Model.primitive_types.H256();
         result.Value = this.GetTestValue8();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 GetTestValue8()
      {
         HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 result;
         result = new HelloKusama.NetApiExt.Generated.Model.primitive_types.H256();
         result.Value = new HelloKusama.NetApiExt.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestDisputes()
      {
         // Construct new Mockup client to test with.
         ParasDisputesControllerMockupClient mockupClient = new ParasDisputesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ParasDisputesControllerClient rpcClient = new ParasDisputesControllerClient(_httpClient, subscriptionClient);
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.DisputeState mockupValue = this.GetTestValue3();
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash> mockupKey = this.GetTestValue6();

         Assert.IsTrue(await rpcClient.SubscribeDisputes(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetDisputes(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.DisputeState rpcResult = await rpcClient.GetDisputes(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash> GetTestValue10()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash>();
         result.Create(this.GetTestValueU32(), this.GetTestValue11());
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash GetTestValue11()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash();
         result.Value = new HelloKusama.NetApiExt.Generated.Model.primitive_types.H256();
         result.Value = this.GetTestValue12();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 GetTestValue12()
      {
         HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 result;
         result = new HelloKusama.NetApiExt.Generated.Model.primitive_types.H256();
         result.Value = new HelloKusama.NetApiExt.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestIncluded()
      {
         // Construct new Mockup client to test with.
         ParasDisputesControllerMockupClient mockupClient = new ParasDisputesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ParasDisputesControllerClient rpcClient = new ParasDisputesControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash> mockupKey = this.GetTestValue10();

         Assert.IsTrue(await rpcClient.SubscribeIncluded(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetIncluded(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetIncluded(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U32> GetTestValue14()
      {
         Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U32> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Create(new Ajuna.NetApi.Model.Types.Primitive.U32[] {
                  this.GetTestValueU32()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestSpamSlots()
      {
         // Construct new Mockup client to test with.
         ParasDisputesControllerMockupClient mockupClient = new ParasDisputesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ParasDisputesControllerClient rpcClient = new ParasDisputesControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U32> mockupValue = this.GetTestValue14();
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupKey = this.GetTestValueU32();

         Assert.IsTrue(await rpcClient.SubscribeSpamSlots(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetSpamSlots(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U32> rpcResult = await rpcClient.GetSpamSlots(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32> GetTestValue16()
      {
         Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Create(this.GetTestValueU32());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestFrozen()
      {
         // Construct new Mockup client to test with.
         ParasDisputesControllerMockupClient mockupClient = new ParasDisputesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ParasDisputesControllerClient rpcClient = new ParasDisputesControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32> mockupValue = this.GetTestValue16();


         Assert.IsTrue(await rpcClient.SubscribeFrozen());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetFrozen(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32> rpcResult = await rpcClient.GetFrozen();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}