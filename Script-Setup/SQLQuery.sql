-- Create EmployeeDB database
CREATE DATABASE EmployeeDB
GO

USE EmployeeDB
GO

-- Create Employee Table
CREATE TABLE Employee
(
  EmployeeId INT PRIMARY KEY IDENTITY(1,1),
  FirstName VARCHAR(100),
  LastName VARCHAR(100),
  Age INT,
  EmployeeNumber VARCHAR(100),  
  Languages VARCHAR(50),
  Proficiency INT
)
GO

-- Populate some test data into Employee table
INSERT INTO Employee VALUES('Gazala', 'Sayyad', 40, 'GS0101', 'English', 5)
INSERT INTO Employee VALUES('Abid', 'Sayyad', 37, 'AS0102', 'English', 4)
INSERT INTO Employee VALUES('ABC', 'OPQ', 18, 'AO0103', 'English',4)
INSERT INTO Employee VALUES('DEF', 'RST', 25, 'DR0104', 'Swedish',4)
INSERT INTO Employee VALUES('GHI', 'UVW', 55, 'GU0105', 'English',4)
INSERT INTO Employee VALUES('LMN', 'XYZ', 63, 'LX0106', 'Swedish',5)
GO

SELECT * FROM Employee
GO
