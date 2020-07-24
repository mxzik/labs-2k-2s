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
('pd', 400.0, 'Война и мир'),
('pdf', 100.0, 'Над пропостью во ржи '),
('pdf', 200.0, 'Преступление и наказание '),
('pdf', 225.0, 'Идиот'),
('pdf', 275.0, '1984');

insert into ElBook2 values
(1000, 'Аверсев..', 1915),
(500, 'Аверсев..', 1989),
(400, 'Аверсев..', 1915),
(600, 'Аверсев..', 1934),
(500, 'Аверсев..', 1967);

insert into ElBook3(listofauth, dateofupl) values
('Толстой', '1918-04-23'),
('Джером Сэлинджер', '1989-02-23'),
('Достоевский', '1258-04-23'),
('Достоевский', '1813-02-23'),
('Оруэл', '1958-04-23');