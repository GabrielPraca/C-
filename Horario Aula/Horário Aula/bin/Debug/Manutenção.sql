/*drop table if exists Aula;
drop table if exists Materia;
drop table if exists RedDay;
drop table if exists Professor;
drop table if exists Turma;
drop table if exists Intervalo;
drop table if exists Horario;
*/
create table if not exists Horario(
CodHorario int unsigned auto_increment not null,
primary key(CodHorario),
Nome varchar(30)
);

create table if not exists Intervalo(
CodIntervalo int unsigned auto_increment not null,
primary key(CodIntervalo),
CodHorario int unsigned,
constraint fkCodHorario_Intervalo foreign key(CodHorario) references Horario(CodHorario),
DiaSemana tinyint unsigned,
HoraInicio time,
Duracao time
);

create table if not exists Professor(
CodProfessor int unsigned auto_increment not null,
primary key(CodProfessor),
CodHorario int unsigned,
constraint fkCodHorario_Professor foreign key(CodHorario) references Horario(CodHorario),
Nome varchar(60)
);

create table if not exists Materia(
CodMateria int unsigned auto_increment not null,
primary key(CodMateria),
CodHorario int unsigned,
constraint fkCodHorario_Materia foreign key(CodHorario) references Horario(CodHorario),
CodProfessor int unsigned,
constraint fkCodProfessor_Materia foreign key(CodProfessor) references Professor(CodProfessor),
Nome varchar(30)
);

create table if not exists RedDay(
CodRedDay int unsigned auto_increment not null,
primary key(CodRedDay),
CodProfessor int unsigned,
constraint fkCodProfessor_RedDay foreign key(CodProfessor) references Professor(CodProfessor),
CodIntervalo int unsigned,
constraint fkCodIntervalo_RedDay foreign key(CodIntervalo) references Intervalo(CodIntervalo),
Tipo tinyint unsigned
);

create table if not exists Turma(
CodTurma int unsigned auto_increment not null,
primary key(CodTurma),
CodHorario int unsigned,
constraint fkCodHorario_Turma foreign key(CodHorario) references Horario(CodHorario),
Nome varchar(20)
);

create table if not exists Aula(
CodAula int unsigned auto_increment not null,
primary key(CodAula),
CodHorario int unsigned,
constraint fkCodHorario_Aula foreign key(CodHorario) references Horario(CodHorario),
CodMateria int unsigned,
constraint fkCodMateria_Aula foreign key(CodMateria) references Materia(CodMateria),
CodTurma int unsigned,
constraint fkCodTurma_Aula foreign key(CodTurma) references Turma(CodTurma)
);