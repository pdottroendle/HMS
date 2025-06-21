const mongoose = require('mongoose');

const VitalSchema = new mongoose.Schema({
  VitalID: String,
  PatientID: String,  // Changed from ObjectId
  Timestamp: Date,
  HeartRate: Number,
  BloodPressure: String,
  Temperature: Number,
  OxygenLevel: Number
});

module.exports = mongoose.model('Vital', VitalSchema);
