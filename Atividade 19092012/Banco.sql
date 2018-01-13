create database BDAtividade
GO
use BDAtividade

create table TBCliente (Codcli int identity not null primary key, NomeCli varchar(50),
						EndCli varchar(50), BairroCli varchar(50), CidCli varchar(50),
						EstCli varchar(50), CPFCli varchar(50), TelResCli varchar(50))

insert into TBCliente values('Maria Pardo', 'Rua Noventa - Nº 56', 'Jardim Alegria',
							 'Franco da Rocha', 'São Paulo', '498.588.692-90',
							 '4448-5989')