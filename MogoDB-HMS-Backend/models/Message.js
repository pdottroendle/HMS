const mongoose = require('mongoose');

const MessageSchema = new mongoose.Schema({
  MessageID: String,
  SenderID: String,
  ReceiverID: String,
  Timestamp: Date,
  Content: String
});

module.exports = mongoose.model('Message', MessageSchema);
