// automatically generated by the FlatBuffers compiler, do not modify

/**
 * @const
 * @namespace
 */
var com = com || {};

/**
 * @const
 * @namespace
 */
com.reactivemarkets = com.reactivemarkets || {};

/**
 * @const
 * @namespace
 */
com.reactivemarkets.papi = com.reactivemarkets.papi || {};

/**
 * @constructor
 */
com.reactivemarkets.papi.SessionStatus = function() {
  /**
   * @type {flatbuffers.ByteBuffer}
   */
  this.bb = null;

  /**
   * @type {number}
   */
  this.bb_pos = 0;
};

/**
 * @param {number} i
 * @param {flatbuffers.ByteBuffer} bb
 * @returns {com.reactivemarkets.papi.SessionStatus}
 */
com.reactivemarkets.papi.SessionStatus.prototype.__init = function(i, bb) {
  this.bb_pos = i;
  this.bb = bb;
  return this;
};

/**
 * @param {flatbuffers.ByteBuffer} bb
 * @param {com.reactivemarkets.papi.SessionStatus=} obj
 * @returns {com.reactivemarkets.papi.SessionStatus}
 */
com.reactivemarkets.papi.SessionStatus.getRootAsSessionStatus = function(bb, obj) {
  return (obj || new com.reactivemarkets.papi.SessionStatus).__init(bb.readInt32(bb.position()) + bb.position(), bb);
};

/**
 * @param {flatbuffers.ByteBuffer} bb
 * @param {com.reactivemarkets.papi.SessionStatus=} obj
 * @returns {com.reactivemarkets.papi.SessionStatus}
 */
com.reactivemarkets.papi.SessionStatus.getSizePrefixedRootAsSessionStatus = function(bb, obj) {
  bb.setPosition(bb.position() + flatbuffers.SIZE_PREFIX_LENGTH);
  return (obj || new com.reactivemarkets.papi.SessionStatus).__init(bb.readInt32(bb.position()) + bb.position(), bb);
};

/**
 * @returns {flatbuffers.Long}
 */
com.reactivemarkets.papi.SessionStatus.prototype.sourceTs = function() {
  var offset = this.bb.__offset(this.bb_pos, 4);
  return offset ? this.bb.readInt64(this.bb_pos + offset) : this.bb.createLong(0, 0);
};

/**
 * @param {flatbuffers.Encoding=} optionalEncoding
 * @returns {string|Uint8Array|null}
 */
com.reactivemarkets.papi.SessionStatus.prototype.source = function(optionalEncoding) {
  var offset = this.bb.__offset(this.bb_pos, 6);
  return offset ? this.bb.__string(this.bb_pos + offset, optionalEncoding) : null;
};

/**
 * @returns {number}
 */
com.reactivemarkets.papi.SessionStatus.prototype.code = function() {
  var offset = this.bb.__offset(this.bb_pos, 8);
  return offset ? this.bb.readInt32(this.bb_pos + offset) : 0;
};

/**
 * @param {flatbuffers.Encoding=} optionalEncoding
 * @returns {string|Uint8Array|null}
 */
com.reactivemarkets.papi.SessionStatus.prototype.message = function(optionalEncoding) {
  var offset = this.bb.__offset(this.bb_pos, 10);
  return offset ? this.bb.__string(this.bb_pos + offset, optionalEncoding) : null;
};

/**
 * @param {flatbuffers.Builder} builder
 */
com.reactivemarkets.papi.SessionStatus.startSessionStatus = function(builder) {
  builder.startObject(4);
};

/**
 * @param {flatbuffers.Builder} builder
 * @param {flatbuffers.Long} sourceTs
 */
com.reactivemarkets.papi.SessionStatus.addSourceTs = function(builder, sourceTs) {
  builder.addFieldInt64(0, sourceTs, builder.createLong(0, 0));
};

/**
 * @param {flatbuffers.Builder} builder
 * @param {flatbuffers.Offset} sourceOffset
 */
com.reactivemarkets.papi.SessionStatus.addSource = function(builder, sourceOffset) {
  builder.addFieldOffset(1, sourceOffset, 0);
};

/**
 * @param {flatbuffers.Builder} builder
 * @param {number} code
 */
com.reactivemarkets.papi.SessionStatus.addCode = function(builder, code) {
  builder.addFieldInt32(2, code, 0);
};

/**
 * @param {flatbuffers.Builder} builder
 * @param {flatbuffers.Offset} messageOffset
 */
com.reactivemarkets.papi.SessionStatus.addMessage = function(builder, messageOffset) {
  builder.addFieldOffset(3, messageOffset, 0);
};

/**
 * @param {flatbuffers.Builder} builder
 * @returns {flatbuffers.Offset}
 */
com.reactivemarkets.papi.SessionStatus.endSessionStatus = function(builder) {
  var offset = builder.endObject();
  return offset;
};

/**
 * @param {flatbuffers.Builder} builder
 * @param {flatbuffers.Long} sourceTs
 * @param {flatbuffers.Offset} sourceOffset
 * @param {number} code
 * @param {flatbuffers.Offset} messageOffset
 * @returns {flatbuffers.Offset}
 */
com.reactivemarkets.papi.SessionStatus.createSessionStatus = function(builder, sourceTs, sourceOffset, code, messageOffset) {
  com.reactivemarkets.papi.SessionStatus.startSessionStatus(builder);
  com.reactivemarkets.papi.SessionStatus.addSourceTs(builder, sourceTs);
  com.reactivemarkets.papi.SessionStatus.addSource(builder, sourceOffset);
  com.reactivemarkets.papi.SessionStatus.addCode(builder, code);
  com.reactivemarkets.papi.SessionStatus.addMessage(builder, messageOffset);
  return com.reactivemarkets.papi.SessionStatus.endSessionStatus(builder);
}

// Exports for Node.js and RequireJS
this.com = com;
