create database BDLogin
GO
use BDLogin

create table TBUsuario(CodUso int identity not null primary key, Usuario varchar(50),
					   Senha varchar(50), privilegio varchar(50))
					   
insert into TBUsuario values ('andré','1234','administrador') 