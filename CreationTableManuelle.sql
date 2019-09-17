use BDTP1Guelleh_Marrero





DROP TABLE AssistantSoin;
DROP TABLE PlanifSoin;
DROP TABLE Soin;
DROP TABLE TypeSoin;
DROP TABLE Assistant;

drop table ReservationChambre
drop table Invite
drop table Client
drop table Chambre
drop table TypeChambre

drop table Utilisateur
drop table TypeUtilisateur


--DROP TABLE ReservationChambre;
--DROP TABLE Chambre;
--DROP TABLE TypeChambre;
--DROP TABLE Invite;
--DROP TABLE Client;

print 'Création des tables ========================================================'
print ''
   Print  'Création de la TABLE Assitant...' 
   CREATE TABLE Assistant (
   NoAssistant		INT primary key(NoAssistant),
   Prenom	varchar(50),
   Nom	varchar(50),
   Specialites   varchar(50),
   Remarques   varchar(50)
  
   );

         Print  'Création de la TABLE TypeSoin...' 
   CREATE TABLE TypeSoin (
   NoTypeSoin		INT primary key(NoTypeSoin),
   Description	varchar(50)
 
   );

   Print  'Création de la TABLE Soin...' 

CREATE TABLE Soin (
   NoSoin		INT primary key(NoSoin),
   Description	varchar(50),
   Duree        DATETIME,
   NoTypeSoin		INT foreign key(NoTypeSoin) references TypeSoin(NoTypeSoin),
   Prix         NUMERIC(10,2)
   --CONSTRAINT pk_NoSoin  PRIMARY KEY(NoSoin)
  
  --CONSTRAINT fk_inclus FOREIGN KEY(hotno) references  hotel(hotNo)
   );

Print  'Création de la TABLE AssistantSoin...' 

CREATE TABLE AssistantSoin (
   NoAssistant	INT foreign key(NoAssistant) references Assistant(NoAssistant),
   NoSoin		INT foreign key(NoSoin) references Soin(NoSoin),
   CONSTRAINT pk_NoAssistantNoSoin  PRIMARY KEY(NoAssistant,NoSoin)
   );




    
   Print  'Création de la TABLE PlanifSoin...' 
   CREATE TABLE PlanifSoin (
   NoPersonne		INT ,
   NoAssistant		INT foreign key(NoAssistant) references Assistant(NoAssistant),
   DateHeure		DATETIME,
   NoSoin			INT foreign key(NoSoin) references Soin(NoSoin)
   CONSTRAINT pk_NoPersonneNoAssistantDateHeure  PRIMARY KEY(NoPersonne,NoAssistant,DateHeure)
   );

     Print  'Création de la TABLE Client...' 
create table Client (
	NoCLient int primary key constraint checkNoClient check(NoCLient%10=0),
	Nom varchar(50),
	Prenom varchar(50), 
	Ville varchar(50),
	Pays varchar(50),
	Adresse varchar(50),
	CodePostal varchar(7),
	DateInscription datetime
)

     Print  'Création de la TABLE Invite...' 
create table Invite (
	NoInvite int primary key constraint  checkNoInvite check(NoInvite%10!=0),
	NomPrenom varchar(50),
	NoClient int foreign key references Client(NoClient)
)

     Print  'Création de la TABLE TypeChambre...' 

create table TypeChambre (
	NoTypeChambre int primary key,
	Description varchar(50),
	PrixHaut numeric(10,2),
	PrixBas numeric(10,2),
	PrixMoyen numeric(10,2)
)
  Print  'Création de la TABLE Chambre...' 
create table Chambre (
	NoChambre int primary key,
	Emplacement int,
	Decorations varchar(50),
	NoTypeChambre int foreign key references TypeChambre(NoTypeChambre)
)
  Print  'Création de la TABLE ReservationChambre...'
