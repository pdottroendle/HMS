const mongoose = require('mongoose');

const AppointmentSchema = new mongoose.Schema({
  AppointmentID: String,
  PatientID: String,  // Changed from ObjectId
  DoctorID: String,   // Changed from ObjectId
  DateTime: Date,
  Status: String,
  Notes: String
});

module.exports = mongoose.model('Appointment', AppointmentSchema);
