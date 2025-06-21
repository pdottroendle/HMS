const mongoose = require('mongoose');

const PatientSchema = new mongoose.Schema({
  PatientID: String,
  UserID: String,
  Name: String,
  DOB: Date,
  Gender: String,
  Address: String,
  ContactInfo: String,
  MedicalHistory: String
});

module.exports = mongoose.model('Patient', PatientSchema);
