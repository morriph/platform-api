// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace ReactiveMarkets.PlatformApi
{

using global::System;
using global::System.Collections.Generic;
using global::FlatBuffers;

public struct FeedRequestAccept : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_1_12_0(); }
  public static FeedRequestAccept GetRootAsFeedRequestAccept(ByteBuffer _bb) { return GetRootAsFeedRequestAccept(_bb, new FeedRequestAccept()); }
  public static FeedRequestAccept GetRootAsFeedRequestAccept(ByteBuffer _bb, FeedRequestAccept obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FeedRequestAccept __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string ReqId { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetReqIdBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetReqIdBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetReqIdArray() { return __p.__vector_as_array<byte>(4); }
  public int FeedId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<ReactiveMarkets.PlatformApi.FeedRequestAccept> CreateFeedRequestAccept(FlatBufferBuilder builder,
      StringOffset req_idOffset = default(StringOffset),
      int feed_id = 0) {
    builder.StartTable(2);
    FeedRequestAccept.AddFeedId(builder, feed_id);
    FeedRequestAccept.AddReqId(builder, req_idOffset);
    return FeedRequestAccept.EndFeedRequestAccept(builder);
  }

  public static void StartFeedRequestAccept(FlatBufferBuilder builder) { builder.StartTable(2); }
  public static void AddReqId(FlatBufferBuilder builder, StringOffset reqIdOffset) { builder.AddOffset(0, reqIdOffset.Value, 0); }
  public static void AddFeedId(FlatBufferBuilder builder, int feedId) { builder.AddInt(1, feedId, 0); }
  public static Offset<ReactiveMarkets.PlatformApi.FeedRequestAccept> EndFeedRequestAccept(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<ReactiveMarkets.PlatformApi.FeedRequestAccept>(o);
  }
};


}
