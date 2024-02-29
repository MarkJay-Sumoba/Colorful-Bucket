create database PaintManagementDb
go

use PaintManagementDb
go

create table Users
(
	Id UNIQUEIDENTIFIER primary Key default NEWID(),
	Username nvarchar (50) not null,
	Password nvarchar(100) not null,
	FirstName nvarchar(50) not null,
	LastName nvarchar(50) not null,
	Email nvarchar(100) unique not null,
	Roles nvarchar(50) not null
	)
	go

	insert into Users values (NEWID(), 'admin', 'admin','Mark','Sumoba', 'admin@gmail.com', 'manager')
	insert into Users values (NEWID(), 'manager', 'manager','Sang Kyu','Kim', 'manager@gmail.com', 'manager')
	go

	select *from Users

