const mongoose = require('mongoose');

const NotificationSchema = new mongoose.Schema({
  NotificationID: String,
  UserID: String,
  Message: String,
  Timestamp: Date,
  IsRead: Boolean
});

module.exports = mongoose.model('Notification', NotificationSchema);
