create database PollDB;

use PollDB;

create table Judet(
	judetID int primary key identity(1, 1),
	numeJudet varchar(50)
)

create table Municipiu(
	municipiuID int primary key identity(1, 1),
	numeMunicipiu varchar(50),
	judetID int foreign key references Judet(judetID)
)

create table Oras(
	orasID int primary key identity(1, 1),
	numeOras varchar(50),
	municipiuID int foreign key references Municipiu(municipiuID)
)	

create table Persoana(
	persoanaID int identity(1, 1) primary key,
	Nume varchar(50),
	Prenume varchar(50),
	sex varchar(1),
	studii varchar(50),
	email varchar(50),
	DataNasterii varchar(50),
	judetID int foreign key references Judet(judetID),
	municipiuID int foreign key references Municipiu(municipiuID),
	orasID int foreign key references Oras(orasID),
	Casatorit bit,
	Divortat bit,
	Participant bit
)

create table Tematica(
	tematicaID int primary key identity(1, 1),
	Tematica varchar(50)
)

create table Intrebare(
	intrebareID int primary key identity(1, 1),
	Intrebare varchar(200),
	tematicaID int foreign key references Tematica(tematicaID)
)

create table Limba(
	limbaID int primary key identity(1, 1),
	Limba varchar(50)
)

create table Raspuns(
	raspunsID int primary key identity(1, 1),
	Raspuns varchar(200),
	intrebareID int foreign key references Intrebare(intrebareID),
	persoanaID int foreign key references Persoana(persoanaID),
	limbaID int foreign key references Limba(limbaID)
)

create table Accounts(
	accountID int primary key identity(1, 1),
	login varchar(99),
	pass varchar(99)
)