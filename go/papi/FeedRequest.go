// Code generated by the FlatBuffers compiler. DO NOT EDIT.

package papi

import (
	flatbuffers "github.com/google/flatbuffers/go"
)

type FeedRequest struct {
	_tab flatbuffers.Table
}

func GetRootAsFeedRequest(buf []byte, offset flatbuffers.UOffsetT) *FeedRequest {
	n := flatbuffers.GetUOffsetT(buf[offset:])
	x := &FeedRequest{}
	x.Init(buf, n+offset)
	return x
}

func (rcv *FeedRequest) Init(buf []byte, i flatbuffers.UOffsetT) {
	rcv._tab.Bytes = buf
	rcv._tab.Pos = i
}

func (rcv *FeedRequest) Table() flatbuffers.Table {
	return rcv._tab
}

func (rcv *FeedRequest) ReqId() []byte {
	o := flatbuffers.UOffsetT(rcv._tab.Offset(4))
	if o != 0 {
		return rcv._tab.ByteVector(o + rcv._tab.Pos)
	}
	return nil
}

func (rcv *FeedRequest) SubReqType() SubReqType {
	o := flatbuffers.UOffsetT(rcv._tab.Offset(6))
	if o != 0 {
		return SubReqType(rcv._tab.GetInt8(o + rcv._tab.Pos))
	}
	return 1
}

func (rcv *FeedRequest) MutateSubReqType(n SubReqType) bool {
	return rcv._tab.MutateInt8Slot(6, int8(n))
}

func (rcv *FeedRequest) FeedType() FeedType {
	o := flatbuffers.UOffsetT(rcv._tab.Offset(8))
	if o != 0 {
		return FeedType(rcv._tab.GetInt16(o + rcv._tab.Pos))
	}
	return 0
}

func (rcv *FeedRequest) MutateFeedType(n FeedType) bool {
	return rcv._tab.MutateInt16Slot(8, int16(n))
}

func (rcv *FeedRequest) Grouping() uint16 {
	o := flatbuffers.UOffsetT(rcv._tab.Offset(10))
	if o != 0 {
		return rcv._tab.GetUint16(o + rcv._tab.Pos)
	}
	return 0
}

func (rcv *FeedRequest) MutateGrouping(n uint16) bool {
	return rcv._tab.MutateUint16Slot(10, n)
}

func (rcv *FeedRequest) Depth() int16 {
	o := flatbuffers.UOffsetT(rcv._tab.Offset(12))
	if o != 0 {
		return rcv._tab.GetInt16(o + rcv._tab.Pos)
	}
	return 0
}

func (rcv *FeedRequest) MutateDepth(n int16) bool {
	return rcv._tab.MutateInt16Slot(12, n)
}

func (rcv *FeedRequest) Frequency() int16 {
	o := flatbuffers.UOffsetT(rcv._tab.Offset(14))
	if o != 0 {
		return rcv._tab.GetInt16(o + rcv._tab.Pos)
	}
	return 0
}

func (rcv *FeedRequest) MutateFrequency(n int16) bool {
	return rcv._tab.MutateInt16Slot(14, n)
}

func (rcv *FeedRequest) Markets(j int) []byte {
	o := flatbuffers.UOffsetT(rcv._tab.Offset(16))
	if o != 0 {
		a := rcv._tab.Vector(o)
		return rcv._tab.ByteVector(a + flatbuffers.UOffsetT(j*4))
	}
	return nil
}

func (rcv *FeedRequest) MarketsLength() int {
	o := flatbuffers.UOffsetT(rcv._tab.Offset(16))
	if o != 0 {
		return rcv._tab.VectorLen(o)
	}
	return 0
}

func FeedRequestStart(builder *flatbuffers.Builder) {
	builder.StartObject(7)
}
func FeedRequestAddReqId(builder *flatbuffers.Builder, reqId flatbuffers.UOffsetT) {
	builder.PrependUOffsetTSlot(0, flatbuffers.UOffsetT(reqId), 0)
}
func FeedRequestAddSubReqType(builder *flatbuffers.Builder, subReqType SubReqType) {
	builder.PrependInt8Slot(1, int8(subReqType), 1)
}
func FeedRequestAddFeedType(builder *flatbuffers.Builder, feedType FeedType) {
	builder.PrependInt16Slot(2, int16(feedType), 0)
}
func FeedRequestAddGrouping(builder *flatbuffers.Builder, grouping uint16) {
	builder.PrependUint16Slot(3, grouping, 0)
}
func FeedRequestAddDepth(builder *flatbuffers.Builder, depth int16) {
	builder.PrependInt16Slot(4, depth, 0)
}
func FeedRequestAddFrequency(builder *flatbuffers.Builder, frequency int16) {
	builder.PrependInt16Slot(5, frequency, 0)
}
func FeedRequestAddMarkets(builder *flatbuffers.Builder, markets flatbuffers.UOffsetT) {
	builder.PrependUOffsetTSlot(6, flatbuffers.UOffsetT(markets), 0)
}
func FeedRequestStartMarketsVector(builder *flatbuffers.Builder, numElems int) flatbuffers.UOffsetT {
	return builder.StartVector(4, numElems, 4)
}
func FeedRequestEnd(builder *flatbuffers.Builder) flatbuffers.UOffsetT {
	return builder.EndObject()
}