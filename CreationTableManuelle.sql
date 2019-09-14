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
   Prenom	VARCHAR,
   Nom	VARCHAR,
   Specialites   VARCHAR,
   Remarques   VARCHAR
   --CONSTRAINT pk_NoAssistant  PRIMARY KEY(NoAssistant)
   );

         Print  'Création de la TABLE TypeSoin...' 
   CREATE TABLE TypeSoin (
   NoTypeSoin		INT primary key(NoTypeSoin),
   Description	VARCHAR
  -- CONSTRAINT pk_NoTypeSoin  PRIMARY KEY(NoTypeSoin)
   );

   Print  'Création de la TABLE Soin...' 

CREATE TABLE Soin (
   NoSoin		INT primary key(NoSoin),
   Description	VARCHAR,
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
   --CONSTRAINT fk_NoSoin FOREIGN KEY(NoSoin) references Soin(NoSoin),
  -- CONSTRAINT fk_NoAssistant FOREIGN KEY(NoAssistant) references Assistant(NoAssistant)
   );





   Print  'Création de la TABLE PlanifSoin...' 
   CREATE TABLE PlanifSoin (
   NoPersonne		INT,
   NoAssistant		INT foreign key(NoAssistant) references Assistant(NoAssistant),
   DateHeure		DATETIME,
   NoSoin			INT foreign key(NoSoin) references Soin(NoSoin)
   CONSTRAINT pk_NoPersonneNoAssistantDateHeure  PRIMARY KEY(NoPersonne,NoAssistant,DateHeure)
   );

     Print  'Création de la TABLE Client...' 
create table Client (
	NoCLient int primary key,
	Nom varchar,
	Prenom varchar, 
	Ville varchar,
	Pays varchar,
	Adresse varchar,
	CodePostal varchar,
	DateInscription datetime
)

     Print  'Création de la TABLE Invite...' 
create table Invite (
	NoInvite int primary key,
	NomPrenom varchar,
	NoClient int foreign key references Client(NoClient)
)

     Print  'Création de la TABLE TypeChambre...' 

create table TypeChambre (
	NoTypeChambre int primary key,
	Description varchar,
	PrixHaut numeric(10,2),
	PrixBas numeric(10,2),
	PrixMoyen numeric(10,2)
)
  Print  'Création de la TABLE Chambre...' 
create table Chambre (
	NoChambre int primary key,
	Emplacement int,
	Decorations varchar,
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

--A faire 
-------------

--1) Dans la table invite, la valeur de NoInv ne doit pas être divisible par 10 (ajoutez une contrainte).
--Exemple, 11, 12, 13, ...  

--2) Le numéro de personne dans la table PlanifSoin est soit un no de client, soit un no d’invité.

--3) Les numéros des invités d’un client sont définis comme suit :  
--Le client 10 a comme invités 11, 12, ..., le client 20 a comme invités 21, 22, ... 
--Par conséquent, si dans planifSoin, noPers vaut 10 on sait qu’il s’agit d’un client 
--et si noPersvaut 14, on sait qu’il s’agit d’un invité et que c’est l’invité du client 10.

--4) Dans la table typeSoin, il doit y avoir deux (2) types de soins : Beauté et Santé. Ajoutez ces 2 types de soins
--


--Ajoutez une table typeUtilisateur qui contient un numéro de type d’utilisateurs et son identification. Il existe deux types d’utilisateurs : Admin et PréposéAjoutez une table utilisateur qui contient des utilisateurs. Cette table doit contenir un numéro d’utilisateur (la clef primaire), un nom d’utilisateur (le nom d’utilisateur est unique), un mot de passe et un numéro de type d’utilisateur. Reliez ces deux tables et, dans la table utilisateur, insérez au moins un administrateur et au moins un préposé.  Vous ne devez pas permettre les suppressions en cascade. C’est votre application qui doit gérer les suppressions