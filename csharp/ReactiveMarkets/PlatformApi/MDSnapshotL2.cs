// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ReactiveMarkets.PlatformApi
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct MDSnapshotL2 : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static MDSnapshotL2 GetRootAsMDSnapshotL2(ByteBuffer _bb) { return GetRootAsMDSnapshotL2(_bb, new MDSnapshotL2()); }
  public static MDSnapshotL2 GetRootAsMDSnapshotL2(ByteBuffer _bb, MDSnapshotL2 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MDSnapshotL2 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long SourceTs { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string Source { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSourceBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetSourceBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetSourceArray() { return __p.__vector_as_array<byte>(6); }
  public string Market { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetMarketBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetMarketBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetMarketArray() { return __p.__vector_as_array<byte>(8); }
  public int FeedId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long Id { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public short Depth { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)0; } }
  public ushort Flags { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetUshort(o + __p.bb_pos) : (ushort)0; } }
  public ReactiveMarkets.PlatformApi.MDLevel2? BidSide(int j) { int o = __p.__offset(18); return o != 0 ? (ReactiveMarkets.PlatformApi.MDLevel2?)(new ReactiveMarkets.PlatformApi.MDLevel2()).__assign(__p.__vector(o) + j * 16, __p.bb) : null; }
  public int BidSideLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ReactiveMarkets.PlatformApi.MDLevel2? OfferSide(int j) { int o = __p.__offset(20); return o != 0 ? (ReactiveMarkets.PlatformApi.MDLevel2?)(new ReactiveMarkets.PlatformApi.MDLevel2()).__assign(__p.__vector(o) + j * 16, __p.bb) : null; }
  public int OfferSideLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<ReactiveMarkets.PlatformApi.MDSnapshotL2> CreateMDSnapshotL2(FlatBufferBuilder builder,
      long source_ts = 0,
      StringOffset sourceOffset = default(StringOffset),
      StringOffset marketOffset = default(StringOffset),
      int feed_id = 0,
      long id = 0,
      short depth = 0,
      ushort flags = 0,
      VectorOffset bid_sideOffset = default(VectorOffset),
      VectorOffset offer_sideOffset = default(VectorOffset)) {
    builder.StartTable(9);
    MDSnapshotL2.AddId(builder, id);
    MDSnapshotL2.AddSourceTs(builder, source_ts);
    MDSnapshotL2.AddOfferSide(builder, offer_sideOffset);
    MDSnapshotL2.AddBidSide(builder, bid_sideOffset);
    MDSnapshotL2.AddFeedId(builder, feed_id);
    MDSnapshotL2.AddMarket(builder, marketOffset);
    MDSnapshotL2.AddSource(builder, sourceOffset);
    MDSnapshotL2.AddFlags(builder, flags);
    MDSnapshotL2.AddDepth(builder, depth);
    return MDSnapshotL2.EndMDSnapshotL2(builder);
  }

  public static void StartMDSnapshotL2(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddSourceTs(FlatBufferBuilder builder, long sourceTs) { builder.AddLong(0, sourceTs, 0); }
  public static void AddSource(FlatBufferBuilder builder, StringOffset sourceOffset) { builder.AddOffset(1, sourceOffset.Value, 0); }
  public static void AddMarket(FlatBufferBuilder builder, StringOffset marketOffset) { builder.AddOffset(2, marketOffset.Value, 0); }
  public static void AddFeedId(FlatBufferBuilder builder, int feedId) { builder.AddInt(3, feedId, 0); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(4, id, 0); }
  public static void AddDepth(FlatBufferBuilder builder, short depth) { builder.AddShort(5, depth, 0); }
  public static void AddFlags(FlatBufferBuilder builder, ushort flags) { builder.AddUshort(6, flags, 0); }
  public static void AddBidSide(FlatBufferBuilder builder, VectorOffset bidSideOffset) { builder.AddOffset(7, bidSideOffset.Value, 0); }
  public static void StartBidSideVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(16, numElems, 8); }
  public static void AddOfferSide(FlatBufferBuilder builder, VectorOffset offerSideOffset) { builder.AddOffset(8, offerSideOffset.Value, 0); }
  public static void StartOfferSideVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(16, numElems, 8); }
  public static Offset<ReactiveMarkets.PlatformApi.MDSnapshotL2> EndMDSnapshotL2(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    builder.Required(o, 8);  // market
    return new Offset<ReactiveMarkets.PlatformApi.MDSnapshotL2>(o);
  }
};


}
