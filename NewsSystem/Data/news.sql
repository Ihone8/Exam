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
insert into newsType values('娱乐')
insert into newsType values('国际')
insert into newsType values('科技')
select T.nType ,I.* from newsType T  inner join newsInfo I on T.nId = I.[type_Id]
delete newsInfo where newsId = id
insert into newsInfo values('黄晓明结婚？','2011-11-25','黄晓明结婚哈哈哈哈哈或',1)
insert into newsInfo values('利比亚内战','2011-10-15','利比亚内战22222',2)
insert into newsInfo values('歼20','2011-9-10','歼20中国牛逼起来了',3)	