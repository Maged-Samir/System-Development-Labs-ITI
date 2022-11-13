--1.	Display the Department id, name and id and the name of its manager.
select Dname,Dnum,e.SSN,e.Fname+' '+e.Lname as 'fullname'
from Departments d,Employee e
where d.MGRSSN=e.SSN

--2.	Display the name of the departments and the name of the projects under its control.
select d.Dname,p.Pname
from Departments d,Project p
where d.Dnum=p.Dnum

--3.	Display the full data about all the dependence associated with the name of the employee they depend on him/her.
select e.Fname+' '+e.Lname 'employe name' ,d.*
from Employee e,Dependent d
where e.SSN=d.ESSN

--4.	Display the Id, name and location of the projects in Cairo or Alex city.
select Pnumber,Pname,Plocation
from Project 
where City in('cairo','alex')

--5.	Display the Projects full data of the projects with a name starts with "a" letter.
select * 
from Project
where Pname like 'a%'

--6.	display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select e.Fname+' '+e.Lname 'emplyee name'
from Employee e
where e.Dno=30 and e.Salary between 1000 and 2000

--7.	Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.
select e.Fname
from Employee e inner join Works_for w
on e.SSN=w.ESSn

inner join Project p
on w.Pno=p.Pnumber

where e.Dno=10 
and w.Hours >=10
and p.Pname='AL Rabwah'


--8.	Find the names of the employees who directly supervised with Kamel Mohamed.
select x.Fname
from Employee x,Employee y
where y.SSN=x.Superssn
and y.Fname+' '+y.Lname='kamel mohamed'

--9.	Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
select e.Fname ,p.Pname
from Employee e left outer join Works_for w
on e.SSN=w.ESSn

inner join Project p
on p.Pnumber=w.Pno
order by p.Pname

--10.	For each project located in Cairo City , find the project number, the controlling department name ,the department manager last name ,address and birthdate.   
select p.Pnumber ,d.Dname,e.Lname,e.Address,e.Bdate
from Project p join Departments d
on p.Dnum=d.Dnum

join Employee e
on e.SSN=d.MGRSSN

where p.City='cairo'


--11.	Display All Data of the managers
select d.MGRSSN ,e.Fname+' '+e.Lname 'manager name',e.Address,e.Bdate,e.Salary
from Departments d,Employee e
where d.MGRSSN=e.SSN

--12.	Display All Employees data and the data of their dependents even if they have no dependents
select e.* ,d.*
from Employee e left outer join Dependent d
on e.SSN=d.ESSN

--13 /14 Insert statments
insert into Employee
values
('maged','samir',102672,1960-2-2,'roda st','M',3000,112233,30),
('mohamed','samy',102660,1960-2-2,'Alex st','M',NULL,NULL,30)


--15.	Upgrade your salary by 20 % of its last value.
--select e.Salary
update Employee 
set Salary=Salary+(Salary*20/100)
where SSN=102672