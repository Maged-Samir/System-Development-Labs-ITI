--1.	Display all the employees Data.
select * from Employee

--2.	Display the employee First name, last name, Salary and Department number.
select fname,lname ,Salary,Dno from Employee

--3.	Display all the projects names, locations and the department which is responsible about it.
select pname,plocation,dnum from Project

--4    .Display each employee full name and his annual commission in an ANNUAL COMM column (alias).
select fname+''+lname as 'Full Name' ,(Salary*12)+0.1  from Employee

--5.	Display the employees Id, name who earns more than 1000 LE monthly.
select ssn ,Fname from Employee
where salary > 1000
--6.	Display the employees Id, name who earns more than 10000 LE annually.
select ssn ,Fname from Employee
where salary*12 > 15000

--7.	Display the names and salaries of the female employees 
select fname,salary from Employee
where Sex='F'

--8.	Display each department id, name which managed by a manager with id equals 968574.
select dnum,dname from Departments
where MGRSSN=968574
--9.	Dispaly the ids, names and locations of  the pojects which controled with department 10.

select pname,Pnumber,Plocation from project
where Dnum=10


