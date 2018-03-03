

create EmployeeDB;

create table Department
(
	ID int not null identity primary key,
	Name nvarchar(100) not null,
	Location nvarchar(500) not null
);


create Table Employee
(
	ID int not null identity primary key,
	FirstName nvarchar(100) not null,
	LastName nvarchar(100) not null,
	SSN nvarchar(11) not null,
	DeptID int,
	foreign key (DeptId) references Department(ID)
);


create Table EmpDetails
(
	ID int not null identity primary key,
	EmployeeID int not null,
	Salary money,
	Address1 nvarchar(200) not null,
	Address2 nvarchar(200),
	City nvarchar(100) not null,
	State nvarchar(100),
	Country nvarchar(100) not null,
	foreign key (EmployeeID) references Employee(ID)
)
-- 1 Add three recodes into each table
INSERT INTO Department (ID, Name,  Location)
VALUES (1, 'HR', 'reston')
VALUES (2, 'Trainer', 'reston')
VALUES (3, 'Mangement', 'reston');


INSERT INTO Employee (ID, FirstName,  LastName, SSN, DeptID)
VALUES (1, 'sofani', 'mesfun', 101-20-1201, 1)
VALUES (2, 'phil', 'jack', 123-12-3123, 3)
VALUES (3, 'daniel', 'mesfun', 123-12-3124, 5);

INSERT INTO EmployeeDetailes (ID, EmployeeId, Salary,  Address1, Address2, City, State, Country)
VALUES (1,  2, 2000, '255 11st ' , '#1', 'oakland', 'ca' , 'u.s.a' )
VALUES (2,  4, 4000, '255 11st ' , '#1', 'oakland', 'ca' , 'u.s.a' )
VALUES(3,  5,  3000, '255 11st ' , '#1', 'oakland', 'ca' , 'u.s.a' );
--2 Add Employee Tina Smith
INSERT INTO Employee (ID, FirstName,  LastName, SSN, DeptID)
VALUES (4, 'Tina', 'Smith', 608-89-9909, 1);

--3Add Department Marketing

INSERT INTO Department (ID, Name,  Location)
VALUES (5, 'Marketing', 'reston');

--4 list All Employees in Marketing
SELECT * FROM Employee WHERE Employee.DeptID = 5;

--5 Report total salary of Marketing
SELECT DeptID, SUM(salary) 
FROM  Employee 
inner join EmployeeDetailes
WHERE Employee.DeptID = 5;

--6 report total employees by department
SELECT DeptID "Department Code", 
COUNT(*) "No of Employees" 
FROM Employee;

--7 increase salary of Tina Smith to 90000

UPDATE EmployeeDetailes 
SET salary = 90000 
WHERE EmployeeDetailes.EmployeeID = 4;

