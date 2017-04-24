USE [cs6232-g2]
GO
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (1, CAST(N'1989-01-01' AS Date), N'Sarah', N'Smith', N'414 Rush St', N'Oklahoma City', N'Oklahoma', N'11119', N'5555555555', N'319031042')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (2, CAST(N'1988-02-03' AS Date), N'Jim', N'Parsons', N'675 34 St', N'Oklahoma City', N'Oklahoma', N'73112', N'8797541212', N'310941940')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (3, CAST(N'1983-03-29' AS Date), N'Kilby', N'Smart', N'777 Park Ave', N'Oklahoma City', N'Oklahoma', N'11111', N'7771238585', N'391041948')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (4, CAST(N'1985-04-11' AS Date), N'Emily', N'Short', N'3180 N Expressway', N'Edmond', N'Oklahoma', N'73115', N'8795685252', N'987638472')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (5, CAST(N'1970-05-03' AS Date), N'Brian', N'Alca', N'545 Flamingo St', N'Guthrie', N'Oklahoma', N'73118', N'9511599562', N'937148164')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (6, CAST(N'1972-06-27' AS Date), N'Jose', N'Pubb', N'3939 Park Way', N'Edmond', N'Oklahoma', N'73110', N'3216547896', N'471938108')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (7, CAST(N'1960-07-07' AS Date), N'Juan', N'Marquez', N'383 NW 32nd St', N'Edmond', N'Oklahoma', N'73110', N'5418527845', N'494281048')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (8, CAST(N'1962-08-13' AS Date), N'Lauren', N'Strom', N'1234 2nd St', N'Oklahoma City', N'Oklahoma', N'73112', N'1234567809', N'594810381')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (9, CAST(N'1969-06-09' AS Date), N'Zach', N'Smith', N'44 SW 44th St', N'Oklahoma City', N'Oklahoma', N'73112', N'4561239876', N'184018471')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (10, CAST(N'1975-10-14' AS Date), N'Super', N'Man', N'32 No Kryptonite', N'Midwest City', N'Oklahoma', N'73129', N'7777777777', N'402485209')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (11, CAST(N'1962-11-01' AS Date), N'Kent', N'Clark', N'41 Jersey Ave', N'Midwest City', N'Oklahoma', N'73129', N'7374567272', N'314985208')
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Admins] ON 

INSERT [dbo].[Admins] ([AdminID], [PersonID]) VALUES (1, 11)
SET IDENTITY_INSERT [dbo].[Admins] OFF
SET IDENTITY_INSERT [dbo].[Doctors] ON 

INSERT [dbo].[Doctors] ([DoctorID], [PersonID]) VALUES (1, 9)
INSERT [dbo].[Doctors] ([DoctorID], [PersonID]) VALUES (2, 6)
INSERT [dbo].[Doctors] ([DoctorID], [PersonID]) VALUES (3, 5)
SET IDENTITY_INSERT [dbo].[Doctors] OFF
SET IDENTITY_INSERT [dbo].[Nurses] ON 

INSERT [dbo].[Nurses] ([NurseID], [PersonID]) VALUES (1, 10)
SET IDENTITY_INSERT [dbo].[Nurses] OFF
INSERT [dbo].[UserInfo] ([Username], [Password], [AdminID], [DoctorID], [NurseID]) VALUES (N'clark1', N'25451882202207340139129165241162167124187831522256', 1, NULL, NULL)
INSERT [dbo].[UserInfo] ([Username], [Password], [AdminID], [DoctorID], [NurseID]) VALUES (N'smith1', N'1731204620517211915198235154982287914413563185127178107', NULL, 1, NULL)
INSERT [dbo].[UserInfo] ([Username], [Password], [AdminID], [DoctorID], [NurseID]) VALUES (N'superman1', N'18422431324844178791861761647315123232191461337187', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Patients] ON 

INSERT [dbo].[Patients] ([PatientID], [PersonID]) VALUES (1, 1)
INSERT [dbo].[Patients] ([PatientID], [PersonID]) VALUES (2, 2)
INSERT [dbo].[Patients] ([PatientID], [PersonID]) VALUES (3, 3)
INSERT [dbo].[Patients] ([PatientID], [PersonID]) VALUES (4, 4)
INSERT [dbo].[Patients] ([PatientID], [PersonID]) VALUES (5, 5)
INSERT [dbo].[Patients] ([PatientID], [PersonID]) VALUES (6, 6)
INSERT [dbo].[Patients] ([PatientID], [PersonID]) VALUES (7, 7)
INSERT [dbo].[Patients] ([PatientID], [PersonID]) VALUES (8, 8)
SET IDENTITY_INSERT [dbo].[Patients] OFF
SET IDENTITY_INSERT [dbo].[Appointment] ON 

INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (1, 1, 1, CAST(N'2016-11-01 00:00:00.000' AS DateTime), N'Test', 1)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (2, 2, 1, CAST(N'2016-11-03 00:00:00.000' AS DateTime), N'Test', 1)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (3, 3, 1, CAST(N'2016-11-20 00:00:00.000' AS DateTime), N'Test', 1)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (4, 4, 1, CAST(N'2016-11-17 00:00:00.000' AS DateTime), N'Test', 1)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (5, 5, 1, CAST(N'2016-11-16 00:00:00.000' AS DateTime), N'Test', 1)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (6, 6, 1, CAST(N'2016-11-29 00:00:00.000' AS DateTime), N'Test', 1)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (7, 7, 1, CAST(N'2016-11-24 00:00:00.000' AS DateTime), N'Test', 1)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (8, 8, 1, CAST(N'2016-11-14 00:00:00.000' AS DateTime), N'Test', 1)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (9, 1, 1, CAST(N'2017-04-17 12:34:00.000' AS DateTime), N'I have a really big headache', 1)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (10, 1, 1, CAST(N'2017-04-18 01:08:00.000' AS DateTime), N'I want to add a new test.', 1)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (11, 1, 1, CAST(N'2017-04-24 14:11:00.000' AS DateTime), N'I need a new appointment', 1)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (12, 1, 1, CAST(N'2017-04-25 03:34:00.000' AS DateTime), N'I have an appointment tomorrow.', 1)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (13, 1, 2, CAST(N'2017-04-24 03:56:00.000' AS DateTime), N'Lets see if we can create an appointment', 1)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (14, 4, 3, CAST(N'2017-04-24 05:03:00.000' AS DateTime), N'I have been having back pain the last three days.', 0)
SET IDENTITY_INSERT [dbo].[Appointment] OFF
INSERT [dbo].[LabTests] ([TestCode], [TestName]) VALUES (1, N'White Blood Cell (WBC)')
INSERT [dbo].[LabTests] ([TestCode], [TestName]) VALUES (2, N'Low Density Lipoproteins (LDL)')
INSERT [dbo].[LabTests] ([TestCode], [TestName]) VALUES (3, N'Hepatitis A')
INSERT [dbo].[TestResults] ([TestCode], [TestDate], [ApptID], [Result]) VALUES (1, CAST(N'2016-11-01' AS Date), 1, N'abnormal')
INSERT [dbo].[TestResults] ([TestCode], [TestDate], [ApptID], [Result]) VALUES (1, CAST(N'2016-11-16' AS Date), 5, N'normal')
INSERT [dbo].[TestResults] ([TestCode], [TestDate], [ApptID], [Result]) VALUES (1, CAST(N'2016-11-24' AS Date), 7, N'normal')
INSERT [dbo].[TestResults] ([TestCode], [TestDate], [ApptID], [Result]) VALUES (1, CAST(N'2016-11-29' AS Date), 6, N'abnormal')
INSERT [dbo].[TestResults] ([TestCode], [TestDate], [ApptID], [Result]) VALUES (2, CAST(N'2016-11-01' AS Date), 1, N'normal')
INSERT [dbo].[TestResults] ([TestCode], [TestDate], [ApptID], [Result]) VALUES (2, CAST(N'2016-11-03' AS Date), 2, N'abnormal')
INSERT [dbo].[TestResults] ([TestCode], [TestDate], [ApptID], [Result]) VALUES (2, CAST(N'2016-11-14' AS Date), 8, N'abnormal')
INSERT [dbo].[TestResults] ([TestCode], [TestDate], [ApptID], [Result]) VALUES (2, CAST(N'2016-11-17' AS Date), 4, N'normal')
INSERT [dbo].[TestResults] ([TestCode], [TestDate], [ApptID], [Result]) VALUES (2, CAST(N'2016-11-24' AS Date), 7, N'normal')
INSERT [dbo].[TestResults] ([TestCode], [TestDate], [ApptID], [Result]) VALUES (3, CAST(N'2016-11-03' AS Date), 2, N'abnormal')
INSERT [dbo].[TestResults] ([TestCode], [TestDate], [ApptID], [Result]) VALUES (3, CAST(N'2016-11-20' AS Date), 3, N'normal')
INSERT [dbo].[TestResults] ([TestCode], [TestDate], [ApptID], [Result]) VALUES (3, CAST(N'2016-11-24' AS Date), 7, N'normal')
INSERT [dbo].[Diagnoses] ([DiagnosesCode], [DiagnosesName]) VALUES (1, N'Colitis')
INSERT [dbo].[Diagnoses] ([DiagnosesCode], [DiagnosesName]) VALUES (2, N'Appendicitis')
INSERT [dbo].[Diagnoses] ([DiagnosesCode], [DiagnosesName]) VALUES (3, N'Broken leg')
INSERT [dbo].[Diagnoses] ([DiagnosesCode], [DiagnosesName]) VALUES (4, N'Angioid streaks')
SET IDENTITY_INSERT [dbo].[Visits] ON 

