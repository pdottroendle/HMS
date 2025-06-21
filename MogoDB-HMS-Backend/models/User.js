const mongoose = require('mongoose');

const UserSchema = new mongoose.Schema({
  UserID: String,
  Username: String,
  PasswordHash: String,
  Role: String,
  Email: String,
  Phone: String
});

module.exports = mongoose.model('User', UserSchema);
