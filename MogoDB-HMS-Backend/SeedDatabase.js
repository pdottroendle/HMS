const mongoose = require('mongoose');
const fs = require('fs');
const path = require('path');

// Load models
const User = require('./models/User');
const Appointment = require('./models/Appointment');
const Vital = require('./models/Vital');
const Report = require('./models/Report');
const Patient = require('./models/Patient');
const Notification = require('./models/Notification');
const Message = require('./models/Message');
const InventoryLog = require('./models/InventoryLog');
const Inventory = require('./models/Inventory');

// Connect to MongoDB
mongoose.connect('mongodb://localhost:27017/hospital_management', {
  useNewUrlParser: true,
  useUnifiedTopology: true
}).then(() => {
  console.log('Connected to MongoDB');
  seedData();
}).catch(err => {
  console.error('MongoDB connection error:', err);
});

async function seedData() {
  try {
    const data = JSON.parse(fs.readFileSync(path.join(__dirname, 'database.json'), 'utf-8'));
await User.deleteMany({});
await Appointment.deleteMany({});
await Vital.deleteMany({});
await Report.deleteMany({});
await Patient.deleteMany({});
await Notification.deleteMany({});
await Message.deleteMany({});
await InventoryLog.deleteMany({});
await Inventory.deleteMany({});

    await User.insertMany(data.User);
    await Appointment.insertMany(data.Appointment);
    await Vital.insertMany(data.Vital);
    await Report.insertMany(data.Report);
    await Patient.insertMany(data.Patient);
    await Notification.insertMany(data.Notification);
    await Message.insertMany(data.Message);
    await InventoryLog.insertMany(data.InventoryLog);
    await Inventory.insertMany(data.Inventory);

    console.log('Database seeded successfully!');
    mongoose.disconnect();
  } catch (err) {
    console.error('Error seeding database:', err);
    mongoose.disconnect();
  }
}

