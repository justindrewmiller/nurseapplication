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
/****** Object:  StoredProcedure [dbo].[sp_mostPerformedTestsDuringDates]    Script Date: 4/24/2017 5:14:39 PM ******/
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
cast(cast(count(CASE WHEN FLOOR(DATEDIFF(yy, DOB, testdate)) >= 30 AND FLOOR(DATEDIFF(yy, DOB, testDate)) < 39 THEN 1 END) as float) / cast(count(testresults.testcode) as float) * 100 as decimal(5,2)) AS 'Age30to39', 
cast(cast(count(CASE WHEN FLOOR(DATEDIFF(yy, DOB, testdate)) >= 40 AND FLOOR(DATEDIFF(yy, DOB, testDate)) < 49 THEN 1 END) as float) / cast(count(testresults.testcode) as float) * 100 as decimal(5,2)) AS 'Age40to49', 
cast(cast(count(CASE WHEN FLOOR(DATEDIFF(yy, DOB, testdate)) >= 50 AND FLOOR(DATEDIFF(yy, DOB, testDate)) < 59 THEN 1 END) as float) / cast(count(testresults.testcode) as float) * 100 as decimal(5,2)) AS 'Age50to59'
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

GO
USE [master]
GO
ALTER DATABASE [cs6232-g2] SET  READ_WRITE 
GO
