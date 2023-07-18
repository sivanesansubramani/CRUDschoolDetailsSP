Create table SchoolDetails
(
id int primary key identity(1,1),
SchoolName varchar(500) not null,
Ownername nvarchar(500) not null,
Address nvarchar(100)  not null,
Location nvarchar(100) not null,
NoOfStudents nvarchar(100) not null
)

insert into SchoolDetails(SchoolName,Ownername,Address,Location,NoOfStudents) values ('kvm','kuppusamy','palani','near murugan temple','400')

-- insert records into stubio 
alter procedure insertschooldetails(@Schoolname nvarchar(500),@ownername nvarchar(500),@address nvarchar(100),@location nvarchar(100),@NoOfstudents nvarchar(100))
as
begin

insert into SchoolDetails(SchoolName,Ownername,Address,Location,NoOfStudents) values (@Schoolname,@ownername,@address,@location,@NoOfstudents)

end

exec insertschooldetails 'kvmm','kuppusamym','palanim','nearm mmurugan temple','400'

-------select sp
create procedure selectschooldetails
as
begin

  Select * from SchoolDetails

end

exec selectschooldetails


