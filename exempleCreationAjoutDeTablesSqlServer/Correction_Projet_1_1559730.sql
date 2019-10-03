--Gabriel Marrero 
--Projet 1
/*But : Créer une base de données SQL-Server pour une entreprise (Blockvidéo) qui gère
la location de films et de jeux vidéo.  */
use BD4B4Marrero

--Destruction des tables et des clés (EN ORDRE) pour pouvoir executer le script 
DROP TABLE EXEMPLAIRES
DROP TABLE PRODUITS
DROP TABLE NATURES
DROP TABLE CATEGORIES
DROP TABLE MEMBRES
DROP TABLE ABONNEMENTS
DROP TABLE CLUBS

--Création des tables avec leurs contraintes

--TABLE CLUBS
CREATE TABLE CLUBS (
NumClub INT CONSTRAINT Pk_NumClubCLUBS PRIMARY KEY, --CLÉ PRIMAIRE
NomClub VARCHAR(50),
Adresse VARCHAR(50) ,
Prov  CHAR(2),
CodePostal VARCHAR(10),
Pays VARCHAR(5)  CONSTRAINT CK_Pays
CHECK (UPPER(Pays) IN ('CA','USA'))  , 
Gerant  VARCHAR(30) ,
Tel1 VARCHAR(30) ,
Tel2 VARCHAR(30),
Courrier VARCHAR(30),
dateMAJ DATE , 
auteurMAJ VARCHAR(30)
)
--INS�RER DES VALEURS POUR LA TABLE CLUBS
/**************************************/
INSERT INTO  CLUBS VALUES (11111,'Ymca','3453 rue Thivierge','Qc','h4s 9w5','CA','Gabriel','(514) 856-4875','(514) 864-5632','sql@cgodin.qc.ca', '2019-07-03' ,'Pierre')
INSERT INTO  CLUBS VALUES (22222,'Piscine','3657 rue Elgin','Qc','h8j 8s3','CA','Samy','(514) 685-2478','(514) 354-9874','java@cgodin.qc.ca', '2019-08-03','Jean')
INSERT INTO  CLUBS VALUES (33333,'Maison','4548 rue Forbes','Qc','j6s 85h','USA','Alex','(514) 124-4765','(514) 987-3322','web@cgodin.qc.ca', '2019-06-03','Luc')
--SELECT * FROM CLUBS

/**************************************/

--TABLE ABONNEMENTS
CREATE TABLE ABONNEMENTS(
NumAbonnement INT CONSTRAINT Pk_NumAbonnementABONNEMENTS PRIMARY KEY, --CLÉ PRIMAIRE
Adresse VARCHAR(50) ,
Prov CHAR(2) CONSTRAINT CK_PROVINCE
CHECK (UPPER(Prov) IN ('AB','BC','PE','MB','NB','NS','NU','ON','QC','SK','NL','NT','YT')) DEFAULT 'QC' NOT NULL, 
--#HS# Pour que ca marche
	-- Prov varchar(10) COLLATE Latin1_General_CS_AS constraint CK_prov check (LEN(Prov)=2 and UPPER(Prov)=Prov) 
		--default 'QC' not null, 
	-- ou bien
	-- Prov varchar(2) COLLATE Latin1_General_CS_AS constraint CK_prov check (Prov IN ('AB','BC','PE','MB','NB','NS','NU','ON','QC','SK','NL','YT','NT'))
	--default 'QC' not null,
CodePostal VARCHAR(10),
Pays VARCHAR(2) DEFAULT 'CA', -- � REVOIR une erreur ici
--#HS#
--Pays VARCHAR(3) DEFAULT 'CA', -- USA = 3
Tel1 VARCHAR(30) ,
Tel2 VARCHAR(30),
Boni INT,
DateAdhesion DATE ,
NumClub INT CONSTRAINT Fk_NumClubABONNEMENTS FOREIGN KEY REFERENCES CLUBS(NumClub), --CLÉ ÉTRANGÈRE QUI RELIE NumClub de LA TABLE CLUBS
Remarque VARCHAR(50) 
)
--INSÉRER DES VALEURS POUR LA TABLE ABONNEMENTS
/**************************************/
INSERT INTO ABONNEMENTS VALUES (12345,'123 rue Blainville','QC','h7d 8g3','CA','(514) 845-5423','(514) 825-4586',12,'2014-03-04',11111,'Belle remarque')
--#HS#
--INSERT INTO ABONNEMENTS VALUES (12345,'123 rue Blainville','qc','h7d 8g3','CA','(514) 845-5423','(514) 825-4586',12,'2014-03-04',11111,'Belle remarque')
INSERT INTO ABONNEMENTS VALUES (45874,'123 rue Sorelle','NU','j8h 7sd ','CA','(514) 657-2152','(514) 987-4586',13,'2018-03-04',22222,'une autre remarque')
INSERT INTO ABONNEMENTS (NumAbonnement,Adresse,Prov,CodePostal,Tel1,Tel2,Boni,DateAdhesion,NumClub,Remarque) VALUES (68745,'456 rue Mastel','YT','K9G 6G4','(514) 453-1247','(514) 987-2496',13,'2015-03-04',33333,'la remarque')


