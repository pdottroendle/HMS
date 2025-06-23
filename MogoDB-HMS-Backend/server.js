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
app.get('/add_User', async (req, res) => {
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

app.get('/User', async (req, res) => {
  const { UserID, Username, PasswordHash, Role, Email, Phone } = req.query;
  // Build the query object dynamically
  const query = {};
  if (UserID) query.UserID = UserID;
  if (Username) query.Username = Username;
  if (PasswordHash) query.PasswordHash = PasswordHash;
  if (Email) query.Email =  Email;
  if (Phone) query.Phone = Phone;  
  try {
    const results = await User.find(query);
    res.status(200).json(results);
  } catch (err) {
    res.status(500).json({ error: 'Failed to fetch User items', details: err.message });
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
  const { PatientID, UserID, Name, DOB, Gender, Address, ContactInfo, MedicalHistory} = req.query;
  // Build the query object dynamically
  const query = {};
  if (PatientID) query.PatientID = PatientID;
  if (UserID) query.UserID = UserID;  
  if (Name) query.Name = Name;
  if (DOB) query.DOB = DOB;  
  if (Gender) query.Gender = Gender;  
  if (Address) query.Address = Address;
  if (ContactInfo) query.ContactInfo = ContactInfo;  
  if (MedicalHistory) query.MedicalHistory = MedicalHistory;
  try {
    const results = await Patients.find(query);
    res.status(200).json(results);
  } catch (err) {
    res.status(500).json({ error: 'Failed to fetch Patients items', details: err.message });
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
  const { AppointmentID, PatientID, DoctorID, DateTime, Status, Notes } = req.query;
  // Build the query object dynamically
  const query = {};
  if (AppointmentID) query.AppointmentID = AppointmentID;
  if (PatientID) query.PatientID = PatientID;
  if (DoctorID) query.DoctorID = DoctorID;
  if (DateTime) query.DateTime =  new Date(DateTime);
  if (Status) query.Status = Status;  
  if (Notes) query.Notes = Notes;
  try {
    const results = await Appointments.find(query);
    res.status(200).json(results);
  } catch (err) {
    res.status(500).json({ error: 'Failed to fetch Appointments items', details: err.message });
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
  const { ItemID, Name, Quantity, Threshold, LastUpdated } = req.query;
  // Build the query object dynamically
  const query = {};
  if (ItemID) query.ItemID = ItemID;
  if (Name) query.Name = Name;
  if (Quantity) query.Quantity = Number(Quantity);
  if (Threshold) query.Threshold = Number(Threshold);
  if (LastUpdated) query.LastUpdated = new Date(LastUpdated);
  try {
    const results = await Inventory.find(query);
    res.status(200).json(results);
  } catch (err) {
    res.status(500).json({ error: 'Failed to fetch inventory items', details: err.message });
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
  const { LogID, ItemID, ChangeAmount, Timestamp, UserID, Reason } = req.query;
  // Build the query object dynamically
  const query = {};
  if (LogID) query.LogID = LogID;
  if (ItemID) query.ItemID = ItemID;
  if (ChangeAmount) query.ChangeAmount = Number(ChangeAmount);
  if (Timestamp) query.Timestamp = new Date(Timestamp);
  if (UserID) query.UserID = UserID;  
  if (Reason) query.Reason = Reason;
  try {
    const results = await InventoryLogs.find(query);
    res.status(200).json(results);
  } catch (err) {
    res.status(500).json({ error: 'Failed to fetch InventoryLogs items', details: err.message });
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
  const { VitalID, PatientID, Timestamp, HeartRate, BloodPressure, Temperature, OxygenLevel} = req.query;
  // Build the query object dynamically
  const query = {};
  if (VitalID) query.VitalID = VitalID;
  if (PatientID) query.PatientID = PatientID;
  if (Timestamp) query.Timestamp = new Date(Timestamp);  
  if (HeartRate) query.HeartRate = Number(HeartRate);  
  if (BloodPressure) query.BloodPressure = Number(BloodPressure);
  if (Temperature) query.Temperature = Number(Temperature);  
  if (OxygenLevel) query.OxygenLevel = Number(OxygenLevel);
  try {
    const results = await Vitals.find(query);
    res.status(200).json(results);
  } catch (err) {
    res.status(500).json({ error: 'Failed to fetch Vitals items', details: err.message });
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
  const { MessageID, SenderID, ReceiverID, Timestamp, Content} = req.query;
  // Build the query object dynamically
  const query = {};
  if (MessageID) query.MessageID = MessageID;
  if (SenderID) query.SenderID = SenderID;  
  if (ReceiverID) query.ReceiverID = ReceiverID;
  if (Timestamp) query.Timestamp = new Date(Timestamp);  
  if (Content) query.Content = Content;  
  try {
    const results = await Messages.find(query);
    res.status(200).json(results);
  } catch (err) {
    res.status(500).json({ error: 'Failed to fetch Messages items', details: err.message });
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
  const { NotificationID, UserID, Message, Timestamp, IsRead} = req.query;
  // Build the query object dynamically
  const query = {};
  if (NotificationID) query.NotificationID = NotificationID;
  if (UserID) query.UserID = UserID;  
  if (Message) query.Message = Message;
  if (Timestamp) query.Timestamp = new Date(Timestamp);  
  if (HeartRate) query.HeartRate = Number(HeartRate);  
  if (IsRead) query.IsRead = IsRead;
  try {
    const results = await Notifications.find(query);
    res.status(200).json(results);
  } catch (err) {
    res.status(500).json({ error: 'Failed to fetch Notifications items', details: err.message });
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
  const { ReportID, Type, GeneratedBy, Timestamp, FilePath} = req.query;
  // Build the query object dynamically
  const query = {};
  if (ReportID) query.ReportID = ReportID;
  if (Type) query.Type = Type;  
  if (GeneratedBy) query.GeneratedBy = GeneratedBy;
  if (Timestamp) query.Timestamp = new Date(Timestamp);  
  if (FilePath) query.FilePath = FilePath;  
  try {
    const results = await Reports.find(query);
    res.status(200).json(results);
  } catch (err) {
    res.status(500).json({ error: 'Failed to fetch Reports items', details: err.message });
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