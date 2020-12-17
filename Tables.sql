

alter database scoped configuration set IDENTITY_CACHE=off

use [TestDB]

create table TGROUP(
	ID numeric primary key identity (1001, 1),
	Name varchar(25) null
);

create table TRELATION(
	ID numeric primary key identity (10000, 1),
	ID_Parent numeric references TGROUP(ID),
	ID_Child numeric references TGROUP(ID)
);

create table TPROPERTY(
	ID numeric primary key identity(1001, 1),
	Name varchar(25) null,
	Value varchar(25) null,
	ID_Group numeric references TGROUP(ID)
	constraint ffk_IDgroup_ArentUniq unique (ID_Group)
);

INSERT TGROUP(Name)
VALUES('x1');
INSERT TGROUP(Name)
VALUES('x2');
INSERT TGROUP(Name)
VALUES('x3');
INSERT TGROUP(Name)
VALUES('x4');


INSERT TRELATION(ID_Parent, ID_Child)
VALUES(1001, 1002);
INSERT TRELATION(ID_Parent, ID_Child)
VALUES(1001, 1003);
INSERT TRELATION(ID_Parent, ID_Child)
VALUES(1002, 1004);

INSERT TPROPERTY(Name, Value, ID_Group)
VALUES('x1', 'value1', 1001);
INSERT TPROPERTY(Name, Value, ID_Group)
VALUES('x2', 'value2', 1002);
INSERT TPROPERTY(Name, Value, ID_Group)
VALUES('x3', 'value3', 1003);
INSERT TPROPERTY(Name, Value, ID_Group)
VALUES('x4', 'value4', 1004);


select * from TGROUP

select * from TRELATION

select * from TPROPERTY