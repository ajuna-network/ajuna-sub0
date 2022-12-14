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
   using Ajuna.NetApi.Model.Types.Base;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives;
   using HelloKusama.NetApiExt.Generated.Model.primitive_types;
   
   public class DmpControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.InboundDownwardMessage> GetTestValue2()
      {
         Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.InboundDownwardMessage> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.InboundDownwardMessage>();
         result.Create(new HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.InboundDownwardMessage[] {
                  this.GetTestValue3()});
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.InboundDownwardMessage GetTestValue3()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.InboundDownwardMessage result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.InboundDownwardMessage();
         result.SentAt = this.GetTestValueU32();
         result.Msg = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Msg.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id GetTestValue4()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
         result.Value = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestDownwardMessageQueues()
      {
         // Construct new Mockup client to test with.
         DmpControllerMockupClient mockupClient = new DmpControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         DmpControllerClient rpcClient = new DmpControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.InboundDownwardMessage> mockupValue = this.GetTestValue2();
         HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id mockupKey = this.GetTestValue4();

         Assert.IsTrue(await rpcClient.SubscribeDownwardMessageQueues(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetDownwardMessageQueues(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.InboundDownwardMessage> rpcResult = await rpcClient.GetDownwardMessageQueues(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 GetTestValue6()
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
      public HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id GetTestValue7()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
         result.Value = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestDownwardMessageQueueHeads()
      {
         // Construct new Mockup client to test with.
         DmpControllerMockupClient mockupClient = new DmpControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         DmpControllerClient rpcClient = new DmpControllerClient(_httpClient, subscriptionClient);
         HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 mockupValue = this.GetTestValue6();
         HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id mockupKey = this.GetTestValue7();

         Assert.IsTrue(await rpcClient.SubscribeDownwardMessageQueueHeads(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetDownwardMessageQueueHeads(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 rpcResult = await rpcClient.GetDownwardMessageQueueHeads(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
