// automatically generated by the FlatBuffers compiler, do not modify


#ifndef FLATBUFFERS_GENERATED_FEEDREQUESTREJECT_REACTIVE_PAPI_H_
#define FLATBUFFERS_GENERATED_FEEDREQUESTREJECT_REACTIVE_PAPI_H_

#include "flatbuffers/flatbuffers.h"

namespace reactive {
namespace papi {

struct FeedRequestReject;
struct FeedRequestRejectBuilder;

struct FeedRequestReject FLATBUFFERS_FINAL_CLASS : private flatbuffers::Table {
  typedef FeedRequestRejectBuilder Builder;
  enum FlatBuffersVTableOffset FLATBUFFERS_VTABLE_UNDERLYING_TYPE {
    VT_REQ_ID = 4,
    VT_ERROR_CODE = 6,
    VT_ERROR_MESSAGE = 8
  };
  const flatbuffers::String *req_id() const {
    return GetPointer<const flatbuffers::String *>(VT_REQ_ID);
  }
  int32_t error_code() const {
    return GetField<int32_t>(VT_ERROR_CODE, 0);
  }
  const flatbuffers::String *error_message() const {
    return GetPointer<const flatbuffers::String *>(VT_ERROR_MESSAGE);
  }
  bool Verify(flatbuffers::Verifier &verifier) const {
    return VerifyTableStart(verifier) &&
           VerifyOffset(verifier, VT_REQ_ID) &&
           verifier.VerifyString(req_id()) &&
           VerifyField<int32_t>(verifier, VT_ERROR_CODE) &&
           VerifyOffset(verifier, VT_ERROR_MESSAGE) &&
           verifier.VerifyString(error_message()) &&
           verifier.EndTable();
  }
};

struct FeedRequestRejectBuilder {
  typedef FeedRequestReject Table;
  flatbuffers::FlatBufferBuilder &fbb_;
  flatbuffers::uoffset_t start_;
  void add_req_id(flatbuffers::Offset<flatbuffers::String> req_id) {
    fbb_.AddOffset(FeedRequestReject::VT_REQ_ID, req_id);
  }
  void add_error_code(int32_t error_code) {
    fbb_.AddElement<int32_t>(FeedRequestReject::VT_ERROR_CODE, error_code, 0);
  }
  void add_error_message(flatbuffers::Offset<flatbuffers::String> error_message) {
    fbb_.AddOffset(FeedRequestReject::VT_ERROR_MESSAGE, error_message);
  }
  explicit FeedRequestRejectBuilder(flatbuffers::FlatBufferBuilder &_fbb)
        : fbb_(_fbb) {
    start_ = fbb_.StartTable();
  }
  flatbuffers::Offset<FeedRequestReject> Finish() {
    const auto end = fbb_.EndTable(start_);
    auto o = flatbuffers::Offset<FeedRequestReject>(end);
    return o;
  }
};

inline flatbuffers::Offset<FeedRequestReject> CreateFeedRequestReject(
    flatbuffers::FlatBufferBuilder &_fbb,
    flatbuffers::Offset<flatbuffers::String> req_id = 0,
    int32_t error_code = 0,
    flatbuffers::Offset<flatbuffers::String> error_message = 0) {
  FeedRequestRejectBuilder builder_(_fbb);
  builder_.add_error_message(error_message);
  builder_.add_error_code(error_code);
  builder_.add_req_id(req_id);
  return builder_.Finish();
}

inline flatbuffers::Offset<FeedRequestReject> CreateFeedRequestRejectDirect(
    flatbuffers::FlatBufferBuilder &_fbb,
    const char *req_id = nullptr,
    int32_t error_code = 0,
    const char *error_message = nullptr) {
  auto req_id__ = req_id ? _fbb.CreateString(req_id) : 0;
  auto error_message__ = error_message ? _fbb.CreateString(error_message) : 0;
  return reactive::papi::CreateFeedRequestReject(
      _fbb,
      req_id__,
      error_code,
      error_message__);
}

}  // namespace papi
}  // namespace reactive

#endif  // FLATBUFFERS_GENERATED_FEEDREQUESTREJECT_REACTIVE_PAPI_H_
