--1.Retrieve number of students who have a value in their age. 
select COUNT(st_age) from Student 
where St_Age is not null

--2.Get all instructors Names without repetition
select distinct Instructor.Ins_Name from Instructor

--3.Display student with the following Format (use isNull function)
select St_Id 'Student ID' ,St_Fname+' '+St_Lname 'Full Name',d.Dept_Name 'Department'  from Student s
join Department d
on s.Dept_Id=d.Dept_Id

--3.using not null
select 
 s.St_Id,
 isnull (concat (s.St_Fname,' ',s.St_Lname),' ') 'FullName' ,
 isnull (d.Dept_Name,'') 'DepartName'
from Student s join Department d
on s.Dept_Id=d.Dept_Id


--4.Display instructor Name and Department Name 
select i.Ins_Name,d.Dept_Name
from Instructor i left join Department d
on d.Dept_Id=i.Dept_Id


--5.Display student full name and the name of the course he is taking
--For only courses which have a grade  

select isnull(concat(s.St_Fname,' ',s.St_Lname),' ') 'fullname',
c.Crs_Name
from Student s join Stud_Course sc
on s.St_Id=sc.St_Id
join Course c
on c.Crs_Id=sc.Crs_Id
where sc.Grade is not null


--6.Display number of courses for each topic name
select t.top_name ,count(c.crs_id) from Topic t
join Course c
on t.Top_Id=c.Top_Id
group by t.Top_Name


--7.Display max and min salary for instructors
select 
MAX(salary) 'Max Salary',
min(salary) 'Min Salary'
from Instructor


--8.Display instructors who have salaries less than the average salary of all instructors.

select Ins_Id,Ins_Name
from Instructor 
where Salary<(select avg (Salary) from Instructor)


--9.Display the Department name that contains the instructor who receives the minimum salary.
select Dept_Name
from Department 
where Dept_Id=(select top (1) Dept_Id from Instructor order by Salary)

--10.Select max two salaries in instructor table. 
select top(2)salary from Instructor
order by Salary desc


--11.Select instructor name and his salary but if there is no salary display instructor bonus keyword.

select Ins_Name,Salary from Instructor
order by Salary desc 


--12.Select Average Salary for instructors   
select avg( Salary)
from Instructor

--13.Select Student first name and the data of his supervisor 
select concat (x.St_Fname,'',x.St_Lname) ,y.*
from Student x join Student y
on y.St_Id=x.St_super


--14.Write a query to select the highest two salaries in Each Department for instructors who have salaries.
--“using one of Ranking Functions”

SELECT Salary ,Dept_Id
from (select * ,row_number() over (partition by dept_id
order by salary desc) as DR
from Instructor ) as NewTable 
where DR in(1,2)


--15.Write a query to select a random  student from each department.  “using one of Ranking Functions”
select St_Fname
from 
(select * ,DENSE_RANK() over (partition by Dept_Id order by NEWID()) as DR
FROM Student ) as NewTable 

where DR=1
