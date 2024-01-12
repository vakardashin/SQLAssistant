IF OBJECT_ID ('dbo.Departments') IS NOT NULL DROP TABLE Departments;
IF OBJECT_ID ('dbo.Departments') IS NULL
CREATE TABLE Departments (
	DepartmentID INT IDENTITY NOT NULL PRIMARY KEY,
	DepartmentName VARCHAR(250) NOT NULL DEFAULT ' '
	);
	SET IDENTITY_INSERT Departments ON;
	INSERT INTO Departments (DepartmentID, DepartmentName)
	VALUES (1, 'Accounting');
	INSERT INTO Departments (DepartmentID, DepartmentName)
	VALUES (2, 'Software Development');
	INSERT INTO Departments (DepartmentID, DepartmentName)
	VALUES (3, 'Customer Support');
	SET IDENTITY_INSERT Departments OFF;
