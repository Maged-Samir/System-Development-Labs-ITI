--1.Display (Using Union Function)
select d.Dependent_name ,d.Sex
from Dependent d join Employee e
on d.ESSN=e.SSN 
where d.Sex='f' and e.Sex='f'
union
select d.Dependent_name,d.Sex
from Dependent d join Employee e
on d.ESSN=e.SSN
where e.Sex='m' and d.sex='m'

--2.For each project, list the project name and the total hours per week (for all employees) spent on that project.
select p.Pname,sum(w.Hours)
from project p join Works_for w
on p.Pnumber=w.Pno
group by p.Pname

--3.Display the data of the department which has the smallest employee ID over all employees' ID.
select min(e.SSN) as SmallestEmployeeID,d.Dname as DepartmentName
from Departments d join Employee e
on d.Dnum=e.Dno
where e.SSN=(select min(SSN) from Employee )
group by e.SSN,d.Dname
--Get all data Of Department 


--4.For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
select d.Dname,max(e.Salary),min(e.Salary),avg(e.Salary)
from Departments d join Employee e
on e.Dno=d.Dnum
group by d.Dname

--5.List the full name of all managers who have no dependents.
select e.Fname +' '+e.Lname  'full name'
from Departments d join Employee e
on d.MGRSSN=e.SSN
where MGRSSN not in
(select essn from Employee e
inner join  Dependent 
on e.SSN=Dependent.ESSN)


--6.For each department
-- if its average salary is less than the average salary of all employees
-- display its number, name and number of its employees.
select d.Dname,d.Dnum,count(e.ssn) 'number of employee in department'
from Departments d join Employee e
on e.Dno=d.Dnum
group by Dname,Dnum
having avg(e.Salary)<=(select avg(Salary) from Employee)

--7.Retrieve a list of employees names and the projects names they are working on ordered by department number 
--and within each department, ordered alphabetically by last name, first name.
select Fname,Pname
from Employee e join Works_for w
on e.SSN=w.ESSn
join project p
on w.Pno=p.Pnumber
order by Dno ,Fname ,Pname



--8.Try to get the max 2 salaries using subquery
select (select max(salary) from Employee),
(select max(salary) from Employee where Salary not in (select max (Salary)from Employee))
--Another way 


--9.Get the full name of employees that is similar to any dependent name
select e.Fname+' '+e.Lname
from Employee e
where e.Fname+' '+e.Lname in (select Dependent_name from Dependent )


--10.Display the employee number and name if at least one of them have dependents (use exists keyword)
select e.Fname,e.SSN
from employee e, Dependent d
where EXISTS 
(select SSN from Employee where e.SSN =d.ESSN);
--Update 


--11.insert new department called "DEPT IT" , with id 100, employee with SSN = 112233 as a manager for this department. The start date for this manager is '1-11-2006'
insert into Departments(Dname,Dnum,MGRSSN,[MGRStart Date])
values ('IT',100,112233,'1-11-2006')


--12.Updates Data
update Departments 
set MGRSSN=968574
where Dnum=100

update Departments 
set MGRSSN=102672
where Dnum=20

update Employee 
set Superssn=102672
where SSN=102660


--13

update Employee set Superssn =102672
where Superssn=223344
update Departments set MGRSSN =102672
where MGRSSN=223344

delete from Employee where Superssn=223344
delete from Departments where MGRSSN=223344
delete from Dependent where ESSN=223344
delete from Works_for where ESSN=223344

update Employee set Superssn =102672
where Superssn=223344
update Departments set MGRSSN =102672
where MGRSSN=223344

update Works_for set ESSn =102672
where ESSn=223344


--14.update all salaries of employees who work in Project ‘Al Rabwah’ by 30%
update Employee
set Salary =Salary*0.3
where SSN in(select SSN from Employee inner join Works_for 
on Employee.SSN=Works_for.ESSn
inner join Project
on Project.Pnumber=Works_for.Pno 
and Project.Pname='Al Rabwa')
--With out any Sub Quaries 


