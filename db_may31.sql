CREATE DATABASE Crud_with_ASP_NET_CORE_DBF

use Crud_with_ASP_NET_CORE_DBF

create table CSstudents(
Id int primary key identity ,
Name varchar(50),
Age int ,
Gender varchar(60),
City varchar(40)
)

insert into CSstudents values ('Arbaj',23,'Male','Solapur'),
('Shailesh',25,'Male','Sambhajinagr')
,('Shifa',24,'female','Pune')
,('Rupesh',27,'Male','chandrapur')
,('Najim',25,'Male','Dhule')
,('Nilesh',26,'Male','Mumbai')
,('Vasudha',23,'Female','Nasik')

select * from CSstudents


