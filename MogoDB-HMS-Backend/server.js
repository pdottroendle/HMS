const express = require('express');
const mongoose = require('mongoose');
const cors = require('cors');
const bodyParser = require('body-parser');

const User = require('./models/User');
const Appointment = require('./models/Appointment');
const Vital = require('./models/Vital');
const Report = require('./models/Report');
const Patient = require('./models/Patient');
const Notification = require('./models/Notification');
const Message = require('./models/Message');
const InventoryLog = require('./models/InventoryLog');
const Inventory = require('./models/Inventory');

const path = require('path');
const app = express();
const port = 3001;

app.use(cors({
    origin: ['http://35.247.54.23:3000'],
    methods: ['GET', 'POST'],
    allowedHeaders: ['Content-Type']
}));

app.use(bodyParser.json());

app.get('/', (req, res) => {
    res.send('Node.js SERVER is running and reachable!');
});

// MongoDB connection
mongoose.connect('mongodb://localhost:27017/hospital_management', {
  useNewUrlParser: true,
  useUnifiedTopology: true,
});

// Add User
app.get('/add_Users', async (req, res) => {
  const { UserID, Username, PasswordHash, Role, Email, Phone } = req.query;

  if (!UserID || !Username || !PasswordHash || !Role || !Email || !Phone) {
    return res.status(400).json({ error: 'All fields are required' });
  }

  try {
    await User.findOneAndUpdate(
      { UserID }, // search condition
      { Username, PasswordHash, Role, Email, Phone }, // update fields
      { upsert: true, new: true } // create if not exists, return new doc
    );
    res.status(200).json({ message: 'User added or updated successfully!' });
  } catch (err) {
    res.status(500).json({ error: 'Failed to add or update user', details: err.message });
  }
});


// Search Users
app.get('/Users', async (req, res) => {
  const query = {};
  const fields = ['UserID', 'Username', 'PasswordHash', 'Role', 'Email', 'Phone'];
  fields.forEach(field => {
    if (req.query[field] && req.query[field] !== '') {
      query[field] = req.query[field];
    }
  });
  try {
    const users = await User.find(query);
    res.status(200).json(users);
  } catch (err) {
    res.status(500).json({ error: 'Failed to search users', details: err.message });
  }
});

app.get('/add_Patients', async (req, res) => {
  const { PatientID, UserID, Name, DOB, Gender, Address, ContactInfo, MedicalHistory } = req.query;
  if (!PatientID || !UserID || !Name || !DOB || !Gender || !Address || !ContactInfo || !MedicalHistory) {
    return res.status(400).json({ error: 'All fields are required' });
  }
  try {
     await Patient.findOneAndUpdate(
      { PatientID },
      { UserID, Name, DOB, Gender, Address, ContactInfo, MedicalHistory },
      { upsert: true, new: true }
    ); 
    res.status(200).json({ message: 'Patient added successfully!' });
  } catch (err) {
    res.status(500).json({ error: 'Failed to add patient', details: err.message });
  }
});

app.get('/Patients', async (req, res) => {
  const query = {};
  const fields = ['PatientID', 'UserID', 'Name', 'DOB', 'Gender', 'Address', 'ContactInfo', 'MedicalHistory'];
  fields.forEach(field => {
    if (req.query[field] && req.query[field] !== '') {
      query[field] = req.query[field];
    }
  });
  try {
    const patients = await Patient.find(query);
    res.status(200).json(patients);
  } catch (err) {
    res.status(500).json({ error: 'Failed to search patients', details: err.message });
  }
});

app.get('/add_Appointments', async (req, res) => {
  const { AppointmentID, PatientID, DoctorID, DateTime, Status, Notes } = req.query;
  if (!AppointmentID || !PatientID || !DoctorID || !DateTime || !Status) {
    return res.status(400).json({ error: 'All fields are required' });
  }
  try {
     await Appointment.findOneAndUpdate(
      { AppointmentID },
      { PatientID, DoctorID, DateTime, Status, Notes },
      { upsert: true, new: true }
    );    
    res.status(200).json({ message: 'Appointment added successfully!' });
  } catch (err) {
    res.status(500).json({ error: 'Failed to add appointment', details: err.message });
  }
});

