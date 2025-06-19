# Core Entities and Relationships
<b> 1. Users </b> <br>
Attributes: UserID (PK), Username, PasswordHash, Role (Doctor, Nurse, Admin, Patient), Email, Phone<br>
Relationships:<br>
One-to-many with Appointments<br>
One-to-many with Messages (for chat)<br>
One-to-many with Notifications<br>
<b> 2. Patients </b> <br>
Attributes: PatientID (PK), UserID (FK), Name, DOB, Gender, Address, ContactInfo, MedicalHistory (file reference)<br>
Relationships:<br>
One-to-many with Appointments<br>
One-to-many with Vitals<br>
One-to-many with Prescriptions<br>
<b> 3. Appointments </b> <br>
Attributes: AppointmentID (PK), PatientID (FK), DoctorID (FK), DateTime, Status (Scheduled, Cancelled, Completed), Notes<br>
Relationships:<br>
Many-to-one with Patients<br>
Many-to-one with Users (Doctors)<br>
<b> 4. Inventory </b> <br>
Attributes: ItemID (PK), Name, Quantity, Threshold, LastUpdated<br>
Relationships:<br>
One-to-many with InventoryLogs<br>
<b> 5. InventoryLogs </b> <br>
Attributes: LogID (PK), ItemID (FK), ChangeAmount, Timestamp, UserID (FK), Reason<br>
<b> 6. Vitals </b> <br>
Attributes: VitalID (PK), PatientID (FK), Timestamp, HeartRate, BloodPressure, Temperature, OxygenLevel<br>
<b> 7. Messages (Chat) </b> <br>
Attributes: MessageID (PK), SenderID (FK), ReceiverID (FK), Timestamp, Content<br>
<b> 8. Notifications </b> <br>
Attributes: NotificationID (PK), UserID (FK), Message, Timestamp, IsRead<br>
<b> 9. Reports </b> <br>
Attributes: ReportID (PK), Type (Visits, Ailments, Medications), GeneratedBy (UserID), Timestamp, FilePath<br>
