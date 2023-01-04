--1.Create a stored procedure without parameters to show the number of students per department name.
--[use ITI DB]

use ITI
create proc p1
as
select count([St_Id]) [number of student],d.[Dept_Name]
from [dbo].[Student] s inner join  [dbo].[Department] d
on s.Dept_Id=d.Dept_Id
group by d.Dept_Id,d.Dept_Name

p1
execute p1
exec p1

--2.Create a stored procedure that will check for the # of employees in the project p1 
--if they are more than 3 print message to the user “'The number of employees in the project p1 is 3 or more'”
--if they are less display a message to the user “'The following employees work for the project p1'”
--in addition to the first name and last name of each one. [Company DB] 
use Company_SD

create proc p2 
as
if(select count(essn)from dbo.Works_for 
where Pno=100 ) >3
select 'The number of employees in the project p1 is 3 or more'
else select('The following employees work for the project p1')+
(select [FName]+' '+[LName]
from Employee as E
inner join Works_for as W 
on W.ESSn=E.SSN
where W.Pno=100 )

p2

--3.Create a stored procedure that will be used in case there is an old employee has left the project
--and a new one become instead of him. The procedure should take 3 parameters 
--(old Emp. number, new Emp. number and the project number) and it will be used to update works_on table. 
--[Company DB]

use Company_SD
create proc p3 @old int, @new int, @pnum int
as
update dbo.Works_for
set ESSn=@new
where Pno=@pnum and ESSn=@old

execute p3 33,12,2

--4.add column budget in project table and insert any draft values in it then 
--then Create an Audit table 
--Note: This process will take place only if the user updated the budget column

alter table project
add budget int

create table audit
(
pNo int,
UserName varchar(50),
ModifiedDate date,
budget_Old int,
budget_New int,
)

create trigger t1
on Project
for update
as
if update(budget)
begin
insert into audit 
values
((select budget from inserted),SUSER_NAME(),GETDATE(),
(select budget from deleted),
(select budget from inserted))
end

update Project
set budget =10
where Pname='Al Rehab'

--5.Create a trigger to prevent anyone from inserting a new record in the Department table [ITI DB]
--“Print a message for user to tell him that he can’t insert a new record in that table”

use ITI

create trigger t2
on dbo.department
instead of insert
as
select 'not allow'


insert into Department(Dept_Id,Dept_Name)
values('222','Test')


--6.Create a trigger that prevents the insertion Process for Employee table in March [Company DB].
use Company_SD

alter trigger t4
on employee
instead of insert
as
   if format(GETDATE(),'MMMM')='march'
   rollback
   select 'insertion process stoped in march '
	

insert into employee(SSN,Fname,Lname,Bdate) 
values(199,'ahmmed','ahmed','1973-03-18 00:00:00.000')

--7.Create a trigger on student table after insert to add Row in Student Audit table 
--(Server User Name , Date, Note) where note will be “[username] Insert New Row with Key=[Key Value] 
--in table [table name]”

use iti

Create Table history
(
username varchar(20),
insertdate date,
insertid int, 
insertname varchar(20)
)

alter trigger t20
on dbo.student
after insert
as
declare @id int,@name varchar(20)
select @id=[St_Id] from inserted
select @name=[St_Fname] from inserted
insert into history(username,insertdate,insertid,insertname)
values(suser_name(),getdate(),@id,@name)
	


--8.Create a trigger on student table instead of delete to add Row in Student Audit table
--(Server User Name, Date, Note) where note will be“ try to delete Row with Key=[Key Value]”
use ITI
alter trigger t6
on dbo.student
instead of delete
as
declare @id int,@name varchar(20)
select @id=[St_Id] from deleted
select @name=[St_Fname] from deleted
insert into history
values(suser_name(),getdate(),@id,@name)



--9.	Display all the data from the Employee table (HumanResources Schema) 
--As an XML document “Use XML Raw”. “Use Adventure works DB” 
--A)	Elements
--B)	Attributes

use AdventureWorks2012

select * from HumanResources.Employee
for xml raw;

select * from HumanResources.Employee
for xml raw,elements;

--10.	Display Each Department Name with its instructors. “Use ITI DB”
--A)	Use XML Auto
--B)	Use XML Path

use ITI

select d.Dept_Name,i.Ins_Name from Department d
join Instructor i
on d.Dept_Id=i.Dept_Id
for xml path


--11.	Use the following variable to create a new table “customers” inside the company DB.
-- Use OpenXML
use SD
 declare @docs xml ='<customers>
              <customer FirstName="Bob" Zipcode="91126">
                     <order ID="12221">Laptop</order>
              </customer>
              <customer FirstName="Judy" Zipcode="23235">
                     <order ID="12221">Workstation</order>
              </customer>
              <customer FirstName="Howard" Zipcode="20009">
                     <order ID="3331122">Laptop</order>
              </customer>
              <customer FirstName="Mary" Zipcode="12345">
                     <order ID="555555">Server</order>
              </customer>
       </customers>'

	   declare @hdocs int 

	   exec sp_xml_preparedocument @hdocs output ,@docs

	   select * into Customers
	   from openxml (@hdocs,'//customer')
	   with
	   (
	         FirstName varchar(20) '@FirstName',
			 ZipCode int '@ZipCode',
			 OrderID int 'order/@ID',
			 OrderName varchar(20) 'order'
	   )

	   exec sp_xml_removedocument @hdocs