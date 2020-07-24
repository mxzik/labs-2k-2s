use [11lab]

create table ElBook1 
(
id int identity(1,1) primary key,
form nvarchar(6),
mbspace int,
name nvarchar(30) 
)
ALTER TABLE ElBook1 
alter column mbspace int

--create table ElBook2 
--(
--id int identity(1,1) primary key,
--numofpages int,
--pubhouse nvarchar(25),
--yearofupload int
--)

--create table ElBook3 
--(
--id int identity(1,1) primary key,
--listofauth nvarchar(50),
--dateofupl date,
--FOTO varbinary(MAX) default null 
--)

go
insert into ElBook1 values
('pd', 400.0, '����� � ���'),
('pdf', 100.0, '��� ��������� �� ��� '),
('pdf', 200.0, '������������ � ��������� '),
('pdf', 225.0, '�����'),
('pdf', 275.0, '1984');

insert into ElBook2 values
(1000, '�������..', 1915),
(500, '�������..', 1989),
(400, '�������..', 1915),
(600, '�������..', 1934),
(500, '�������..', 1967);

insert into ElBook3(listofauth, dateofupl) values
('�������', '1918-04-23'),
('������ ���������', '1989-02-23'),
('�����������', '1258-04-23'),
('�����������', '1813-02-23'),
('�����', '1958-04-23');