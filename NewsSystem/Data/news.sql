use News
go
create table newsType(
	nId	int primary key identity(1,1),
	nType	varchar	(20)  not null,
)
go
create table newsInfo(
newsId		int	primary key identity(1,1),
title		varchar	(100) not null,
addTime		dateTime		not null,
content		varchar(max) ,	
[type_Id]	int	 references newsType(nId),
)
go
insert into newsType values('����')
insert into newsType values('����')
insert into newsType values('�Ƽ�')
select T.nType ,I.* from newsType T  inner join newsInfo I on T.nId = I.[type_Id]
delete newsInfo where newsId = id
insert into newsInfo values('��������飿','2011-11-25','��������������������',1)
insert into newsInfo values('��������ս','2011-10-15','��������ս22222',2)
insert into newsInfo values('��20','2011-9-10','��20�й�ţ��������',3)	