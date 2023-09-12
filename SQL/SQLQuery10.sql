

CREATE TABLE dbo.BussinessEntity_details(
	Id int NOT NULL,
	BussinesEntityId int NOT NULL,
	AccountNumber nvarchar(15) NOT NULL,
	Adress nvarchar(250) NOT NULL,
	Contact nvarchar(100) NOT NULL,
	Email nvarchar(250) NOT NULL,
	Comment nvarchar(max) NULL
) 

insert into dbo.BussinessEntity_details(Id,BussinesEntityId,AccountNumber,Adress,Contact,Email,Comment)
values (1,'210500222333','Partizanski Odredi 15','070555666','aaa@vitalia.com','Nema zabeleshka')


insert into dbo.BussinessEntity_details(Id,BussinesEntityId,AccountNumber,Adress,Contact,Email,Comment)
values (2,'210500222334','XXXX 15','070779523','bbb@vitalia.com',NULL)


insert into dbo.BussinessEntity_details(Id,BussinesEntityId,AccountNumber,Adress,Contact,Email,Comment)
values (3,'210500222335','XXXX 16','070779523','ccc@vitalia.com','TEST 1')


insert into dbo.BussinessEntity_details(Id,BussinesEntityId,AccountNumber,Adress,Contact,Email,Comment)
values (4,'210500222335','XXXX 17','070779523','dddvitalia.com',NULL)


insert into dbo.BussinessEntity_details(Id,BussinesEntityId,AccountNumber,Adress,Contact,Email,Comment)
values (5,'210500222336','XXXX 18','070779544','vvv@vitaliacom','Nema plateno faktura')


insert into dbo.BussinessEntity_details(Id,BussinesEntityId,AccountNumber,Adress,Contact,Email,Comment)
values (6,'210500222337','XXXX 19','070779555','ddd@vitaliacom',NULL)

insert into dbo.BussinessEntity_details(Id,BussinesEntityId,AccountNumber,Adress,Contact,Email,Comment)
values (7,'210500222338','XXXX 20','070779566','aa@vitalia.com','Nevaliden kontakt')

update select *
from dbo.BussinessEntity_details

