use loginDB
go
create table Login
(
	UserName	nvarchar(16) primary key ,
	[PassWord]	nvarchar(16) not null,
	Sex	 	nvarchar(4) check(Sex='��' or Sex='Ů') not null,
	Birthday	datetime	
)
go
select * from Login
insert into Login values('����Ա','admin','��',GETDATE())
insert into Login values('����Ա','test','Ů',GETDATE())
select count(*) from Login where UserName = @name and [PassWord] =@pwd
select count(*) from login where  UserName = 'AD'