--SELECT * FROM ABONNEMENTS

/**************************************/

--TABLE MEMBRES
CREATE TABLE MEMBRES(
NumAbonnement INT CONSTRAINT FK_NumAbonnementMEMBRES FOREIGN KEY REFERENCES ABONNEMENTS(NumAbonnement) NOT NULL, --CLÉ ÉTRANGÈRE QUI RELIE NumAbonnement DE ABONNEMENTS
NumMembre INT CONSTRAINT PK_NumAbonnementNumMembreMEMBRES PRIMARY KEY(NumAbonnement,NumMembre) NOT NULL, --CLÉ PRIMAIRE
Nom VARCHAR(30) NOT NULL,
DateAdhesion DATE NOT NULL
)
--INS�RER DES VALEURS POUR LA TABLE MEMBRES
/**************************************/
INSERT INTO MEMBRES VALUES(12345,12345,'Gabriel','2019-03-04')
INSERT INTO MEMBRES VALUES(45874,45874,'ALEX','2019-06-04')
INSERT INTO MEMBRES VALUES(68745,68745,'CEDRIC','2019-04-04')

--SELECT * FROM MEMBRES

/**************************************/

--TABLE CATÉGORIES
CREATE TABLE CATEGORIES(
NumCategorie INT CONSTRAINT PK_NumCategorieCATEGORIES PRIMARY KEY NOT NULL, -- CLÉ PRIMAIRE
Description VARCHAR(30) NOT NULL,
DureeEnJour INT NOT NULL,
PrixLocation INT CONSTRAINT CK_PrixLocation CHECK ( PrixLocation >0) NOT NULL, --PAS SUR  -- CONTRAINTE CHECK QUI PERMET SEUELEMENT LES PRIX PLUS GRAND QUE 0
dateMAJ DATE NOT NULL, --PAS SUR
auteurMAJ VARCHAR(30) NOT NULL --PAS SUR
)
--INSÉRER DES VALEURS POUR LA TABLE CATÉGORIES
/**************************************/
INSERT INTO CATEGORIES VALUES (111,'TEST',24,50,'2015-06-10','Gabriel')
INSERT INTO CATEGORIES VALUES (222,'BONJOUR',24,76,'2014-03-11','Alex')
INSERT INTO CATEGORIES VALUES (333,'BONSOIR',30,1,'2015-06-10','Gabriel')
--SELECT * FROM CATEGORIES

/**************************************/

--TABLE NATURES

CREATE TABLE NATURES(
NumNature INT CONSTRAINT PK_NumNatureNATURES PRIMARY KEY NOT NULL, --CLÉ PRIMAIRE
Description  VARCHAR(30) NOT NULL
)

--INSÉRER DES VALEURS POUR LA TABLE NATURES
/**************************************/
--#HS# Il faut insérer toutes les natures comme mentionné dans l'énoncé
/*
insert into NATURES values
	(1,'Drame'),
	(2,'Comédie'),
	(3,'Fiction'),
	(4,'Téléroman'),
	(5,'Aventure'),
	(6,'Documentaire'),
	(7,'Stratégie'),
	(8,'Cours'),
	(9,'Société'),
	(10,'Ludiciel'),
	(11,'Fantastique'),
	(12,'Divers')
	*/
INSERT INTO NATURES VALUES (111,'NATURE')
INSERT INTO NATURES VALUES (222,'ARBRE')
INSERT INTO NATURES VALUES (333,'FELURS')

--SELECT * FROM NATURES



/**************************************/