app.get('/Appointments', async (req, res) => {
  const query = {};
  const fields = ['AppointmentID', 'PatientID', 'DoctorID', 'DateTime', 'Status', 'Notes'];
  fields.forEach(field => {
    if (req.query[field] && req.query[field] !== '') {
      query[field] = req.query[field];
    }
  });
  try {
    const appointments = await Appointment.find(query);
    res.status(200).json(appointments);
  } catch (err) {
    res.status(500).json({ error: 'Failed to search appointments', details: err.message });
  }
});

app.get('/add_Inventory', async (req, res) => {
  const { ItemID, Name, Quantity, Threshold, LastUpdated } = req.query;

  if (!ItemID || !Name || !Quantity || !Threshold || !LastUpdated) {
    return res.status(400).json({ error: 'All fields are required' });
  }

  try {
    await Inventory.findOneAndUpdate(
      { ItemID },
      { Name, Quantity, Threshold, LastUpdated },
      { upsert: true, new: true }
    );
    res.status(200).json({ message: 'Inventory item added or updated successfully!' });
  } catch (err) {
    res.status(500).json({ error: 'Failed to add or update inventory item', details: err.message });
  }
});


app.get('/Inventory', async (req, res) => {
  const query = {};
  const fields = ['ItemID', 'Name', 'Quantity', 'Threshold', 'LastUpdated'];
  fields.forEach(field => {
    if (req.query[field] && req.query[field] !== '') {
      query[field] = req.query[field];
    }
  });
  try {
    const items = await Inventory.find(query);
    res.status(200).json(items);
  } catch (err) {
    res.status(500).json({ error: 'Failed to search inventory', details: err.message });
  }
});
app.get('/add_InventoryLogs', async (req, res) => {
  const { LogID, ItemID, ChangeAmount, Timestamp, UserID, Reason } = req.query;
  if (!LogID || !ItemID || !ChangeAmount || !Timestamp || !UserID || !Reason) {
    return res.status(400).json({ error: 'All fields are required' });
  }
  try {
    await InventoryLog.findOneAndUpdate(
      { LogID },
      { ItemID, ChangeAmount, Timestamp, UserID, Reason },
      { upsert: true, new: true }
    );
    res.status(200).json({ message: 'Inventory log added successfully!' });
  } catch (err) {
    res.status(500).json({ error: 'Failed to add inventory log', details: err.message });
  }
});

app.get('/InventoryLogs', async (req, res) => {
  const query = {};
  const fields = ['LogID', 'ItemID', 'ChangeAmount', 'Timestamp', 'UserID', 'Reason'];
  fields.forEach(field => {
    if (req.query[field] && req.query[field] !== '') {
      query[field] = req.query[field];
    }
  });
  try {
    const logs = await InventoryLog.find(query);
    res.status(200).json(logs);
  } catch (err) {
    res.status(500).json({ error: 'Failed to search inventory logs', details: err.message });
  }
});
app.get('/add_Vitals', async (req, res) => {
  const { VitalID, PatientID, Timestamp, HeartRate, BloodPressure, Temperature, OxygenLevel } = req.query;
  if (!VitalID || !PatientID || !Timestamp || !HeartRate || !BloodPressure || !Temperature || !OxygenLevel) {
    return res.status(400).json({ error: 'All fields are required' });
  }
  try {
    await Vital.findOneAndUpdate(
      { VitalID },
      { PatientID, Timestamp, HeartRate, BloodPressure, Temperature, OxygenLevel  },
      { upsert: true, new: true }
    );
    res.status(200).json({ message: 'Vital record added successfully!' });
  } catch (err) {
    res.status(500).json({ error: 'Failed to add vital record', details: err.message });
  }
});

