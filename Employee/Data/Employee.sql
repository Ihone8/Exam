use EmpDB
go
create table Department
(
	Id int primary key identity(1,1), --���ű��
	DeName nvarchar(20) not null,	--��������
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
insert into Department values('�з���')
insert into Department values('�ܲð�')
insert into Department values('�г���')

insert into Employee values('tom',35,'��',1)
insert into Employee values('mary',23,'Ů',2)
insert into Employee values('john',43,'��',3)
insert into Employee values('Json',15,'��',1)
insert into Employee values('harry',26,'Ů',2)

select E.*,D.DeName from Employee E inner join Department D on E.DID = D.Id