#------------------------------------------------------------
#        Script MySQL.
#------------------------------------------------------------


#------------------------------------------------------------
# Table: COMMERCIAL
#------------------------------------------------------------

CREATE TABLE COMMERCIAL(
        id_salarie               int (11) Auto_increment  NOT NULL ,
        nom_salarie              Varchar (25) NOT NULL ,
        prenom_salarie           Varchar (25) NOT NULL ,
        adresse_salarie          Varchar (25) NOT NULL ,
        cp_salarie               Varchar (25) NOT NULL ,
        ville_salarie            Varchar (25) NOT NULL ,
        tel_salarie              Varchar (25) NOT NULL ,
        mail_salarie             Varchar (25) NOT NULL ,
        distanceParcourueSemaine Int ,
        numUtilisateur           Int ,
        idPortefeuille           Int ,
        PRIMARY KEY (id_salarie )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: TYPERDV
#------------------------------------------------------------

CREATE TABLE TYPERDV(
        id_type_rdv Int NOT NULL ,
        type_rdv    Varchar (25) NOT NULL ,
        PRIMARY KEY (id_type_rdv )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: STRUCTURE
#------------------------------------------------------------

CREATE TABLE STRUCTURE(
        num_structure        int (11) Auto_increment  NOT NULL ,
        denomination_sociale Varchar (25) NOT NULL ,
        adresse_structure    Varchar (25) NOT NULL ,
        cp_structure         Varchar (25) NOT NULL ,
        ville_structure      Varchar (25) NOT NULL ,
        distance_siege       Float NOT NULL ,
        plan_accees          Varchar (25) NOT NULL ,
        infos_supplementaire Varchar (25) NOT NULL ,
        codeTypeStructure    Int NOT NULL ,
        PRIMARY KEY (num_structure )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: INTERLOCUTEUR
#------------------------------------------------------------

CREATE TABLE INTERLOCUTEUR(
        id_interlocuteur     int (11) Auto_increment  NOT NULL ,
        nom_interlocuteur    Varchar (25) NOT NULL ,
        prenom_interlocuteur Varchar (25) NOT NULL ,
        tel_interlocuteur    Varchar (25) NOT NULL ,
        mail_interlocuteur   Varchar (25) NOT NULL ,
        num_individu         Int NOT NULL ,
        idPortefeuille       Int ,
        PRIMARY KEY (id_interlocuteur )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: PARTICULIER
#------------------------------------------------------------

CREATE TABLE PARTICULIER(
        num_individu         int (11) Auto_increment  NOT NULL ,
        adresse_individu     Varchar (25) NOT NULL ,
        cp_individu          Varchar (25) NOT NULL ,
        ville_individu       Varchar (25) NOT NULL ,
        distance_siege       Float NOT NULL ,
        plan_accees          Varchar (25) NOT NULL ,
        infos_supplementaire Varchar (25) NOT NULL ,
        id_interlocuteur     Int NOT NULL ,
        PRIMARY KEY (num_individu )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: RDV
#------------------------------------------------------------

CREATE TABLE RDV(
        id_rdv                int (11) Auto_increment  NOT NULL ,
        date_rdv              Date NOT NULL ,
        heure_debut           Date NOT NULL ,
        heure_fin             Date NOT NULL ,
        adresseDerogatoire    Varchar (50) ,
        villeDerogatoire      Varchar (30) ,
        codeEntreeDerogatoire Int ,
        infoDerogatoire       Varchar (500) ,
        id_interlocuteur      Int NOT NULL ,
        id_type_rdv           Int NOT NULL ,
        idPlanning            Varchar (25) ,
        PRIMARY KEY (id_rdv )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: CONGES
#------------------------------------------------------------

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

CREATE TABLE TYPE_UTILISATEUR(
        codeTypeUtilisateur    Int NOT NULL ,
        libelleTypeUtilisateur Varchar (25) ,
        PRIMARY KEY (codeTypeUtilisateur )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: MAIL
#------------------------------------------------------------

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

CREATE TABLE PLANNING(
        idPlanning Varchar (25) NOT NULL ,
        id_salarie Int NOT NULL ,
        PRIMARY KEY (idPlanning )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: TYPE_STRUCTURE
#------------------------------------------------------------

CREATE TABLE TYPE_STRUCTURE(
        codeTypeStructure    Int NOT NULL ,
        libelleTypeStructure Varchar (30) ,
        PRIMARY KEY (codeTypeStructure )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: PORTEFEUILLE
#------------------------------------------------------------

CREATE TABLE PORTEFEUILLE(
        idPortefeuille      Int NOT NULL ,
        libellePortefeuille Varchar (30) ,
        id_salarie          Int NOT NULL ,
        PRIMARY KEY (idPortefeuille )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: APPARTENIR
#------------------------------------------------------------

CREATE TABLE APPARTENIR(
        id_interlocuteur Int NOT NULL ,
        num_structure    Int NOT NULL ,
        PRIMARY KEY (id_interlocuteur ,num_structure )
)ENGINE=InnoDB;


#------------------------------------------------------------
# Table: SUIVRE
#------------------------------------------------------------

CREATE TABLE SUIVRE(
        id_rdv     Int NOT NULL ,
        id_rdv_RDV Int NOT NULL ,
        PRIMARY KEY (id_rdv ,id_rdv_RDV )
)ENGINE=InnoDB;
