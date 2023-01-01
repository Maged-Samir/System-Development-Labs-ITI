
--1.Create the following tables with all the required information and load the required data as specified
--in each table using insert statements[at least two rows]

create default def1 as 'NY'

create rule r1 as @x in('NY','DS','KW') 

sp_addtype Loc,'nchar(2)'

sp_bindrule r1,Loc

create table Department
(
  DeptNo varchar(5),
  DeptName varchar(20),
  Location Loc,
  constraint C1 primary Key(DeptNo)
)

insert into Department
values('d1','Research','NY'),
      ('d2','Accounting','DS'),
	  ('d3','Markting','KW')

 create table Employee
(
  EmpNo int,
  EmpFname varchar(20) Not Null,
  EmpLname varchar(20) Not Null,
  DeptNo varchar(5),
  Salary int,
  constraint C2 primary Key(EmpNo),
  constraint C3 unique (Salary),
  constraint C4 foreign key (DeptNo) references Department(DeptNo)
  on delete set null on update cascade 

)

create rule r2 as @x <6000 

sp_bindrule 'r2','Employee.Salary'

insert into Employee
values('25348','Matherw','Smith','d3',2500),
('10102','Ann','Jones','d3',3000),
('18316','Jone','BArrimore','d1',2400),
('29346','james','JAmes','d2',2800),
('9031','Lisa','Bertoni','d2',4000),
('2581','Elisa','hansel','d2',3600),
('28559','Sybl','Moser','d1',2900)





--insert into Works_On
--values (22222,'p1','Test','2022-2-6')
--Error Forgin key Constraint 



--update Works_On
--set EmpNo=11111
--where EmpNo=10102
--Error Forgin key Constraint 


--update Employee
--set EmpNo=22222
--where EmpNo=10102


--delete from Employee
--where EmpNo=10102


alter table Employee
add telephone varchar(20)

alter table employee
drop column telephone

--2.Create the following schema and transfer the following tables 
create schema Company
alter schema Company transfer Department

create schema HR
alter schema HR transfer Employee

--3.Write query to display the constraints for the Employee table.
SELECT CONSTRAINT_NAME, CONSTRAINT_TYPE
FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
WHERE TABLE_NAME='Employee';


--4.Create Synonym for table Employee as Emp and then run the following queries
create SYNONYM Emp
FOR HR.Employee 


select * from Emp
Select * from HR.Employee
--select * from Employee
--select * from HR.Emp

--5.Increase the budget of the project where the manager number is 10102 by 10%.
update P
set Budget = .1 * Budget + Budget
from Company.Project as P inner join dbo.Works_On as W_S
on P.ProjectNo = W_S.ProjectNo inner join HR.Employee as E
on E.EmpNo = W_S.EmpNo
where E.EmpNo = 10102;


--6.Change the name of the department for which the employee named James works.The new department name is Sales.
UPDATE Company.Department
SET DeptName = 'Sales'
WHERE DeptNo = (SELECT DeptNo
FROM HR.Employee
WHERE EmpFname='Mathew');


--7.Change the enter date for the projects for those employees who work in project p1 and belong to 
--department ‘Sales’. The new date is 12.12.2007
UPDATE Works_On
SET Enter_Date='12.12.2007'
WHERE EmpNo IN (SELECT e.EmpNo
FROM HR.Employee e
INNER JOIN Works_On w
ON w.EmpNo = e.EmpNo
INNER JOIN Company.Department d
ON d.DeptNo = e.DeptNo
WHERE d.DeptName = 'Sales'
AND w.ProjectNo = 'p1');


--8.Delete the information in the works_on table for all employees who work for the department located in KW.
DELETE FROM Works_On
WHERE EmpNo IN (
SELECT e.EmpNo FROM HR.Employee e
INNER JOIN Company.Department d
ON e.DeptNo = d.DeptNo
WHERE d.location = 'KW'
);


-- Dont Forget ITI DB
--9.Create Login Named(ITIStud) who can access Only student and Course tablesfrom ITI DB then allow him to 
--select and insert data into tables and deny Delete and update .(Use ITI DB)

Create Schema HR
alter schema HR transfer student
alter schema HR transfer Course


select * from HR.Student

update HR.Student
set St_Fname = 'maged'
where St_Id=1