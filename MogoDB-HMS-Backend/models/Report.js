const mongoose = require('mongoose');

const ReportSchema = new mongoose.Schema({
  ReportID: String,
  Type: String,
  GeneratedBy: String,  // Changed from ObjectId
  Timestamp: Date,
  FilePath: String
});

module.exports = mongoose.model('Report', ReportSchema);
