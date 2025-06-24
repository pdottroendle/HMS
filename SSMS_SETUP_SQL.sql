CREATE DATABASE HMSDB;
GO

USE HMSDB;
GO

CREATE TABLE Users (
    UserID NVARCHAR(255),
    Username NVARCHAR(255),
    PasswordHash NVARCHAR(255),
    Role NVARCHAR(255),
    Email NVARCHAR(255),
    Phone NVARCHAR(255)
);

CREATE TABLE Appointment (
    AppointmentID NVARCHAR(255),
    PatientID NVARCHAR(255),
    DoctorID NVARCHAR(255),
    DateTime NVARCHAR(255),
    Status NVARCHAR(255),
    Notes NVARCHAR(255)
);

CREATE TABLE Vital (
    VitalID NVARCHAR(255),
    PatientID NVARCHAR(255),
    Timestamp NVARCHAR(255),
    HeartRate INT,
    BloodPressure NVARCHAR(255),
    Temperature FLOAT,
    OxygenLevel INT
);

CREATE TABLE Report (
    ReportID NVARCHAR(255),
    Type NVARCHAR(255),
    GeneratedBy NVARCHAR(255),
    Timestamp NVARCHAR(255),
    FilePath NVARCHAR(255)
);

CREATE TABLE Patient (
    PatientID NVARCHAR(255),
    UserID NVARCHAR(255),
    Name NVARCHAR(255),
    DOB NVARCHAR(255),
    Gender NVARCHAR(255),
    Address NVARCHAR(255),
    ContactInfo NVARCHAR(255),
    MedicalHistory NVARCHAR(255)
);

CREATE TABLE Notification (
    NotificationID NVARCHAR(255),
    UserID NVARCHAR(255),
    Message NVARCHAR(255),
    Timestamp NVARCHAR(255),
    IsRead INT
);

CREATE TABLE Message (
    MessageID NVARCHAR(255),
    SenderID NVARCHAR(255),
    ReceiverID NVARCHAR(255),
    Timestamp NVARCHAR(255),
    Content NVARCHAR(255)
);

CREATE TABLE InventoryLog (
    LogID NVARCHAR(255),
    ItemID NVARCHAR(255),
    ChangeAmount INT,
    Timestamp NVARCHAR(255),
    UserID NVARCHAR(255),
    Reason NVARCHAR(255)
);

CREATE TABLE Inventory (
    ItemID NVARCHAR(255),
    Name NVARCHAR(255),
    Quantity INT,
    Threshold INT,
    LastUpdated NVARCHAR(255)
);


CREATE TABLE Dashboard (
    DashboardID NVARCHAR(255) PRIMARY KEY,
    WardName NVARCHAR(255),
    BedAvailability NVARCHAR(255),
    EmergencyStatus NVARCHAR(255),
    Timestamp NVARCHAR(255)
);


USE HMSDB;
GO

-- Insert example entries into Users table
INSERT INTO Users (UserID, Username, PasswordHash, Role, Email, Phone) VALUES
('U001', 'john_doe', 'hashed_password_1', 'Doctor', 'john@example.com', '123-456-7890'),
('U002', 'jane_doe', 'hashed_password_2', 'Patient', 'jane@example.com', '098-765-4321');

-- Insert example entries into Appointment table
INSERT INTO Appointment (AppointmentID, PatientID, DoctorID, DateTime, Status, Notes) VALUES
('A001', 'P001', 'D001', '2023-08-01T10:00:00', 'Scheduled', 'Routine check-up'),
('A002', 'P002', 'D002', '2023-08-02T11:00:00', 'Completed', 'Follow-up visit');

-- Insert example entries into Vital table
INSERT INTO Vital (VitalID, PatientID, Timestamp, HeartRate, BloodPressure, Temperature, OxygenLevel) VALUES
('V001', 'P001', '2023-08-01T10:00:00', 72, '120/80', 98.6, 98),
('V002', 'P002', '2023-08-02T11:00:00', 75, '130/85', 99.1, 97);

-- Insert example entries into Report table
INSERT INTO Report (ReportID, Type, GeneratedBy, Timestamp, FilePath) VALUES
('R001', 'Medical', 'D001', '2023-08-01T10:00:00', '/path/to/report1.pdf'),
('R002', 'Lab', 'D002', '2023-08-02T11:00:00', '/path/to/report2.pdf');

-- Insert example entries into Patient table
INSERT INTO Patient (PatientID, UserID, Name, DOB, Gender, Address, ContactInfo, MedicalHistory) VALUES
('P001', 'U002', 'Jane Doe', '1990-01-01', 'Female', '123 Main St', '123-456-7890', 'No known allergies'),
('P002', 'U003', 'John Smith', '1985-05-15', 'Male', '456 Elm St', '098-765-4321', 'Diabetic');

-- Insert example entries into Notification table
INSERT INTO Notification (NotificationID, UserID, Message, Timestamp, IsRead) VALUES
('N001', 'U001', 'Your appointment is scheduled for 2023-08-01.', '2023-07-31T09:00:00', 0),
('N002', 'U002', 'Your lab results are ready.', '2023-08-02T10:00:00', 1);

-- Insert example entries into Message table
INSERT INTO Message (MessageID, SenderID, ReceiverID, Timestamp, Content) VALUES
('M001', 'U001', 'U002', '2023-07-31T09:00:00', 'Please remember to fast before your appointment.'),
('M002', 'U002', 'U001', '2023-08-01T10:00:00', 'Thank you for the reminder.');

-- Insert example entries into InventoryLog table
INSERT INTO InventoryLog (LogID, ItemID, ChangeAmount, Timestamp, UserID, Reason) VALUES
('L001', 'I001', 10, '2023-08-01T10:00:00', 'U001', 'Restocked'),
('L002', 'I002', -5, '2023-08-02T11:00:00', 'U002', 'Used in procedure');

-- Insert example entries into Inventory table
INSERT INTO Inventory (ItemID, Name, Quantity, Threshold, LastUpdated) VALUES
('I001', 'Bandages', 100, 50, '2023-08-01T07:00:00'),
('I002', 'Syringes', 200, 100, '2023-08-02T08:00:00');


SELECT * FROM Users
SELECT * FROM Appointment
SELECT * FROM Vital
SELECT * FROM Report
SELECT * FROM Patient
SELECT * FROM Notification
SELECT * FROM Message
SELECT * FROM InventoryLog
SELECT * FROM Inventory
