use DinnerDB
go
create table Employee(
	EmpId		    int	primary key identity(1,1),
	Emp_No		    varchar(10) not null unique,
	[Password]		varchar(30)	not null,
	Emp_Name		varchar(15) not null
)
go
create table Book_Dinner(
	Bd_id		 int primary key identity(1,1),
	work_no	     varchar(10) foreign key(work_no) references Employee(Emp_No) not null,
	book_time	 datetime		not null,
	Emp_Name	 varchar(15) not null,	
)
go

insert into Employee values('001','123456','张三')
insert into Employee values('002','123456','李四')
insert into Employee values('003','123456','王五')
select * from Employee e inner join Book_Dinner D on e.Emp_No = d.work_no
select count(*) from Employee where Emp_No = '' and Password =''
insert into Book_Dinner values(@No,@Time,@Name)
select * from Book_Dinner