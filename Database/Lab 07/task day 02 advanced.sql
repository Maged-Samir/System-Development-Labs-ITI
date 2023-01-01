use ITI
--1.Create a scalar function that takes date and returns Month name of that date.
create function dbo.getmonthname(@date date)
returns varchar(50)
begin
DECLARE @month varchar(50)
SELECT @month =FORMAT(@date, 'MMMM') 
return @month
end

select dbo.getmonthname('5/4/2020')


--2.Create a multi-statements table-valued function that takes 2 integers and returns the values between them.
create function get_values_between_two_integers(@num1 int,@num2 int)
returns @t table
			(
			  numbers int
			)
as
begin
		if @num1<@num2
		begin 
		 while @num1<@num2
		begin
		     set @num1+=1
	        	if @num1=@num2 break
		         insert into @t 
		          select @num1
		    end
		end
		return
	end

select * from get_values_between_two_integers(4,8)


--3.Create inline function that takes Student No and returns Department Name with Student full name.
create function get_student_name_department(@st_id int)
returns table
	as
	return
	(
	 select s.St_Fname+' '+s.St_Lname  as studentname ,d.Dept_Name
	 from Student s join Department  d
	 on d.Dept_Id=s.Dept_Id 
	 where s.St_Id=@st_id
	)

select * from get_student_name_department(3)


--4.Create a scalar function that takes Student ID and returns a message to user 
alter function Return_massage_to_user(@id int)
returns Varchar(50)
	begin
		declare @txt varchar(50)
		select @txt=case
		when St_Fname is null and St_Lname is null then 'full name is null'
		  when St_Fname is null then 'first name is null'
			when St_Lname is null then 'second name is null'
				else
				St_Fname+' '+St_Lname
				end
		from Student
		where St_Id=@id
		return @txt	
	end

select dbo.Return_massage_to_user(13)


--5.Create inline function that takes integer which represents manager ID and displays department name, Manager Name and hiring date 
create function get_department_and_manager_data(@id_manager int)
returns table
	as
	return
	(
	 select d.Dept_Name ,i.Ins_Name,d.Manager_hiredate
	 from Department d join Instructor i
	 on d.Dept_Id=i.Dept_Id
	 where i.Ins_Id=@id_manager
	)

select * from get_department_and_manager_data(10)


--6.Create multi-statements table-valued function that takes a string
create function return_student_state_name(@format varchar(20))
returns @t table
			(
			 id int,
			 sname varchar(20)
			)
as
	begin
		if @format='first name'
			insert into @t
			select st_id,isnull(st_fname,'') from Student
		else if @format='last name'
			insert into @t
			select st_id,isnull(st_Lname,'') from Student
		else if @format='full name'
			insert into @t 
			select st_id,isnull(st_fname+' '+st_lname,'') from Student
		return 
	end

select * from return_student_state_name('first name')


--7.Write a query that returns the Student No and Student first name without the last char
select substring (s.St_Fname,1,(len(s.St_Fname)-1))
from Student s

--8.Wirte query to delete all grades for the students Located in SD Department 
delete from Stud_Course
where St_Id in(select sc.grade from Stud_Course sc ,Department d ,Student s
where s.St_Id=sc.St_Id and d.Dept_Id=s.Dept_Id and d.Dept_Name='sd')





--9
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



