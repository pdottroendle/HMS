const mongoose = require('mongoose');

const InventoryLogSchema = new mongoose.Schema({
  LogID: String,
  ItemID: String,
  ChangeAmount: Number,
  Timestamp: Date,
  UserID: String,
  Reason: String
});

module.exports = mongoose.model('InventoryLog', InventoryLogSchema);
