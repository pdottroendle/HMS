# Add
curl "http://localhost:3000/add_Users?UserID=003&Username=Charlie&PasswordHash=abc123&Role=Admin&Email=charlie@example.com&Phone=789.000.0000"

# Search
curl "http://localhost:3000/Users?Role=Admin&Username="

# Add
curl "http://localhost:3000/add_Patients?PatientID=P003&UserID=003&Name=Chris&DOB=1985-05-05&Gender=Other&Address=789 Oak St&ContactInfo=chris@example.com&MedicalHistory=None"

# Search
curl "http://localhost:3000/Patients?Gender=Other&Name="

# Add
curl "http://localhost:3000/add_Appointments?AppointmentID=A003&PatientID=P003&DoctorID=002&DateTime=2023-08-03T14:00:00Z&Status=Scheduled&Notes=Consultation"

# Search
curl "http://localhost:3000/Appointments?Status=Scheduled&DoctorID="

# Add
curl "http://localhost:3000/add_Inventory?ItemID=I003&Name=Gloves&Quantity=300&Threshold=50&LastUpdated=2023-08-03T07:00:00Z"

# Search
curl "http://localhost:3000/Inventory?Name=Gloves"

# Add
curl "http://localhost:3000/add_InventoryLogs?LogID=L003&ItemID=I003&ChangeAmount=-5&Timestamp=2023-08-03T08:00:00Z&UserID=003&Reason=Used in ER"

# Search
curl "http://localhost:3000/InventoryLogs?Reason=Used in ER"

# Add
curl "http://localhost:3000/add_Vitals?VitalID=V003&PatientID=P003&Timestamp=2023-08-03T10:00:00Z&HeartRate=70&BloodPressure=118/76&Temperature=98.5&OxygenLevel=99"

# Search
curl "http://localhost:3000/Vitals?HeartRate=70"

# Add
curl "http://localhost:3000/add_Messages?MessageID=M003&SenderID=001&ReceiverID=002&Timestamp=2023-08-03T09:00:00Z&Content=Please confirm the appointment."

# Search
curl "http://localhost:3000/Messages?SenderID=001"

# Add
curl "http://localhost:3000/add_Notifications?NotificationID=N003&UserID=003&Message=System update&Timestamp=2023-08-03T08:30:00Z&IsRead=false"

# Search
curl "http://localhost:3000/Notifications?IsRead=false"

# Add
curl "http://localhost:3000/add_Reports?ReportID=R003&Type=Vitals&GeneratedBy=003&Timestamp=2023-08-03T12:00:00Z&FilePath=/reports/vitals_R003.pdf"

# Search
curl "http://localhost:3000/Reports?Type=Vitals"

COPY PROJECT TO GVM
gcloud compute scp --recurse "C:\Node\GitPort\LocalStories\MogoDB-HMS-Backend" p94100687@skyturtle:/home/p94100687/hospital_management/ --zone=us-west1-a

gcloud compute ssh skyturtle --zone=us-west1-a

sudo apt update
sudo apt install -y nodejs npm
sudo apt install -y mongodb-org
sudo systemctl start mongod
sudo systemctl enable mongod
sudo systemctl status mongod
navigate to the directory>>>>>>>>>
npm install express cors body-parser mongoose multer
install express cors body-parser


