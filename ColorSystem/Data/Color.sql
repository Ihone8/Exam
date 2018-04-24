use ClothesDb
go
create table Colors(
	ColorId	int primary key identity(1,1),		
	ColorCode		varchar(10)	not null,
	Name		varchar(30)	not null,
	Matching		varchar(15)	not null
)
go
insert into Colors values('621','Ç³·Ûºì','255,182,193')
insert into Colors values('622','·Ûºì','255,192,203')
insert into Colors values('623','Éîºì(ÐÉºì)','220,20,60')
insert into Colors values('624','¼»É«','216,191,216')
insert into Colors values('625','À¶×ÏÂÞÀ¼','138,43,226')
 select  * from Colors
 update Colors set ColorCode = @code, Name = @name , Matching =@mactch  where ColorId = @id
 delete Colors where ColorId = @id