create table ReservationChambre (
	NoClient int foreign key references Client(NoClient),
	NoChambre int foreign key references Chambre(NoChambre),
	DateArrivee datetime,
	DateDepart datetime,
	NbPersonnes int,
	constraint pk_Reservation primary key(NoClient, NoChambre, DateArrivee)
)

 Print  'Création de la TABLE TypeUtilisateur...'
create table TypeUtilisateur (
	NoTypeUtilisteur int primary key,
	Identification varchar(50)
)

 Print  'Création de la TABLE Utilisateur...'
create table Utilisateur (
	NoUtilisateur int primary key,
	NomUtilisateur varchar(50) constraint unique_NomUtil unique,
	MotDePasse     varchar(50),
	NoTypeUtilisteur int foreign key references TypeUtilisateur(NoTypeUtilisteur)
)





print 'Remplissage des tables ========================================================'


Print  'Remplissage de la TABLE Assistant...'
insert into Assistant values(1,'Leclerc','Felix','Java','Asistant un')
insert into Assistant values(2,'Paquin','Eric','C#','Asistant deux')

Print  'Remplissage de la TABLE TypeSoin...'
insert into TypeSoin values(1,'TypeSoins un')
insert into TypeSoin values(2,'TypeSoins deux')




Print  'Remplissage de la TABLE Soin...'
insert into Soin values(1,'Le premier soin','2:30',1,10)
insert into Soin values(2,'Le deuxième soin','1:30',2,30)




Print  'Remplissage de la TABLE PlanifSoin...'
insert into PlanifSoin values(10,1,'2019-05-06 19:14:59',1)
insert into PlanifSoin values(20,2,'2019-05-09 20:20:59',2)



Print  'Remplissage de la TABLE AssistantSoin...'
insert into AssistantSoin values(1,1)
insert into AssistantSoin values(2,2)




Print  'Remplissage de la TABLE Client...'
insert into Client values(10,'Tremblay','David','Montreal','Canada','3434 rue Thivierge','H8H 2V3','2019-02-06')
insert into Client values(20,'Gagnon','Samuel','Quebec','Canada','6765 rue Legeault','H9O 2V7','2019-06-14')



Print  'Remplissage de la TABLE Invite...'
insert into Invite values(11,'Jonathan',10)
insert into Invite values(12,'John',10)
insert into Invite values(21,'Chirstopher',20)
insert into Invite values(22,'Francis',20)




Print  'Remplissage de la TABLE TypeChambre...'
insert into TypeChambre values (1, '1er type de chambre', 150, 140, 145)
insert into TypeChambre values (2, '2eme type de chambre', 200, 100, 150)

Print  'Remplissage de la TABLE Chambre...'
insert into Chambre values (1, 1, '1ere chambre à l''emplacement 1', 1)
insert into Chambre values (2, 2, '2eme chambre à l''emplacement 2', 1)
insert into Chambre values (3, 3, '3eme chambre à l''emplacement 3', 2)
insert into Chambre values (4, 4, '4eme chambre à l''emplacement 4', 2)

Print  'Remplissage de la TABLE ReservationChambre...'
insert into ReservationChambre values (10, 1, '2019-09-15', '2019-09-23', 2)
insert into ReservationChambre values (10, 2, '2019-08-01', '2019-09-20', 1)
insert into ReservationChambre values (20, 3, '2019-09-17', '2019-09-17', 5)
insert into ReservationChambre values (20, 4, '2019-09-10', '2019-09-25', 10)





 Print  'Remplissage de la TABLE TypeUtilisateur...'

 insert into TypeUtilisateur values(1,'Admin')
 insert into TypeUtilisateur values(2,'Préposé')

 Print  'Remplissage de la TABLE Utilisateur...'

 insert into Utilisateur values(1,'Lemoge','123456',1)
  insert into Utilisateur values(2,'Gariepy','123456',1)
   insert into Utilisateur values(3,'Porras','123456',1)
  insert into Utilisateur values(4,'Gabriel','654321',2)
   insert into Utilisateur values(5,'Mohamed','654321',2)
  insert into Utilisateur values(16,'Cedric','654321',2)





