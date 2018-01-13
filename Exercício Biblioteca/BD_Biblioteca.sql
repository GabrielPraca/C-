create database BD_Biblioteca
go
use BD_Biblioteca

create table TB_Usuario(codusuario int not null primary key,
					    nomeusuario varchar(50), telusuario varchar(50),)
					    
create table TB_Livro(codlivro int not null primary key,
					  nomelivro varchar(50), qtdeestoque varchar(50))
					  
create table TB_Funcionario(codfuncionario int not null primary key,
							nomefuncionario varchar(50))
							
create table TB_Emprestimo(codemprestimo int not null primary key,
						   dataemprestimo varchar(50),codusuario int,
						   codfuncionario int)
						   
create table TB_Item(coditem int not null identity, 
					 codemprestimo int, codlivro int)
					 
alter table TB_Emprestimo add constraint fkcodfuncionario foreign key (codfuncionario) references TB_Funcionario(codfuncionario)
alter table TB_Emprestimo add constraint fkcodusuario foreign key (codusuario) references TB_Usuario(codusuario)
alter table TB_Item add constraint fkcodemprestimo foreign key (codemprestimo) references TB_Emprestimo(codemprestimo)

insert into TB_Usuario values (1, 'Felipe Araujo','4811-8411' )
insert into TB_Usuario values (2, 'Maria Betania','4819-5411' )

insert into TB_Livro values (1, 'Dom Casmurro','4' )
insert into TB_Livro values (2, 'Crepusculo','5' )

insert into TB_Funcionario values (1, 'José Petronio')
insert into TB_Funcionario values (2, 'André Simeão')

insert into TB_Emprestimo values (1, '22/09/1996', 1, 2)
insert into TB_Emprestimo values (2, '23/09/1996', 2, 1)

insert into TB_Item values (1, 1)
insert into TB_Item values (2, 2)






