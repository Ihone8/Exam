use EmpDB
go
create table Department
(
	Id int primary key identity(1,1), --部门编号
	DeName nvarchar(20) not null,	--部门名称
)
go
create table Employee
(
	ID	int primary key identity(1,1),
	Name nvarchar(20) not null,
	Age	int not null,
	Sex	nvarchar(10) not null,
	DID	int	 references Department(Id)
)
go
insert into Department values('研发部')
insert into Department values('总裁办')
insert into Department values('市场部')

insert into Employee values('tom',35,'男',1)
insert into Employee values('mary',23,'女',2)
insert into Employee values('john',43,'男',3)
insert into Employee values('Json',15,'男',1)
insert into Employee values('harry',26,'女',2)

select E.*,D.DeName from Employee E inner join Department D on E.DID = D.Id