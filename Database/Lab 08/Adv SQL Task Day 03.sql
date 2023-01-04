--1.Create a view that displays student full name, course name if the student has a grade more than 50. 
create view vfullname 
as
select CONCAT(s.St_Fname,' ',s.St_Lname) 'FullName',
c.Crs_Name 'course name'
from student s join Stud_Course sc
on s.St_Id = sc.St_Id 
join Course c
on c.Crs_Id = sc.Crs_Id 
where sc.Grade > 50
 
select * from vfullname

--2.Create an Encrypted view that displays manager names and the topics they teach. 
alter view mgr_info(mgr_name ,topic)
 with encryption 
 as 
    select i.Ins_Name , t.Top_Name
	from Instructor i inner join Department d 
	on i.Dept_Id = d.Dept_Id
	inner join Ins_Course ic
	on ic.Ins_Id = i.Ins_Id 
	inner join Course c 
	on ic.Crs_Id = c.Crs_Id 
	inner join Topic t 
	on t.Top_Id = c.Top_Id 

select * from mgr_info

--3.Create a view that will display Instructor Name, Department Name for the ‘SD’ or ‘Java’ Department 
create view v_Instructor_department_name (instractor,department)
 as 
select  i.Ins_Name,d.Dept_Name
from Instructor i join Department d
on i.Dept_Id = d.Dept_Id
where Dept_Name in ('SD' , 'Java')

select * from v_Instructor_department_name

--4.Create a view “V1” that displays student data for student who lives in Alex or Cairo.
create view V1 
as
select  *
from Student
where St_Address in ('Alex' , 'Cairo')
with check option 

select * from V1

--Update V1 set st_address='tanta'

--Where st_address='alex'

--5.Create a view that will display the project name and the number of employees work on it. “Use SD database”
use SD
create view V2 (ProjectName,numberofemployee)
as
select  ProjectName,COUNT(w.EmpNo)
from HR.Employee e join dbo.Works_On w
on w.EmpNo = e.EmpNo
join Company.Project p
on w.ProjectNo = p.ProjectNo
group by ProjectName

select * from V2


--6.Create index on column (Hiredate) that allow u to cluster the data in table Department. What will happen?
use ITI
create clustered index i2 on department(manager_hiredate)

--7.Create index that allow u to enter unique ages in student table. What will happen? 
create unique index i3 
on student (st_age)

--8.Using Merge statement between the following two tables [User ID, Transaction Amount]
create table daily_transaction
(
id int ,
salary int 
)

create table last_transaction
(
id int ,
salary int 
)

merge into last_transaction as targ
using daily_transaction as sour
on targ.id=sour.id
when matched then
update
set targ.salary=sour.salary
when not matched then
insert 
values(sour.id,sour.salary);


--Part two 
--1) Create view named   “v_clerk” that will display employee#,project#,
--   the date of hiring of all the jobs of the type 'Clerk'.

use SD

create view V_clerk
as
select e.EmpFname ,p.ProjectName,w.Enter_Date
from HR.Employee e 
join Works_On w
on e.EmpNo=w.EmpNo
join Company.Project p
on w.ProjectNo=p.ProjectNo
where w.Job='Manager'

select * from V_clerk

--2.Create view named  “v_without_budget” that will display all the projects data without budget
create view v_without_budget
as
select p.ProjectName from Company.Project p
where p.Budget=0

select * from v_without_budget

--3)Create view named  “v_count “ that will display the project name and the # of jobs in it
create view v_count (project_number,project_name,NumberofJobs)
as
select p.ProjectNo,p.ProjectName,count(w.Job) from Company.Project p 
join Works_On w
on p.ProjectNo =w.ProjectNo
group by p.ProjectName,p.ProjectNo

select * from v_count

--4) Create view named ” v_project_p2” that will display the emp#  for the project# ‘p2’
--   use the previously created view  “v_clerk”
create view v_project_p2(EmployeeName)
as
select CONCAT(e.EmpFname,' ',e.EmpLname) from v_count
join Works_On w
on w.ProjectNo = project_number
join hr.Employee e
on e.EmpNo=w.EmpNo
where project_number='p2'

select * from v_project_p2


--5)modifey the view named  “v_without_budget”  to display all DATA in project p1 and p2 

alter view v_without_budget
as
select * from Company.Project p
where p.ProjectNo in('p1','p2')

select * from v_without_budget


--6)Delete the views  “v_ clerk” and “v_count”
drop view V_clerk
drop view v_count 

--7)Create view that will display the emp# and emp lastname who works on dept# is ‘d2’
create view display_emp_dept_d2
as
select e.EmpNo ,e.EmpLname from hr.Employee e
where e.DeptNo='d2'


select * from display_emp_dept_d2

--8)Display the employee  lastname that contains letter “J”
--Use the previous view created in Q#7

select * from display_emp_dept_d2
where EmpLname like '%j%'

--9)Create view named “v_dept” that will display the department# and department name.
create view v_dept (DepartmentNumber,DepartmentName)
as
select d.DeptNo,d.DeptName from Company.Department d

select * from v_dept

--10)using the previous view try enter new department data where dept# is ’d4’ and dept name is ‘Development’

insert into v_dept
values('d4','Development')

--11)	Create view name “v_2006_check” that will display employee#, the project #where he works 
--and the date of joining the project which must be from the first of January and the last of December 2006.

create view v_2006_check
as
select e.EmpNo,p.ProjectName,w.Enter_Date from HR.Employee e 
join Works_On w
on e.EmpNo=w.EmpNo
join Company.Project p 
on w.ProjectNo=p.ProjectNo
where w.Enter_Date between '2006-1-1' and '2006-12-30'

select * from v_2006_check

