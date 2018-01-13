create database BD_Livraria
go
use BD_Livraria

create table TB_Cliente(codcli int identity not null primary key, nomecli varchar(50),telcli varchar(50),cepcli varchar(50))
create table TB_Livro(codlivro int identity not null primary key, nomelivro varchar(50), codautor int, codeditora int)
create table TB_Autor(codautor int identity not null primary key, nomeautor varchar(50))
create table TB_Editora(codeditora int identity not null primary key, nomeeditora varchar(50), contato varchar(50))
create table TB_Venda(codvenda int identity not null primary key, datavenda varchar(50), codcli int, codlivro int, valortotal money)

alter table TB_Livro add constraint fkcodautor foreign key (codautor) references TB_Autor(codautor)
alter table TB_Livro add constraint fkcodeditora foreign key (codeditora) references TB_Editora(codeditora)

alter table TB_Venda add constraint fkcodcli foreign key (codcli) references TB_Cliente(codcli)
alter table TB_Venda add constraint fkcodlivro foreign key (codlivro) references TB_Livro(codlivro)



