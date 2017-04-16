SET IDENTITY_INSERT Person ON

Insert into Person (PersonID, DOB, Fname, Lname, Street, City, State, ZipCode, PhoneNum)  VALUES (1, '1989-01-01', 'Sarah', 'Smith', '3847 South St', 'Oklahoma City', 'Oklahoma', '73112', '5555555555');
Insert into Person (PersonID, DOB, Fname, Lname, Street, City, State,  ZipCode, PhoneNum) values  (2, '1988-02-03', 'Jim', 'Parsons', '675 34 St', 'Oklahoma City', 'Oklahoma', '73112','8797541212');
Insert into Person (PersonID, DOB, Fname, Lname, Street, City, State,  ZipCode, PhoneNum) values (3, '1983-03-29', 'Kilby', 'Smart', '777 Park Ave', 'Oklahoma City', 'Oklahoma', '73129', '7771238585');
Insert into Person (PersonID, DOB, Fname, Lname, Street, City, State,  ZipCode, PhoneNum) values (4, '1985-04-11', 'Emily', 'Short', '3180 N Expressway', 'Edmond', 'Oklahoma', '73114', '8795685252');
Insert into Person (PersonID, DOB, Fname, Lname, Street, City, State,  ZipCode, PhoneNum) values (5, '1970-05-03', 'Brian', 'Alca', '545 Flamingo St', 'Guthrie', 'Oklahoma', '73118', '9511599562');
Insert into Person (PersonID, DOB, Fname, Lname, Street, City, State,  ZipCode, PhoneNum) values (6, '1972-06-27', 'Jose', 'Pubb', '3939 Park Way', 'Edmond', 'Oklahoma', '73110', '3216547896');
Insert into Person (PersonID, DOB, Fname, Lname, Street, City, State,  ZipCode, PhoneNum) values (7, '1960-07-07', 'Juan', 'Marquez', '383 NW 32nd St', 'Edmond', 'Oklahoma', '73110', '5418527845');
Insert into Person (PersonID, DOB, Fname, Lname, Street, City, State,  ZipCode, PhoneNum) values (8, '1962-08-13', 'Lauren', 'Strom', '1234 2nd St', 'Oklahoma City', 'Oklahoma', '73112','1234567809');
Insert into Person (PersonID, DOB, Fname, Lname, Street, City, State,  ZipCode, PhoneNum) values (9, '1969-06-09', 'Zach', 'Smith', '44 SW 44th St', 'Oklahoma City', 'Oklahoma', '73112','4561239876');
Insert into Person (PersonID, DOB, Fname, Lname, Street, City, State,  ZipCode, PhoneNum) values (10, '1975-10-14', 'Super', 'Man', '32 No Kryptonite', 'Midwest City', 'Oklahoma', '73129','7777777777');
Insert into Person (PersonID, DOB, Fname, Lname, Street, City, State,  ZipCode, PhoneNum) values (11, '1962-11-01', 'Kent', 'Clark', '41 Jersey Ave', 'Midwest City', 'Oklahoma', '73129','7374567272');
SET IDENTITY_INSERT Person OFF

SET IDENTITY_INSERT Patients ON

Insert into Patients (PatientID, PersonID) VALUES (1, 1);
Insert into Patients (PatientID, PersonID) VALUES (2, 2);
Insert into Patients (PatientID, PersonID) VALUES (3, 3);
Insert into Patients (PatientID, PersonID) VALUES (4, 4);
Insert into Patients (PatientID, PersonID) VALUES (5, 5);
Insert into Patients (PatientID, PersonID) VALUES (6, 6);
Insert into Patients (PatientID, PersonID) VALUES (7, 7);
Insert into Patients (PatientID, PersonID) VALUES (8, 8);

SET IDENTITY_INSERT Patients OFF

SET IDENTITY_INSERT Doctors ON

Insert into Doctors (DoctorID, PersonID) VALUES (1, 9);

SET IDENTITY_INSERT Doctors OFF


SET IDENTITY_INSERT Nurses ON

Insert Into Nurses (NurseID, PersonID) VALUES (1, 10);

SET IDENTITY_INSERT Nurses OFF

SET IDENTITY_INSERT Admins ON

Insert Into Admins (AdminID, PersonID) VALUES (1, 11);
SET IDENTITY_INSERT Admins OFF

Insert into LabTests (TestCode, TestName) values (1, 'White Blood Cell (WBC)'); 
Insert into LabTests (TestCode , TestName) values (2, 'Low Density Lipoproteins (LDL)');
Insert into LabTests (TestCode, TestName) values (3, 'Hepatitis A'); 

Insert into diagnoses (diagnosesCode, diagnosesName) values (1, 'Colitis'); 
Insert into diagnoses (diagnosesCode, diagnosesName) values (2, 'Appendicitis'); 
Insert into diagnoses (diagnosesCode, diagnosesName) values (3, 'Broken leg'); 
Insert into diagnoses (diagnosesCode, diagnosesName) values (4, 'Angioid streaks'); 

SET IDENTITY_INSERT Appointment ON

