Create table SchoolDetailsCRUD
(
id int primary key identity(1,1),
SchoolName varchar(500) not null,
Ownername nvarchar(500) not null,
Address nvarchar(100)  not null,
Location nvarchar(100) not null,
NoOfStudents nvarchar(100) not null
)
select * from SchoolDetailsCRUD

insert into SchoolDetailsCRUD(SchoolName,Ownername,Address,Location,NoOfStudents) values ('kvm','kuppusamy','palani','near murugan temple','400')

-- insert records into stubio 
create procedure insertschooldetails(@Schoolname nvarchar(500),@ownername nvarchar(500),@address nvarchar(100),@location nvarchar(100),@NoOfstudents nvarchar(100))
as
begin

insert into SchoolDetailsCRUD(SchoolName,Ownername,Address,Location,NoOfStudents) values (@Schoolname,@ownername,@address,@location,@NoOfstudents)

end

exec insertschooldetails 'kvm','kuppusamym','palanim','nearm mmurugan temple','400'

-------select sp
alter procedure selectschooldetails
as
begin

  Select * from SchoolDetailsCRUD

end

exec selectschooldetails


-------select sp eith id
alter procedure selectschooldetailsWithId(int @id)
as
begin

  Select * from SchoolDetailsCRUD where id = @id

end

exec selectschooldetailsWithId 'kvm'



--ubdate
--exctra parameters @ownername nvarchar(400),@address nvarchar(400),@location nvarchar(400),

alter procedure ubdateschooldetails (@schoolname nvarchar(400),@noofstudents nvarchar(400))
as
begin

  update SchoolDetailsCRUD set NoOfStudents =@noofstudents  where SchoolName=@schoolname

end

exec ubdateschooldetails 'kvm','1500'

--delete
create procedure deleteschooldetails(@schoolname nvarchar(400))
as
begin

  delete from SchoolDetailsCRUD where SchoolName =@schoolname

end

exec deleteschooldetails 'kvm'