app.get('/Vitals', async (req, res) => {
  const query = {};
  const fields = ['VitalID', 'PatientID', 'Timestamp', 'HeartRate', 'BloodPressure', 'Temperature', 'OxygenLevel'];
  fields.forEach(field => {
    if (req.query[field] && req.query[field] !== '') {
      query[field] = req.query[field];
    }
  });
  try {
    const vitals = await Vital.find(query);
    res.status(200).json(vitals);
  } catch (err) {
    res.status(500).json({ error: 'Failed to search vitals', details: err.message });
  }
});
app.get('/add_Messages', async (req, res) => {
  const { MessageID, SenderID, ReceiverID, Timestamp, Content } = req.query;
  if (!MessageID || !SenderID || !ReceiverID || !Timestamp || !Content) {
    return res.status(400).json({ error: 'All fields are required' });
  }
  try {
    await Message.findOneAndUpdate(
      { MessageID },
      { SenderID, ReceiverID, Timestamp, Content  },
      { upsert: true, new: true }
    );   
 res.status(200).json({ message: 'Message added successfully!' });
  } catch (err) {
    res.status(500).json({ error: 'Failed to add message', details: err.message });
  }
});

app.get('/Messages', async (req, res) => {
  const query = {};
  const fields = ['MessageID', 'SenderID', 'ReceiverID', 'Timestamp', 'Content'];
  fields.forEach(field => {
    if (req.query[field] && req.query[field] !== '') {
      query[field] = req.query[field];
    }
  });
  try {
    const messages = await Message.find(query);
    res.status(200).json(messages);
  } catch (err) {
    res.status(500).json({ error: 'Failed to search messages', details: err.message });
  }
});
app.get('/add_Notifications', async (req, res) => {
  const { NotificationID, UserID, Message, Timestamp, IsRead } = req.query;
  if (!NotificationID || !UserID || !Message || !Timestamp) {
    return res.status(400).json({ error: 'All fields are required' });
  }
  try {
 await Notification.findOneAndUpdate(
      { NotificationID },
      { UserID, Message, Timestamp, IsRead },
      { upsert: true, new: true }
    );   
    
res.status(200).json({ message: 'Notification added successfully!' });
  } catch (err) {
    res.status(500).json({ error: 'Failed to add notification', details: err.message });
  }
});

app.get('/Notifications', async (req, res) => {
  const query = {};
  const fields = ['NotificationID', 'UserID', 'Message', 'Timestamp', 'IsRead'];
  fields.forEach(field => {
    if (req.query[field] && req.query[field] !== '') {
      query[field] = req.query[field];
    }
  });
  try {
    const notifications = await Notification.find(query);
    res.status(200).json(notifications);
  } catch (err) {
    res.status(500).json({ error: 'Failed to search notifications', details: err.message });
  }
});
app.get('/add_Reports', async (req, res) => {
  const { ReportID, Type, GeneratedBy, Timestamp, FilePath } = req.query;
  if (!ReportID || !Type || !GeneratedBy || !Timestamp || !FilePath) {
    return res.status(400).json({ error: 'All fields are required' });
  }
  try {
   await Report.findOneAndUpdate(
      { ReportID },
      { Type, GeneratedBy, Timestamp, FilePath },
      { upsert: true, new: true }
    );      
 res.status(200).json({ message: 'Report added successfully!' });
  } catch (err) {
    res.status(500).json({ error: 'Failed to add report', details: err.message });
  }
});

app.get('/Reports', async (req, res) => {
  const query = {};
  const fields = ['ReportID', 'Type', 'GeneratedBy', 'Timestamp', 'FilePath'];
  fields.forEach(field => {
    if (req.query[field] && req.query[field] !== '') {
      query[field] = req.query[field];
    }
  });
  try {
    const reports = await Report.find(query);
    res.status(200).json(reports);
  } catch (err) {
    res.status(500).json({ error: 'Failed to search reports', details: err.message });
  }
});

app.get('/export_db', async (req, res) => {
  try {
    const users = await User.find();
    const appointment = await Appointment.find();
    const vital = await Vital.find();
    const reports = await Report.find();
    const patient = await Patient.find();
    const notification = await Notification.find();
    const message = await Message.find();
    const inventoryLog = await InventoryLog.find();
    const inventory = await Inventory.find();

    res.status(200).json({
      User: users,
      Appointment: appointment,
      Vital: vital,
      Report: reports,
      Patient: patient,
      Notification: notification,
      Message: message,
      InventoryLog: inventoryLog,
      Inventory: inventory
    });
  } catch (err) {
    res.status(500).json({ error: 'Failed to export database', details: err.message });
  }
});

app.listen(port, '0.0.0.0', () => {
    console.log(`Server is running on http://35.247.54.23:${port}`);
});
