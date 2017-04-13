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
