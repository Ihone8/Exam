use loginDB
go
create table Login
(
	UserName	nvarchar(16) primary key ,
	[PassWord]	nvarchar(16) not null,
	Sex	 	nvarchar(4) check(Sex='男' or Sex='女') not null,
	Birthday	datetime	
)
go
select * from Login
insert into Login values('管理员','admin','男',GETDATE())
insert into Login values('测试员','test','女',GETDATE())
select count(*) from Login where UserName = @name and [PassWord] =@pwd
select count(*) from login where  UserName = 'AD'


