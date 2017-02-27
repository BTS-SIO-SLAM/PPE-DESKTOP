#------------------------------------------------------------
# Table: COMMERCIAL
#------------------------------------------------------------

DROP TABLE COMMERCIAL;

CREATE TABLE COMMERCIAL(
        id_salarie               int (10) Auto_increment  NOT NULL ,
        nom_salarie              Varchar (25) NOT NULL ,
        prenom_salarie           Varchar (25) NOT NULL ,
        adresse_salarie          Varchar (50) NOT NULL ,
        cp_salarie               Varchar (10) NOT NULL ,
        ville_salarie            Varchar (20) NOT NULL ,
        tel_salarie              Varchar (20) NOT NULL ,
        mail_salarie             Varchar (30) NOT NULL ,
        distanceParcourueSemaine Int ,
        numUtilisateur           Int ,
        idPortefeuille           Int ,
        PRIMARY KEY (id_salarie )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: TYPERDV
#------------------------------------------------------------

DROP TABLE TYPERDV;

CREATE TABLE TYPERDV(
        id_type_rdv Int NOT NULL ,
        type_rdv    Varchar (30) NOT NULL ,
        PRIMARY KEY (id_type_rdv )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: STRUCTURE_INTERLOCUTEUR
#------------------------------------------------------------

DROP TABLE STRUCTURE_INTERLOCUTEUR;

CREATE TABLE STRUCTURE_INTERLOCUTEUR(
        num_structure        int (10) Auto_increment  NOT NULL ,
        denomination_sociale Varchar (30) NOT NULL ,
        adresse_structure    Varchar (50) NOT NULL ,
        cp_structure         Varchar (10) NOT NULL ,
        ville_structure      Varchar (20) NOT NULL ,
        distance_siege       Float NOT NULL ,
        plan_accees          Varchar (100) NOT NULL ,
        infos_supplementaire Varchar (100) NOT NULL ,
        codeTypeStructure    Int NOT NULL ,
        PRIMARY KEY (num_structure )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: INTERLOCUTEUR
#------------------------------------------------------------

DROP TABLE INTERLOCUTEUR;

CREATE TABLE INTERLOCUTEUR(
        id_interlocuteur     int (10) Auto_increment  NOT NULL ,
        nom_interlocuteur    Varchar (25) NOT NULL ,
        prenom_interlocuteur Varchar (25) NOT NULL ,
        tel_interlocuteur    Varchar (20) NOT NULL ,
        mail_interlocuteur   Varchar (30) NOT NULL ,
        num_individu         Int NOT NULL ,
        idPortefeuille       Int ,
        PRIMARY KEY (id_interlocuteur )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: PARTICULIER
#------------------------------------------------------------

DROP TABLE PARTICULIER;

CREATE TABLE PARTICULIER(
        num_individu         int (10) Auto_increment  NOT NULL ,
        adresse_individu     Varchar (50) NOT NULL ,
        cp_individu          Varchar (10) NOT NULL ,
        ville_individu       Varchar (20) NOT NULL ,
        distance_siege       Float NOT NULL ,
        plan_accees          Varchar (100) NOT NULL ,
        infos_supplementaire Varchar (100) NOT NULL ,
        id_interlocuteur     Int NOT NULL ,
        PRIMARY KEY (num_individu )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: RDV
#------------------------------------------------------------

DROP TABLE RDV;

CREATE TABLE RDV(
        id_rdv                int (10) Auto_increment  NOT NULL ,
        date_rdv              Date NOT NULL ,
        heure_debut           Time NOT NULL ,
        heure_fin             Time NOT NULL ,
        adresseDerogatoire    Varchar (50) ,
        villeDerogatoire      Varchar (20) ,
        codeEntreeDerogatoire Int ,
        infoDerogatoire       Varchar (100) ,
        id_interlocuteur      Int NOT NULL ,
        id_type_rdv           Int NOT NULL ,
        idPlanning            Varchar (10) ,
        PRIMARY KEY (id_rdv )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: CONGES
#------------------------------------------------------------

DROP TABLE CONGES;

CREATE TABLE CONGES(
        numConge       Int NOT NULL ,
        dateDebutConge Datetime ,
        dateFinConge   Datetime ,
        id_salarie     Int NOT NULL ,
        PRIMARY KEY (numConge )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: UTILISATEUR
#------------------------------------------------------------

DROP TABLE UTILISATEUR;

CREATE TABLE UTILISATEUR(
        numUtilisateur      Int NOT NULL ,
        loginUtilisateur    Varchar (50) ,
        passwordUtilisateur Varchar (50) ,
        dateDernierLogin    Datetime ,
        nbTentatives        Int ,
        codeTypeUtilisateur Int NOT NULL ,
        PRIMARY KEY (numUtilisateur )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: TYPE_UTILISATEUR
#------------------------------------------------------------

DROP TABLE TYPE_UTILISATEUR;

CREATE TABLE TYPE_UTILISATEUR(
        codeTypeUtilisateur    Int NOT NULL ,
        libelleTypeUtilisateur Varchar (25) ,
        PRIMARY KEY (codeTypeUtilisateur )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: MAIL
#------------------------------------------------------------

DROP TABLE MAIL;

CREATE TABLE MAIL(
        numMail          Int NOT NULL ,
        contenuMail      Varchar (10000) ,
        objetMail        Varchar (50) ,
        id_salarie       Int NOT NULL ,
        id_interlocuteur Int NOT NULL ,
        PRIMARY KEY (numMail )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: PLANNING
#------------------------------------------------------------

DROP TABLE PLANNING;

CREATE TABLE PLANNING(
        idPlanning Varchar (10) NOT NULL ,
        id_salarie Int NOT NULL ,
        PRIMARY KEY (idPlanning )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: TYPE_STRUCTURE
#------------------------------------------------------------

DROP TABLE TYPE_STRUCTURE;

CREATE TABLE TYPE_STRUCTURE(
        codeTypeStructure    Int NOT NULL ,
        libelleTypeStructure Varchar (30) ,
        PRIMARY KEY (codeTypeStructure )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: PORTEFEUILLE
#------------------------------------------------------------

DROP TABLE PORTEFEUILLE;

CREATE TABLE PORTEFEUILLE(
        idPortefeuille      Int NOT NULL ,
        libellePortefeuille Varchar (30) ,
        id_salarie          Int NOT NULL ,
        PRIMARY KEY (idPortefeuille )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: APPARTENIR
#------------------------------------------------------------

DROP TABLE APPARTENIR;

CREATE TABLE APPARTENIR(
        id_interlocuteur Int NOT NULL ,
        num_structure    Int NOT NULL ,
        PRIMARY KEY (id_interlocuteur ,num_structure )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: SUIVRE
#------------------------------------------------------------

DROP TABLE SUIVRE;

CREATE TABLE SUIVRE(
        id_rdv     Int NOT NULL ,
        id_rdv_RDV Int NOT NULL ,
        PRIMARY KEY (id_rdv ,id_rdv_RDV )
)ENGINE=InnoDB;