INSERT [dbo].[Visits] ([VisitID], [ApptID], [SysBP], [DiaBP], [BodyTemp], [Pulse], [Symptoms], [NurseID], [DiagnosesCode]) VALUES (1, 1, 60, 60, CAST(112.00 AS Decimal(10, 2)), 60, N'New Test 4/17/2017', 1, 3)
INSERT [dbo].[Visits] ([VisitID], [ApptID], [SysBP], [DiaBP], [BodyTemp], [Pulse], [Symptoms], [NurseID], [DiagnosesCode]) VALUES (2, 2, 60, 60, CAST(98.60 AS Decimal(10, 2)), 60, N'Test', 1, 1)
INSERT [dbo].[Visits] ([VisitID], [ApptID], [SysBP], [DiaBP], [BodyTemp], [Pulse], [Symptoms], [NurseID], [DiagnosesCode]) VALUES (3, 3, 60, 60, CAST(98.60 AS Decimal(10, 2)), 60, N'Test', 1, 1)
INSERT [dbo].[Visits] ([VisitID], [ApptID], [SysBP], [DiaBP], [BodyTemp], [Pulse], [Symptoms], [NurseID], [DiagnosesCode]) VALUES (4, 4, 60, 60, CAST(98.60 AS Decimal(10, 2)), 60, N'Test', 1, 1)
INSERT [dbo].[Visits] ([VisitID], [ApptID], [SysBP], [DiaBP], [BodyTemp], [Pulse], [Symptoms], [NurseID], [DiagnosesCode]) VALUES (5, 5, 60, 60, CAST(98.60 AS Decimal(10, 2)), 60, N'Test', 1, 1)
INSERT [dbo].[Visits] ([VisitID], [ApptID], [SysBP], [DiaBP], [BodyTemp], [Pulse], [Symptoms], [NurseID], [DiagnosesCode]) VALUES (6, 6, 60, 60, CAST(98.60 AS Decimal(10, 2)), 60, N'Test', 1, 1)
INSERT [dbo].[Visits] ([VisitID], [ApptID], [SysBP], [DiaBP], [BodyTemp], [Pulse], [Symptoms], [NurseID], [DiagnosesCode]) VALUES (7, 7, 60, 60, CAST(98.00 AS Decimal(10, 2)), 60, N'Test', 1, 2)
INSERT [dbo].[Visits] ([VisitID], [ApptID], [SysBP], [DiaBP], [BodyTemp], [Pulse], [Symptoms], [NurseID], [DiagnosesCode]) VALUES (8, 8, 60, 60, CAST(98.60 AS Decimal(10, 2)), 60, N'Test', 1, 1)
INSERT [dbo].[Visits] ([VisitID], [ApptID], [SysBP], [DiaBP], [BodyTemp], [Pulse], [Symptoms], [NurseID], [DiagnosesCode]) VALUES (9, 9, 30, 50, CAST(101.00 AS Decimal(10, 2)), 50, N'Having severe pain in my upper body region', 1, 2)
INSERT [dbo].[Visits] ([VisitID], [ApptID], [SysBP], [DiaBP], [BodyTemp], [Pulse], [Symptoms], [NurseID], [DiagnosesCode]) VALUES (10, 11, 50, 50, CAST(0.10 AS Decimal(10, 2)), 50, N'My asthma has been causing me pain', 1, 1)
INSERT [dbo].[Visits] ([VisitID], [ApptID], [SysBP], [DiaBP], [BodyTemp], [Pulse], [Symptoms], [NurseID], [DiagnosesCode]) VALUES (11, 13, 100, 100, CAST(50.00 AS Decimal(10, 2)), 50, N'I have been having severe headaches.', 1, 1)
SET IDENTITY_INSERT [dbo].[Visits] OFF
