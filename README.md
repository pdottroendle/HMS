Server is Up! <br>
<br>
check in the MogoDB directory for the models and the CURL Endpoint commands (README) <<<<<<<<<<<<<<<<<<<<<<<
<br>


# MongoDB ERD Core Entities and Relationships

## 1. Users
Attributes: 
- **UserID** (PK)
- Username
- PasswordHash
- Role (Doctor, Nurse, Admin, Patient)
- Email
- Phone

Relationships:
- One-to-many with Appointments
- One-to-many with Messages (for chat)
- One-to-many with Notifications

## 2. Patients
Attributes: 
- **PatientID** (PK)
- UserID (FK)
- Name
- DOB
- Gender
- Address
- ContactInfo
- MedicalHistory (file reference)

Relationships:
- One-to-many with Appointments
- One-to-many with Vitals
- One-to-many with Prescriptions

## 3. Appointments
Attributes: 
- **AppointmentID** (PK)
- PatientID (FK)
- DoctorID (FK)
- DateTime
- Status (Scheduled, Cancelled, Completed)
- Notes

Relationships:
- Many-to-one with Patients
- Many-to-one with Users (Doctors)

## 4. Inventory
Attributes: 
- **ItemID** (PK)
- Name
- Quantity
- Threshold
- LastUpdated

Relationships:
- One-to-many with InventoryLogs

## 5. InventoryLogs
Attributes: 
- **LogID** (PK)
- ItemID (FK)
- ChangeAmount
- Timestamp
- UserID (FK)
- Reason

## 6. Vitals
Attributes: 
- **VitalID** (PK)
- PatientID (FK)
- Timestamp
- HeartRate
- BloodPressure
- Temperature
- OxygenLevel

## 7. Messages (Chat)
Attributes: 
- **MessageID** (PK)
- SenderID (FK)
- ReceiverID (FK)
- Timestamp
- Content

## 8. Notifications
Attributes: 
- **NotificationID** (PK)
- UserID (FK)
- Message
- Timestamp
- IsRead

## 9. Reports
Attributes: 
- **ReportID** (PK)
- Type (Visits, Ailments, Medications)
- GeneratedBy (UserID)
- Timestamp
- FilePath
