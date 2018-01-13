create database BD_Escolar
go
use BD_Escolar

create table TB_Aluno( cod_aluno int identity not null primary key, nome_aluno varchar(50), end_aluno varchar(100), tel_aluno varchar(50))
create table TB_Professor( cod_prof int identity not null primary key, nome_prof varchar(50), tel_prof varchar(50))

insert into TB_Aluno values ('Monica', 'Rua: Paraiso nº666 jd das flores Francisco Morato', '4811-5467')
insert into TB_Aluno values ('Vanessa', 'Rua: Fernando Gomes de Sá nº215 jd jabuticabeiras FRanco da Rocha', '4811-6148')

insert into TB_Professor values ('Raimunda','4444-4444')
insert into TB_Professor values ('Andrea','4445-4444')

--use master
--drop database BD_Escolar