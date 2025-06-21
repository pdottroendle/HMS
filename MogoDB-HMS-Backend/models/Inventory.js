const mongoose = require('mongoose');

const InventorySchema = new mongoose.Schema({
  ItemID: String,
  Name: String,
  Quantity: Number,
  Threshold: Number,
  LastUpdated: Date
});

module.exports = mongoose.model('Inventory', InventorySchema);
