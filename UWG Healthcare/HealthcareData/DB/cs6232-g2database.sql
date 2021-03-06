USE [master]
GO
/****** Object:  Database [cs6232-g2]    Script Date: 4/24/2017 5:14:39 PM ******/
CREATE DATABASE [cs6232-g2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WolfHealthcare', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\WolfHealthcare.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WolfHealthcare_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\WolfHealthcare_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [cs6232-g2] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cs6232-g2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cs6232-g2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cs6232-g2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cs6232-g2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cs6232-g2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cs6232-g2] SET ARITHABORT OFF 
GO
ALTER DATABASE [cs6232-g2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cs6232-g2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cs6232-g2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cs6232-g2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cs6232-g2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cs6232-g2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cs6232-g2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cs6232-g2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cs6232-g2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cs6232-g2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [cs6232-g2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cs6232-g2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cs6232-g2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cs6232-g2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cs6232-g2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cs6232-g2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cs6232-g2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cs6232-g2] SET RECOVERY FULL 
GO
ALTER DATABASE [cs6232-g2] SET  MULTI_USER 
GO
ALTER DATABASE [cs6232-g2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cs6232-g2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cs6232-g2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cs6232-g2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [cs6232-g2] SET DELAYED_DURABILITY = DISABLED 
GO
USE [cs6232-g2]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 4/24/2017 5:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 4/24/2017 5:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Appointment](
	[ApptID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NOT NULL,
	[DoctorID] [int] NOT NULL,
	[apptDateTime] [datetime] NOT NULL,
	[Reason] [varchar](200) NOT NULL,
	[IsCheckedIn] [bit] NULL,
 CONSTRAINT [PK_Appointment_1] PRIMARY KEY CLUSTERED 
(
	[ApptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Diagnoses]    Script Date: 4/24/2017 5:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Diagnoses](
	[DiagnosesCode] [int] NOT NULL,
	[DiagnosesName] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Diagnoses] PRIMARY KEY CLUSTERED 
(
	[DiagnosesCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 4/24/2017 5:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[DoctorID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
 CONSTRAINT [PK_Doctors] PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DoctorSpecialty]    Script Date: 4/24/2017 5:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DoctorSpecialty](
	[DoctorID] [int] NOT NULL,
	[Specialty] [varchar](75) NOT NULL,
 CONSTRAINT [PK_DoctorSpecialty] PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC,
	[Specialty] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LabTests]    Script Date: 4/24/2017 5:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LabTests](
	[TestCode] [int] NOT NULL,
	[TestName] [varchar](200) NOT NULL,
 CONSTRAINT [PK_LabTests] PRIMARY KEY CLUSTERED 
(
	[TestCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Nurses]    Script Date: 4/24/2017 5:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nurses](
	[NurseID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
 CONSTRAINT [PK_Nurses] PRIMARY KEY CLUSTERED 
(
	[NurseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patients]    Script Date: 4/24/2017 5:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[PatientID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Person]    Script Date: 4/24/2017 5:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Person](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[DOB] [date] NOT NULL,
	[FName] [varchar](50) NOT NULL,
	[LName] [varchar](50) NOT NULL,
	[Street] [varchar](50) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[State] [varchar](50) NOT NULL,
	[ZipCode] [varchar](10) NOT NULL,
	[PhoneNum] [varchar](10) NULL,
	[SSN] [varchar](10) NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Specialty]    Script Date: 4/24/2017 5:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Specialty](
	[Specialty] [varchar](75) NOT NULL,
 CONSTRAINT [PK_Specialty] PRIMARY KEY CLUSTERED 
(
	[Specialty] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TestResults]    Script Date: 4/24/2017 5:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TestResults](
	[TestCode] [int] NOT NULL,
	[TestDate] [date] NOT NULL,
	[ApptID] [int] NOT NULL,
	[Result] [varchar](100) NULL,
 CONSTRAINT [PK_TestResults_1] PRIMARY KEY CLUSTERED 
(
	[TestCode] ASC,
	[TestDate] ASC,
	[ApptID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 4/24/2017 5:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserInfo](
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](100) NULL,
	[AdminID] [int] NULL,
	[DoctorID] [int] NULL,
	[NurseID] [int] NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Visits]    Script Date: 4/24/2017 5:14:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Visits](
	[VisitID] [int] IDENTITY(1,1) NOT NULL,
	[ApptID] [int] NOT NULL,
	[SysBP] [int] NOT NULL,
	[DiaBP] [int] NOT NULL,
	[BodyTemp] [decimal](10, 2) NOT NULL,
	[Pulse] [int] NOT NULL,
	[Symptoms] [varchar](200) NOT NULL,
	[NurseID] [int] NOT NULL,
	[DiagnosesCode] [int] NOT NULL,
 CONSTRAINT [PK_Visits] PRIMARY KEY CLUSTERED 
(
	[VisitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Admins]  WITH CHECK ADD  CONSTRAINT [FK_Admins_Person] FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([PersonID])
GO
ALTER TABLE [dbo].[Admins] CHECK CONSTRAINT [FK_Admins_Person]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Doctors] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctors] ([DoctorID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Doctors]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Patients] FOREIGN KEY([PatientID])
REFERENCES [dbo].[Patients] ([PatientID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Patients]
GO
ALTER TABLE [dbo].[Doctors]  WITH CHECK ADD  CONSTRAINT [FK_Doctors_Person] FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([PersonID])
GO
ALTER TABLE [dbo].[Doctors] CHECK CONSTRAINT [FK_Doctors_Person]
GO
ALTER TABLE [dbo].[DoctorSpecialty]  WITH CHECK ADD  CONSTRAINT [FK_DoctorSpecialty_Doctors] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctors] ([DoctorID])
GO
ALTER TABLE [dbo].[DoctorSpecialty] CHECK CONSTRAINT [FK_DoctorSpecialty_Doctors]
GO
ALTER TABLE [dbo].[DoctorSpecialty]  WITH CHECK ADD  CONSTRAINT [FK_DoctorSpecialty_Specialty] FOREIGN KEY([Specialty])
REFERENCES [dbo].[Specialty] ([Specialty])
GO
ALTER TABLE [dbo].[DoctorSpecialty] CHECK CONSTRAINT [FK_DoctorSpecialty_Specialty]
GO
ALTER TABLE [dbo].[Nurses]  WITH CHECK ADD  CONSTRAINT [FK_Nurses_Person] FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([PersonID])
GO
ALTER TABLE [dbo].[Nurses] CHECK CONSTRAINT [FK_Nurses_Person]
GO
ALTER TABLE [dbo].[Patients]  WITH CHECK ADD  CONSTRAINT [FK_Patients_Person] FOREIGN KEY([PersonID])
REFERENCES [dbo].[Person] ([PersonID])
GO
ALTER TABLE [dbo].[Patients] CHECK CONSTRAINT [FK_Patients_Person]
GO
ALTER TABLE [dbo].[TestResults]  WITH CHECK ADD  CONSTRAINT [FK_TestResults_Appointment] FOREIGN KEY([ApptID])
REFERENCES [dbo].[Appointment] ([ApptID])
GO
ALTER TABLE [dbo].[TestResults] CHECK CONSTRAINT [FK_TestResults_Appointment]
GO
ALTER TABLE [dbo].[TestResults]  WITH CHECK ADD  CONSTRAINT [FK_TestResults_LabTests] FOREIGN KEY([TestCode])
REFERENCES [dbo].[LabTests] ([TestCode])
GO
ALTER TABLE [dbo].[TestResults] CHECK CONSTRAINT [FK_TestResults_LabTests]
GO
ALTER TABLE [dbo].[UserInfo]  WITH CHECK ADD  CONSTRAINT [FK_UserInfo_Admins] FOREIGN KEY([AdminID])
REFERENCES [dbo].[Admins] ([AdminID])
GO
ALTER TABLE [dbo].[UserInfo] CHECK CONSTRAINT [FK_UserInfo_Admins]
GO
ALTER TABLE [dbo].[UserInfo]  WITH CHECK ADD  CONSTRAINT [FK_UserInfo_Doctors] FOREIGN KEY([DoctorID])
REFERENCES [dbo].[Doctors] ([DoctorID])
GO
ALTER TABLE [dbo].[UserInfo] CHECK CONSTRAINT [FK_UserInfo_Doctors]
GO
ALTER TABLE [dbo].[UserInfo]  WITH CHECK ADD  CONSTRAINT [FK_UserInfo_Nurses] FOREIGN KEY([NurseID])
REFERENCES [dbo].[Nurses] ([NurseID])
GO
ALTER TABLE [dbo].[UserInfo] CHECK CONSTRAINT [FK_UserInfo_Nurses]
GO
ALTER TABLE [dbo].[Visits]  WITH CHECK ADD  CONSTRAINT [FK_Visits_Appointment] FOREIGN KEY([VisitID])
REFERENCES [dbo].[Appointment] ([ApptID])
GO
ALTER TABLE [dbo].[Visits] CHECK CONSTRAINT [FK_Visits_Appointment]
GO
ALTER TABLE [dbo].[Visits]  WITH CHECK ADD  CONSTRAINT [FK_Visits_Diagnoses] FOREIGN KEY([DiagnosesCode])
REFERENCES [dbo].[Diagnoses] ([DiagnosesCode])
GO
ALTER TABLE [dbo].[Visits] CHECK CONSTRAINT [FK_Visits_Diagnoses]
GO
ALTER TABLE [dbo].[Visits]  WITH CHECK ADD  CONSTRAINT [FK_Visits_Nurses] FOREIGN KEY([NurseID])
REFERENCES [dbo].[Nurses] ([NurseID])
GO
ALTER TABLE [dbo].[Visits] CHECK CONSTRAINT [FK_Visits_Nurses]
GO



USE [cs6232-g2]
GO
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (1, CAST(N'1989-01-01' AS Date), N'Sarah', N'Smith', N'414 Rush St', N'Oklahoma City', N'Oklahoma', N'11119', N'5555555555', N'319031042')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (2, CAST(N'1989-02-01' AS Date), N'Sarah', N'Smith', N'514 Slow St', N'Oklahoma City', N'Oklahoma', N'11119', N'1555555556', N'584031555')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (3, CAST(N'1988-02-03' AS Date), N'Jim', N'Parsons', N'675 34 St', N'Oklahoma City', N'Oklahoma', N'73112', N'8797541212', N'310941940')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (4, CAST(N'1983-03-29' AS Date), N'Kilby', N'Smart', N'777 Park Ave', N'Oklahoma City', N'Oklahoma', N'11111', N'7771238585', N'391041948')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (5, CAST(N'1985-04-11' AS Date), N'Emily', N'Short', N'3180 N Expressway', N'Edmond', N'Oklahoma', N'73115', N'8795685252', N'987638472')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (6, CAST(N'1970-05-03' AS Date), N'Brian', N'Alca', N'545 Flamingo St', N'Guthrie', N'Oklahoma', N'73118', N'9511599562', N'937148164')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (7, CAST(N'1972-06-27' AS Date), N'Jose', N'Pubb', N'3939 Park Way', N'Edmond', N'Oklahoma', N'73110', N'3216547896', N'471938108')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (8, CAST(N'1960-07-07' AS Date), N'Juan', N'Marquez', N'383 NW 32nd St', N'Edmond', N'Oklahoma', N'73110', N'5418527845', N'494281048')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (9, CAST(N'1962-08-13' AS Date), N'Lauren', N'Strom', N'1234 2nd St', N'Oklahoma City', N'Oklahoma', N'73112', N'1234567809', N'594810381')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (10, CAST(N'1969-06-09' AS Date), N'Zach', N'Smith', N'44 SW 44th St', N'Oklahoma City', N'Oklahoma', N'73112', N'4561239876', N'184018471')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (11, CAST(N'1975-10-14' AS Date), N'Super', N'Man', N'32 No Kryptonite', N'Midwest City', N'Oklahoma', N'73129', N'7777777777', N'402485209')
INSERT [dbo].[Person] ([PersonID], [DOB], [FName], [LName], [Street], [City], [State], [ZipCode], [PhoneNum], [SSN]) VALUES (12, CAST(N'1962-11-01' AS Date), N'Kent', N'Clark', N'41 Jersey Ave', N'Midwest City', N'Oklahoma', N'73129', N'7374567272', N'314985208')
SET IDENTITY_INSERT [dbo].[Person] OFF
SET IDENTITY_INSERT [dbo].[Admins] ON 

INSERT [dbo].[Admins] ([AdminID], [PersonID]) VALUES (1, 12)
SET IDENTITY_INSERT [dbo].[Admins] OFF
SET IDENTITY_INSERT [dbo].[Doctors] ON 

INSERT [dbo].[Doctors] ([DoctorID], [PersonID]) VALUES (1, 9)
INSERT [dbo].[Doctors] ([DoctorID], [PersonID]) VALUES (2, 6)
INSERT [dbo].[Doctors] ([DoctorID], [PersonID]) VALUES (3, 5)
SET IDENTITY_INSERT [dbo].[Doctors] OFF
SET IDENTITY_INSERT [dbo].[Nurses] ON 

INSERT [dbo].[Nurses] ([NurseID], [PersonID]) VALUES (1, 11)
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
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (10, 1, 1, CAST(N'2017-04-18 01:08:00.000' AS DateTime), N'I want to add a new test.', 0)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (11, 1, 1, CAST(N'2017-04-24 14:11:00.000' AS DateTime), N'I need a new appointment', 1)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (12, 1, 1, CAST(N'2017-04-25 03:34:00.000' AS DateTime), N'I have an appointment tomorrow.', 0)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (13, 1, 2, CAST(N'2017-04-24 03:56:00.000' AS DateTime), N'Lets see if we can create an appointment', 1)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (14, 4, 3, CAST(N'2017-04-24 05:03:00.000' AS DateTime), N'I have been having back pain the last three days.', 0)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (15, 7, 3, CAST(N'2017-04-24 05:39:00.000' AS DateTime), N'I can''t seem to stop cracking my neck.', 0)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (16, 1, 1, CAST(N'2017-04-26 08:09:00.000' AS DateTime), N'Test to see if I can edit visit', 1)
INSERT [dbo].[Appointment] ([ApptID], [PatientID], [DoctorID], [apptDateTime], [Reason], [IsCheckedIn]) VALUES (17, 1, 2, CAST(N'2017-04-27 08:43:00.000' AS DateTime), N'I need to see if I can update a new appointment', 0)
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
INSERT [dbo].[Visits] ([VisitID], [ApptID], [SysBP], [DiaBP], [BodyTemp], [Pulse], [Symptoms], [NurseID], [DiagnosesCode]) VALUES (11, 13, 100, 105, CAST(50.00 AS Decimal(10, 2)), 50, N'I have been having severe headaches', 1, 1)
INSERT [dbo].[Visits] ([VisitID], [ApptID], [SysBP], [DiaBP], [BodyTemp], [Pulse], [Symptoms], [NurseID], [DiagnosesCode]) VALUES (12, 16, 51, 50, CAST(98.50 AS Decimal(10, 2)), 100, N'Need a new kidney someone please help!!!', 1, 1)
SET IDENTITY_INSERT [dbo].[Visits] OFF



USE [cs6232-g2]
GO
/****** Object:  StoredProcedure [dbo].[sp_mostPerformedTestsDuringDates]    Script Date: 4/12/2017 10:39:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_mostPerformedTestsDuringDates]
	@startDate smalldatetime, @endDate smalldatetime
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	IF (ISNULL(@startDate, 0) = 0)
		BEGIN
		RAISERROR('Invalid parameter: start date cannot be NULL or zero', 18, 0)
		RETURN
	END

	IF (ISNULL(@endDate, 0) = 0)
		BEGIN
		RAISERROR('Invalid parameter: end date cannot be NULL or zero', 18, 0)
		RETURN
	END

	IF (@startDate > @endDate)
		BEGIN
		RAISERROR('Invalid parameter: start date cannot be before end date', 18, 0)
		RETURN
	END
	
	select TestResults.TestCode as 'TestCode', TestName as 'TestName', count(TestResults.TestCode) as 'NumberofTests',
(select count(TestResults.TestCode) from TestResults where (TestResults.TestDate >= @startDate and TestResults.TestDate <= @endDate)) as 'AllNumberofTests',
cast(cast(count(testresults.testcode) as float) / cast((select count(TestResults.TestCode) from TestResults where (TestResults.TestDate >= @startDate and TestResults.TestDate <= @endDate)) as float) * 100 as decimal(5,2)) as 'PercentofTotal',
sum(case when Result = 'normal' then 1 else 0 end) as 'Normal', sum(case when result = 'abnormal' then 1 else 0 end) as 'Abnormal',
cast(cast(count(CASE WHEN FLOOR(DATEDIFF(yy, DOB, testdate)) >= 18 AND FLOOR(DATEDIFF(yy, DOB, testDate)) < 29 THEN 1 END) as float) / cast(count(testresults.testcode) as float) * 100 as decimal(5,2)) AS 'Age18to29', 
cast(cast(count(CASE WHEN FLOOR(DATEDIFF(yy, DOB, testdate)) < 18 OR FLOOR(DATEDIFF(yy, DOB, testDate)) >= 30 THEN 1 END) as float) / cast(count(testresults.testcode) as float) * 100 as decimal(5,2)) AS 'AllOtherAges' 
FROM     dbo.Patients INNER JOIN
                  dbo.Appointment ON dbo.Patients.PatientID = dbo.Appointment.PatientID INNER JOIN
                  dbo.Person ON dbo.Patients.PersonID = dbo.Person.PersonID RIGHT OUTER JOIN
                  dbo.TestResults ON dbo.Appointment.ApptID = dbo.TestResults.ApptID LEFT OUTER JOIN
                  dbo.LabTests ON dbo.TestResults.TestCode = dbo.LabTests.TestCode
				  where (testDate >= @startDate and testDate <= @endDate)
				  group by testresults.testcode, labtests.testname
				  having count(TestResults.TestCode) >= 2
order by count(TestResults.TestCode) desc, TestResults.TestCode desc;

END