--TABLE PRODUITS
CREATE TABLE PRODUITS(
NumProduit INT CONSTRAINT PK_NumProduitPRODUITS PRIMARY KEY,  -- CLÉ PRIMAIRE
QteStock INT ,
NumCategorie INT CONSTRAINT FK_NumCategoriePRODUITS FOREIGN KEY REFERENCES CATEGORIES(NumCategorie) , -- CLÉ ÉTRANGÈÈRE QUI EST RELIÉE À NumCategorie DE LA TABLE CATEGORIES 
NumNature INT CONSTRAINT FK_NumNaturePRODUITS FOREIGN KEY REFERENCES NATURES(NumNature) , --CLÉ ÉTRANGÈRE QUI EST RELIÉE À NumNature DE LA TABLE NATURES
Titre VARCHAR(30) ,
PrixUnitaire INT CONSTRAINT CK_PrixUnitaire CHECK ( PrixUnitaire >0), --PAS SUR -- CONTRAINTE CHECK QUI PERMET SEUELEMENT LES PRIX PLUS GRAND QUE 0
DateAchat DATE ,
DateParution DATE, 
CONSTRAINT CK_DateParution CHECK (DateParution<DateAchat ),
Langue VARCHAR(30),
Producteur VARCHAR(30)
)

--INSÉRER DES VALEURS POUR LA TABLE PRODUITS
/**************************************/
INSERT INTO PRODUITS VALUES (11111,5,111,111,'TITRE',15,'2016-09-15','2000-06-04','FR','GABRIEL')
INSERT INTO PRODUITS VALUES (22222,5,222,222,'PAGE',20,'2018-09-15','2001-06-04','ES','ALEX')
INSERT INTO PRODUITS VALUES (33333,5,333,333,'FEUILLE',15,'2020-09-15','2005-06-04','PO','CEDRIC')
--SELECT * FROM PRODUITS

/**************************************/


--TABLE EXEMPLAIRES
CREATE TABLE EXEMPLAIRES(
NumClub INT CONSTRAINT Fk_NumClubEXEMPLAIRES FOREIGN KEY REFERENCES CLUBS(NumClub) NOT NULL, --CLÉ ÉTRANGÈRE QUI RELIE NumClub de LA TABLE CLUBS
NumProduit  INT CONSTRAINT FK_NumProduitEXEMPLAIRES FOREIGN KEY REFERENCES PRODUITS(NumProduit) NOT NULL, --CLÉ ÉTRANGÈRE QUI EST RELIÉE À NumProduit DE LA TABLE PRODUITS
NumExemplaire INT CONSTRAINT Pk_NumClubProduitEXEMPLAIRES PRIMARY KEY(NumClub,NumProduit,NumExemplaire) NOT NULL, --CLÉ PRIMAIRE
NumAbonnement INT NOT NULL,
NumMembre INT NOT NULL,
 CONSTRAINT FK_NumAbonnementNumMembreEXEMPLAIRES FOREIGN KEY(NumAbonnement,NumMembre) REFERENCES MEMBRES(NumAbonnement,NumMembre), --CLÉ ÉTRANGÈRE QUI EST RELIÉE À NumAbonnement,NumMembre DE MEMBRES PAS SUR DE CETTE FAÇON
Statut INT NOT NULL,
 CONSTRAINT CK_Statut CHECK (Statut = '1' OR Statut = '0' ), --PAS SUR DE CETTE SOLUTION
DateEmprunt DATE,
DateRemisePrevue DATE,
Commentaire VARCHAR(50) NOT NULL,
--#HS#
--Commentaire int constraint CK_commentaire
		--check (Commentaire>=0 and Commentaire <=9) not null,
NbEmprunts INT NOT NULL
)
--INSÉRER DES VALEURS POUR LA TABLE EXEMPLAIRES
/**************************************/
INSERT INTO EXEMPLAIRES VALUES (11111,11111,232323,12345,12345,0,'2019-02-05','2019-02-06','TEST',6)
INSERT INTO EXEMPLAIRES VALUES (22222,22222,343434,45874,45874,1,'2017-02-05','2019-02-06','TEST',6)
INSERT INTO EXEMPLAIRES VALUES (33333,33333,343434,68745,68745,0,'2020-02-05','2020-02-06','TEST',6)
--SELECT * FROM EXEMPLAIRES


/**************************************/

-- #HS# 
	select * from NATURES
	select * from CATEGORIES
	select * from PRODUITS
	select * from CLUBS
	select * from ABONNEMENTS
	select * from EXEMPLAIRES
	select * from MEMBRES