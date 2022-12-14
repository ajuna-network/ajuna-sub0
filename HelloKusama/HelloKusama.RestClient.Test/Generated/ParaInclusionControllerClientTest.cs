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
   using HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion;
   using HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2;
   
   public class ParaInclusionControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.AvailabilityBitfieldRecord GetTestValue2()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.AvailabilityBitfieldRecord result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.AvailabilityBitfieldRecord();
         result.Bitfield = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.AvailabilityBitfield();
         result.Bitfield = this.GetTestValue3();
         result.SubmittedAt = this.GetTestValueU32();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.AvailabilityBitfield GetTestValue3()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.AvailabilityBitfield result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.AvailabilityBitfield();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0>();
         result.Value = this.GetTestValue4();
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0> GetTestValue4()
      {
         Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0>();
         // NOT IMPLEMENTED >> Initialize Ajuna.NetApi.Model.Types.Base.BaseBitSeq`2[[Ajuna.NetApi.Model.Types.Primitive.U8, Ajuna.NetApi, Version=0.2.7.0, Culture=neutral, PublicKeyToken=null],[HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0, HelloKusama.NetApiExt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex GetTestValue5()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex();
         result.Value = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestAvailabilityBitfields()
      {
         // Construct new Mockup client to test with.
         ParaInclusionControllerMockupClient mockupClient = new ParaInclusionControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ParaInclusionControllerClient rpcClient = new ParaInclusionControllerClient(_httpClient, subscriptionClient);
         HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.AvailabilityBitfieldRecord mockupValue = this.GetTestValue2();
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.ValidatorIndex mockupKey = this.GetTestValue5();

         Assert.IsTrue(await rpcClient.SubscribeAvailabilityBitfields(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAvailabilityBitfields(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.AvailabilityBitfieldRecord rpcResult = await rpcClient.GetAvailabilityBitfields(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.CandidatePendingAvailability GetTestValue7()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.CandidatePendingAvailability result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.CandidatePendingAvailability();
         result.Core = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CoreIndex();
         result.Core = this.GetTestValue8();
         result.Hash = new HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash();
         result.Hash = this.GetTestValue9();
         result.Descriptor = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CandidateDescriptor();
         result.Descriptor = this.GetTestValue11();
         result.AvailabilityVotes = new Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0>();
         result.AvailabilityVotes = this.GetTestValue24();
         result.Backers = new Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0>();
         result.Backers = this.GetTestValue25();
         result.RelayParentNumber = this.GetTestValueU32();
         result.BackedInNumber = this.GetTestValueU32();
         result.BackingGroup = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.GroupIndex();
         result.BackingGroup = this.GetTestValue26();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CoreIndex GetTestValue8()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CoreIndex result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CoreIndex();
         result.Value = this.GetTestValueU32();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash GetTestValue9()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.CandidateHash();
         result.Value = new HelloKusama.NetApiExt.Generated.Model.primitive_types.H256();
         result.Value = this.GetTestValue10();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 GetTestValue10()
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
      public HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CandidateDescriptor GetTestValue11()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CandidateDescriptor result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CandidateDescriptor();
         result.ParaId = new HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
         result.ParaId = this.GetTestValue12();
         result.RelayParent = new HelloKusama.NetApiExt.Generated.Model.primitive_types.H256();
         result.RelayParent = this.GetTestValue13();
         result.Collator = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.collator_app.Public();
         result.Collator = this.GetTestValue14();
         result.PersistedValidationDataHash = new HelloKusama.NetApiExt.Generated.Model.primitive_types.H256();
         result.PersistedValidationDataHash = this.GetTestValue16();
         result.PovHash = new HelloKusama.NetApiExt.Generated.Model.primitive_types.H256();
         result.PovHash = this.GetTestValue17();
         result.ErasureRoot = new HelloKusama.NetApiExt.Generated.Model.primitive_types.H256();
         result.ErasureRoot = this.GetTestValue18();
         result.Signature = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.collator_app.Signature();
         result.Signature = this.GetTestValue19();
         result.ParaHead = new HelloKusama.NetApiExt.Generated.Model.primitive_types.H256();
         result.ParaHead = this.GetTestValue21();
         result.ValidationCodeHash = new HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.ValidationCodeHash();
         result.ValidationCodeHash = this.GetTestValue22();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id GetTestValue12()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
         result.Value = this.GetTestValueU32();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 GetTestValue13()
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
      public HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.collator_app.Public GetTestValue14()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.collator_app.Public result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.collator_app.Public();
         result.Value = new HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public();
         result.Value = this.GetTestValue15();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public GetTestValue15()
      {
         HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public result;
         result = new HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Public();
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
      public HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 GetTestValue16()
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
      public HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 GetTestValue17()
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
      public HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 GetTestValue18()
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
      public HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.collator_app.Signature GetTestValue19()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.collator_app.Signature result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.collator_app.Signature();
         result.Value = new HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Signature();
         result.Value = this.GetTestValue20();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Signature GetTestValue20()
      {
         HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Signature result;
         result = new HelloKusama.NetApiExt.Generated.Model.sp_core.sr25519.Signature();
         result.Value = new HelloKusama.NetApiExt.Generated.Types.Base.Arr64U8();
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
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 GetTestValue21()
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
      public HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.ValidationCodeHash GetTestValue22()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.ValidationCodeHash result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.ValidationCodeHash();
         result.Value = new HelloKusama.NetApiExt.Generated.Model.primitive_types.H256();
         result.Value = this.GetTestValue23();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.primitive_types.H256 GetTestValue23()
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
      public Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0> GetTestValue24()
      {
         Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0>();
         // NOT IMPLEMENTED >> Initialize Ajuna.NetApi.Model.Types.Base.BaseBitSeq`2[[Ajuna.NetApi.Model.Types.Primitive.U8, Ajuna.NetApi, Version=0.2.7.0, Culture=neutral, PublicKeyToken=null],[HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0, HelloKusama.NetApiExt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0> GetTestValue25()
      {
         Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseBitSeq<Ajuna.NetApi.Model.Types.Primitive.U8, HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0>();
         // NOT IMPLEMENTED >> Initialize Ajuna.NetApi.Model.Types.Base.BaseBitSeq`2[[Ajuna.NetApi.Model.Types.Primitive.U8, Ajuna.NetApi, Version=0.2.7.0, Culture=neutral, PublicKeyToken=null],[HelloKusama.NetApiExt.Generated.Model.bitvec.order.Lsb0, HelloKusama.NetApiExt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.GroupIndex GetTestValue26()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.GroupIndex result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.GroupIndex();
         result.Value = this.GetTestValueU32();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id GetTestValue27()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
         result.Value = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestPendingAvailability()
      {
         // Construct new Mockup client to test with.
         ParaInclusionControllerMockupClient mockupClient = new ParaInclusionControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ParaInclusionControllerClient rpcClient = new ParaInclusionControllerClient(_httpClient, subscriptionClient);
         HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.CandidatePendingAvailability mockupValue = this.GetTestValue7();
         HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id mockupKey = this.GetTestValue27();

         Assert.IsTrue(await rpcClient.SubscribePendingAvailability(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetPendingAvailability(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         HelloKusama.NetApiExt.Generated.Model.polkadot_runtime_parachains.inclusion.CandidatePendingAvailability rpcResult = await rpcClient.GetPendingAvailability(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CandidateCommitments GetTestValue29()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CandidateCommitments result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CandidateCommitments();
         result.UpwardMessages = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>>();
         result.UpwardMessages.Create(new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>[] {
                  this.GetTestValue30()});
         result.HorizontalMessages = new Ajuna.NetApi.Model.Types.Base.BaseVec<HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.OutboundHrmpMessage>();
         result.HorizontalMessages.Create(new HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.OutboundHrmpMessage[] {
                  this.GetTestValue31()});
         result.NewValidationCode = new Ajuna.NetApi.Model.Types.Base.BaseOpt<HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.ValidationCode>();
         result.NewValidationCode.Create(this.GetTestValue33());
         result.HeadData = new HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HeadData();
         result.HeadData = this.GetTestValue34();
         result.ProcessedDownwardMessages = this.GetTestValueU32();
         result.HrmpWatermark = this.GetTestValueU32();
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> GetTestValue30()
      {
         Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.OutboundHrmpMessage GetTestValue31()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.OutboundHrmpMessage result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_core_primitives.OutboundHrmpMessage();
         result.Recipient = new HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
         result.Recipient = this.GetTestValue32();
         result.Data = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Data.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id GetTestValue32()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
         result.Value = this.GetTestValueU32();
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.ValidationCode GetTestValue33()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.ValidationCode result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.ValidationCode();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HeadData GetTestValue34()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HeadData result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.HeadData();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      public HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id GetTestValue35()
      {
         HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id result;
         result = new HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id();
         result.Value = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestPendingAvailabilityCommitments()
      {
         // Construct new Mockup client to test with.
         ParaInclusionControllerMockupClient mockupClient = new ParaInclusionControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ParaInclusionControllerClient rpcClient = new ParaInclusionControllerClient(_httpClient, subscriptionClient);
         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CandidateCommitments mockupValue = this.GetTestValue29();
         HelloKusama.NetApiExt.Generated.Model.polkadot_parachain.primitives.Id mockupKey = this.GetTestValue35();

         Assert.IsTrue(await rpcClient.SubscribePendingAvailabilityCommitments(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetPendingAvailabilityCommitments(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         HelloKusama.NetApiExt.Generated.Model.polkadot_primitives.v2.CandidateCommitments rpcResult = await rpcClient.GetPendingAvailabilityCommitments(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