insert into appointment (ApptID, PatientID, DoctorID, apptDateTime, reason) values (1, 1, 1, '2016-11-01', 'Test'); 
insert into appointment (ApptID, PatientID, DoctorID, apptDateTime, reason) values (2, 2, 1, '2016-11-03', 'Test');
insert into appointment (ApptID, PatientID, DoctorID, apptDateTime, reason) values (3, 3, 1, '2016-11-20', 'Test');
insert into appointment (ApptID, PatientID, DoctorID, apptDateTime, reason) values (4, 4, 1, '2016-11-17', 'Test');
insert into appointment (ApptID, PatientID, DoctorID, apptDateTime, reason)  values (5, 5, 1, '2016-11-16', 'Test');
insert into appointment (ApptID, PatientID, DoctorID, apptDateTime, reason) values (6, 6, 1, '2016-11-29', 'Test');
insert into appointment (ApptID, PatientID, DoctorID, apptDateTime, reason) values (7, 7, 1, '2016-11-24', 'Test');
insert into appointment (ApptID, PatientID, DoctorID, apptDateTime, reason) values (8, 8, 1, '2016-11-14', 'Test');

SET IDENTITY_INSERT Appointment OFF

SET IDENTITY_INSERT Visits ON

Insert Into Visits (VisitID, ApptID, NurseID, SysBP, DiaBP, BodyTemp, Pulse, Symptoms,  DiagnosesCode) values (1, 1, 1, 60, 60, 98.6, 60, 'Test', 1);
Insert Into Visits (VisitID, ApptID, NurseID, SysBP, DiaBP, BodyTemp, Pulse, Symptoms,  DiagnosesCode) values (2, 2, 1, 60, 60, 98.6, 60, 'Test', 1);
Insert Into Visits (VisitID, ApptID, NurseID, SysBP, DiaBP, BodyTemp, Pulse, Symptoms,  DiagnosesCode) values (3, 3, 1, 60, 60, 98.6, 60, 'Test', 1);
Insert Into Visits (VisitID, ApptID, NurseID, SysBP, DiaBP, BodyTemp, Pulse, Symptoms,  DiagnosesCode) values (4, 4, 1, 60, 60, 98.6, 60, 'Test', 1);
Insert Into Visits (VisitID, ApptID, NurseID, SysBP, DiaBP, BodyTemp, Pulse, Symptoms,  DiagnosesCode) values (5, 5, 1, 60, 60, 98.6, 60, 'Test', 1);
Insert Into Visits (VisitID, ApptID, NurseID, SysBP, DiaBP, BodyTemp, Pulse, Symptoms,  DiagnosesCode) values (6, 6, 1, 60, 60, 98.6, 60, 'Test', 1);
Insert Into Visits (VisitID, ApptID, NurseID, SysBP, DiaBP, BodyTemp, Pulse, Symptoms,  DiagnosesCode) values (7, 7, 1, 60, 60, 98.6, 60, 'Test', 1);
Insert Into Visits (VisitID, ApptID, NurseID, SysBP, DiaBP, BodyTemp, Pulse, Symptoms,  DiagnosesCode) values (8, 8, 1, 60, 60, 98.6, 60, 'Test', 1);

SET IDENTITY_INSERT Visits OFF

Insert into TestResults (TestCode, TestDate, Result, ApptID) VALUES (2, '2016-11-01', 'normal', 1);  
Insert into TestResults (TestCode, TestDate, Result, ApptID) VALUES (1, '2016-11-01', 'abnormal', 1); 
Insert into TestResults (TestCode, TestDate, Result, ApptID) VALUES (2, '2016-11-03', 'abnormal', 2); 
Insert into TestResults (TestCode, TestDate, Result, ApptID) VALUES (3, '2016-11-03', 'abnormal', 2); 
Insert into TestResults (TestCode, TestDate, Result, ApptID) VALUES (3, '2016-11-20', 'normal', 3);
Insert into TestResults (TestCode, TestDate, Result, ApptID) VALUES (2, '2016-11-17', 'normal', 4);  
Insert into TestResults (TestCode, TestDate, Result, ApptID) VALUES (1, '2016-11-16', 'normal', 5);  
Insert into TestResults (TestCode, TestDate, Result, ApptID) VALUES (1, '2016-11-29', 'abnormal', 6); 
Insert into TestResults (TestCode, TestDate, Result, ApptID) VALUES (1, '2016-11-24', 'normal', 7); 
Insert into TestResults (TestCode, TestDate, Result, ApptID) VALUES (2, '2016-11-24', 'normal', 7); 
Insert into TestResults (TestCode, TestDate, Result, ApptID) VALUES (3, '2016-11-24', 'normal',7); 
Insert into TestResults (TestCode, TestDate, Result, ApptID) VALUES (2, '2016-11-14', 'abnormal', 8);

INSERT [UserInfo] ([Username], [Password], [AdminID], [DoctorID], [NurseID]) VALUES ('clark1', '25451882202207340139129165241162167124187831522256', 1, NULL, NULL);
INSERT [UserInfo] ([Username], [Password], [AdminID], [DoctorID], [NurseID]) VALUES ('smith1', '1731204620517211915198235154982287914413563185127178107', NULL, 1, NULL);
INSERT [UserInfo] ([Username], [Password], [AdminID], [DoctorID], [NurseID]) VALUES ('superman1', '18422431324844178791861761647315123232191461337187', NULL, NULL, 1);







