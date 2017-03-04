SET foreign_key_checks = 0;

#------------------------------------------------------------
# Table: UTILISATEUR
#------------------------------------------------------------
insert into UTILISATEUR (numUtilisateur, nomUtilisateur, prenomUtilisateur, adresseUtilisateur, cpUtilisateur, villeUtilisateur, telUtilisateur, mailUtilisateur, distanceParcourueSemaine, loginUtilisateur, passwordUtilisateur, dateDernierLogin, nbTentatives, codeTypeUtilisateur, idPlanning, idPortefeuille, version) values 
(1, 'Jimmy', 'Clark', '32598 Melvin Point', 7500, 'Sāqayn', '967-(798)407-8439', 'jclark0@amazonaws.com', 0, 'jclark', MD5(12345), 20160326,  0, 1, null, null,0);
insert into UTILISATEUR (numUtilisateur, nomUtilisateur, prenomUtilisateur, adresseUtilisateur, cpUtilisateur, villeUtilisateur, telUtilisateur, mailUtilisateur, distanceParcourueSemaine, loginUtilisateur, passwordUtilisateur, dateDernierLogin, nbTentatives, codeTypeUtilisateur, idPlanning, idPortefeuille, version) values 
(2, 'Patricia', 'Griffin', '5301 Oak Parkway', 7500, 'Jiwei', '86-(792)136-2859', 'pgriffin1@kickstarter.com', 0, 'pgriffin', MD5(12345), 20160326, 0, 2, null, null,0);
insert into UTILISATEUR (numUtilisateur, nomUtilisateur, prenomUtilisateur, adresseUtilisateur, cpUtilisateur, villeUtilisateur, telUtilisateur, mailUtilisateur, distanceParcourueSemaine, loginUtilisateur, passwordUtilisateur, dateDernierLogin, nbTentatives, codeTypeUtilisateur, idPlanning, idPortefeuille, version) values 
(3, 'Jack', 'Robinson', '8 Roth Parkway', 7500, 'Veselynove', '380-(969)729-3321', 'jrobinson2@twitpic.com', 0, 'jrobinson', MD5(12345), 20160326, 0, 3, null, null,0);
insert into UTILISATEUR (numUtilisateur, nomUtilisateur, prenomUtilisateur, adresseUtilisateur, cpUtilisateur, villeUtilisateur, telUtilisateur, mailUtilisateur, distanceParcourueSemaine, loginUtilisateur, passwordUtilisateur, dateDernierLogin, nbTentatives, codeTypeUtilisateur, idPlanning, idPortefeuille, version) values 
(4, 'Jack', 'Lopez', '82 5th Lane', 7500, 'Lingmen', '86-(743)835-5499', 'jlopez3@independent.co.uk', 0, 'jlopez', MD5(12345), 20160326, 0, 1, null, null,0);
insert into UTILISATEUR (numUtilisateur, nomUtilisateur, prenomUtilisateur, adresseUtilisateur, cpUtilisateur, villeUtilisateur, telUtilisateur, mailUtilisateur, distanceParcourueSemaine, loginUtilisateur, passwordUtilisateur, dateDernierLogin, nbTentatives, codeTypeUtilisateur, idPlanning, idPortefeuille, version) values 
(5, 'Gregory', 'Cunningham', '7897 Acker Plaza', 7500, 'Qianjin', '86-(881)556-5418', 'gcunningham4@hatena.ne.jp', 0, 'gcunningham', MD5(12345), 20160326, 0, 2, null, null,0);

SELECT * FROM UTILISATEUR;

#------------------------------------------------------------
# Table: TYPERDV
#------------------------------------------------------------
insert into TYPERDV (id_type_rdv, type_rdv, version) values
(1,'Premiere Rencontre' , 0);
insert into TYPERDV (id_type_rdv, type_rdv, version) values
(2,'Rendez vous telephonique' , 0);
insert into TYPERDV (id_type_rdv, type_rdv, version) values
(3,'Presentation' , 0);
insert into TYPERDV (id_type_rdv, type_rdv, version) values
(4,'Visite de courtoisie' , 0);
insert into TYPERDV (id_type_rdv, type_rdv, version) values
(5,'Visiste technique' , 0);
insert into TYPERDV (id_type_rdv, type_rdv, version) values
(6,'Conclusion' , 0);

SELECT * FROM TYPERDV;

#------------------------------------------------------------
# Table: TYPE_STRUCTURE
#------------------------------------------------------------
insert into TYPE_STRUCTURE (codeTypeStructure, libelleTypeStructure, version) values
(1,'Organisation' , 0);
insert into TYPE_STRUCTURE (codeTypeStructure, libelleTypeStructure, version) values
(2,'Association' , 0);
insert into TYPE_STRUCTURE (codeTypeStructure, libelleTypeStructure, version) values
(3,'Ligue' , 0);
insert into TYPE_STRUCTURE (codeTypeStructure, libelleTypeStructure, version) values
(4,'PME' , 0);
insert into TYPE_STRUCTURE (codeTypeStructure, libelleTypeStructure, version) values
(5,'Grande entreprise' , 0);

SELECT * FROM TYPE_STRUCTURE;

#------------------------------------------------------------
# Table: STRUCTURE
#------------------------------------------------------------
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure, version) values 
(1,'structure 1', '97701 Nova Circle', '46900-000', 'Seabra', 1, '3 Prairieview Terrace', 'Ergonomic multimedia encoding', 1 , 0);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure, version) values 
(2,'structure 2', '0850 Kenwood Hill', '13140-000', 'Paulínia', 2, '266 Dawn Alley', 'Synchronised needs-based superstructure', 2 , 0);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure, version) values 
(3,'structure 3', '14272 Elka Plaza', '75000', 'Jiaoxie', 3, '04 Vernon Alley', 'Configurable multi-state concept', 3 , 0);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure, version) values 
(4,'structure 4', '97194 Fairfield Hill', '75000', 'Fengshan', 4, '685 Michigan Lane', 'Networked coherent contingency', 4 , 0);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure, version) values 
(5,'structure 5', '9366 Orin Lane', '75000', 'Baipenzhu', 5, '16066 Holmberg Pass', 'Public-key content-based knowledge base', 5, 0) , 0;
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure) values 
(6,'structure 6', '400 Kingsford Pass', '75000', 'Goubétto', 6, '3 Monument Parkway', 'Future-proofed impactful projection', 1, 0);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure, version) values 
(7,'structure 7', '393 Steensland Point', '2110', 'Red Hill', 7, '089 Farmco Parkway', 'Multi-lateral 4th generation data-warehouse', 2, 0);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure, version) values 
(8,'structure 8', '6 Monica Road', '2508', 'Nanyo', 8, '04092 Kinsman Way', 'Function-based national local area network', 3, 0);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure, version) values 
(9,'structure 9', '4513 Fairfield Junction', '75000', 'Parungjawa', 9, '030 Pleasure Trail', 'Visionary asynchronous forecast', 4, 0);
insert into STRUCTURE (num_structure, denomination_sociale, adresse_structure ,  cp_structure , ville_structure, distance_siege, plan_accees, infos_supplementaire, codeTypeStructure, version) values 
(10,'structure 10', '0076 Blaine Drive', '75000', 'Nanning', 10, '51 Manufacturers Drive', 'Automated asynchronous matrix', 5, 0);

SELECT * FROM STRUCTURE;

#------------------------------------------------------------
# Table: INTERLOCUTEUR
#------------------------------------------------------------
insert into INTERLOCUTEUR (id_interlocuteur, nom_interlocuteur, prenom_interlocuteur, tel_interlocuteur, mail_interlocuteur, num_individu, idPortefeuille, version) values 
(1,'Bouze', 'Camélia', '33-(390)653-6256', 'jjackson0@sciencedaily.com', 1, null, 0);
insert into INTERLOCUTEUR (id_interlocuteur, nom_interlocuteur, prenom_interlocuteur, tel_interlocuteur, mail_interlocuteur, num_individu, idPortefeuille, version) values 
(2,'Alaki', 'Crééz', '30-(294)242-7802', 'ppowell1@ameblo.jp', 2, null, 0);
insert into INTERLOCUTEUR (id_interlocuteur, nom_interlocuteur, prenom_interlocuteur, tel_interlocuteur, mail_interlocuteur, num_individu, idPortefeuille, version) values 
(3,'Kogu', 'Mégane', '972-(623)893-2322', 'dhudson2@joomla.org', 3, null, 0);
insert into INTERLOCUTEUR (id_interlocuteur, nom_interlocuteur, prenom_interlocuteur, tel_interlocuteur, mail_interlocuteur, num_individu, idPortefeuille, version) values 
(4,'pistali', 'Ruì', '30-(938)455-3301', 'palvarez3@baidu.com', 4, null, 0);
insert into INTERLOCUTEUR (id_interlocuteur, nom_interlocuteur, prenom_interlocuteur, tel_interlocuteur, mail_interlocuteur, num_individu, idPortefeuille, version) values 
(5,'Papoom', 'Cécilia', '967-(562)366-2705', 'srice4@goo.ne.jp', 5, null, 0);

SELECT * FROM INTERLOCUTEUR;

#------------------------------------------------------------
# Table: INDIVIDU
#------------------------------------------------------------
insert into INDIVIDU (num_individu, adresse_individu,cp_individu, ville_individu, distance_siege, plan_accees , infos_supplementaire, id_interlocuteur, version) values 
(1, '77257 Larry Alley','75000', 'Masaki-chō', 55, '2930 Bobwhite Hill', 'Progressive dedicated application', 1, 0);
insert into INDIVIDU (num_individu, adresse_individu,cp_individu, ville_individu, distance_siege, plan_accees , infos_supplementaire, id_interlocuteur, version) values 
(2, '582 Lyons Street','75000', 'Srostki', 21, '2117 Jenifer Point', 'Optimized hybrid interface', 2, 0);
insert into INDIVIDU (num_individu, adresse_individu,cp_individu,ville_individu, distance_siege, plan_accees , infos_supplementaire, id_interlocuteur, version) values 
(3, '8897 Ridgeway Point','75000', 'Seres', 78, '2323 Superior Terrace', 'Universal bifurcated function', 3, 0);
insert into INDIVIDU (num_individu, adresse_individu,cp_individu,ville_individu, distance_siege, plan_accees , infos_supplementaire, id_interlocuteur, version) values 
(4, '4 Clove Terrace','75000', 'Lescar', 47, '7 Stone Corner Center', 'Expanded responsive task-force', 4, 0);
insert into INDIVIDU (num_individu, adresse_individu,cp_individu,ville_individu, distance_siege, plan_accees , infos_supplementaire, id_interlocuteur, version) values 
(5, '0 Pleasure Plaza','75000', 'Jinzhou', 27, '63872 David Junction', 'Devolved system-worthy application', 5, 0);


SELECT * FROM INDIVIDU;

#------------------------------------------------------------
# Table: RDV
#------------------------------------------------------------
insert into RDV (id_rdv, date_rdv,heure_debut, heure_fin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, id_interlocuteur, id_type_rdv , idPlanning, version) values 
(1, '20160601','08:30', '22:19', '73 Hoard Circle', 'San Sebastian', 94, null, 1, 1, 1, 0);
insert into RDV (id_rdv, date_rdv,heure_debut, heure_fin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, id_interlocuteur, id_type_rdv , idPlanning, version) values 
(2, '20160304','08:30', '7:48', '14 Sullivan Street', 'Sertânia', 81, null, 2, 2, 2, 0);
insert into RDV (id_rdv, date_rdv,heure_debut, heure_fin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, id_interlocuteur, id_type_rdv , idPlanning, version) values 
(3, '20160326','08:30', '6:54', '3 Doe Crossing Pass', 'Podebłocie', 5, null, 3, 3, 3, 0);
insert into RDV (id_rdv, date_rdv,heure_debut, heure_fin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, id_interlocuteur, id_type_rdv , idPlanning, version) values 
(4, '20160610','08:30', '1:51', '78528 Orin Street', 'Alcoy', 99, null, 4, 4, 4, 0);
insert into RDV (id_rdv, date_rdv,heure_debut, heure_fin, adresseDerogatoire , villeDerogatoire , codeEntreeDerogatoire , infoDerogatoire, id_interlocuteur, id_type_rdv , idPlanning, version) values 
(5, '20160510','08:30', '22:33', '023 Butternut Court', 'Banī Suwayf', 56, null, 5, 5, 5, 0);

SELECT * FROM RDV;

#------------------------------------------------------------
# Table: CONGES
#------------------------------------------------------------
insert into CONGES (numConge, dateDebutConge, dateFinConge, version) values 
(1, '20160427', '20180125', 0);
insert into CONGES (numConge, dateDebutConge, dateFinConge, version) values 
(2, '20160627', '20171220', 0);
insert into CONGES (numConge, dateDebutConge, dateFinConge, version) values 
(3, '20161213', '20171010', 0);
insert into CONGES (numConge, dateDebutConge, dateFinConge, version) values 
(4, '20160519', '20170315', 0);
insert into CONGES (numConge, dateDebutConge, dateFinConge, version) values 
(5, '20161105', '20180107', 0);

SELECT * FROM CONGES;

#------------------------------------------------------------
# Table: CONGES_UTILISATEUR
#------------------------------------------------------------
insert into CONGES_UTILISATEUR (numUtilisateur, numConge, version) values 
(1, 1, 0);
insert into CONGES_UTILISATEUR (numUtilisateur, numConge, version) values 
(1, 2, 0);
insert into CONGES_UTILISATEUR (numUtilisateur, numConge, version) values 
(1, 3, 0);
insert into CONGES_UTILISATEUR (numUtilisateur, numConge, version) values 
(1, 4, 0);
insert into CONGES_UTILISATEUR (numUtilisateur, numConge, version) values 
(1, 5, 0);

SELECT * FROM CONGES_UTILISATEUR;

#------------------------------------------------------------
# Table: TYPE_UTILISATEUR
#------------------------------------------------------------
insert into TYPE_UTILISATEUR (codeTypeUtilisateur , libelleTypeUtilisateur, version) values 
(1, 'administrateur', 0);
insert into TYPE_UTILISATEUR (codeTypeUtilisateur , libelleTypeUtilisateur, version) values 
(2, 'Gestionnaire', 0);
insert into TYPE_UTILISATEUR (codeTypeUtilisateur , libelleTypeUtilisateur, version) values 
(3, 'Commercial', 0);

SELECT * FROM TYPE_UTILISATEUR;

#------------------------------------------------------------
# Table: MAIL
#------------------------------------------------------------
insert into MAIL (numMail , contenuMail, objetMail, numUtilisateur ,  id_interlocuteur, version   ) values 
(1, 'Vous êtes virés', 'sale con', 1, 1, 0);
insert into MAIL (numMail , contenuMail, objetMail, numUtilisateur ,  id_interlocuteur, version   ) values 
(2, 'Je veux ta thune', 'Coucou toi', 2, 2, 0);
insert into MAIL (numMail , contenuMail, objetMail, numUtilisateur ,  id_interlocuteur, version   ) values 
(3, 'Deux employes sont gays', 'probleme', 3, 3, 0);

SELECT * FROM MAIL;

#------------------------------------------------------------
# Table: PLANNING
#------------------------------------------------------------
insert into PLANNING (idPlanning  , numUtilisateur, version) values 
(1, 1, 0);
insert into PLANNING (idPlanning  , numUtilisateur, version) values 
(2, 2, 0);
insert into PLANNING (idPlanning  , numUtilisateur, version) values 
(3, 3, 0);
insert into PLANNING (idPlanning  , numUtilisateur, version) values 
(4, 4, 0);
insert into PLANNING (idPlanning  , numUtilisateur, version) values 
(5, 5, 0);

SELECT * FROM PLANNING;

#------------------------------------------------------------
# Table: PORTEFEUILLE
#------------------------------------------------------------
insert into PORTEFEUILLE (idPortefeuille  , libellePortefeuille, numUtilisateur, version) values 
(1, 'unportefeuille', 1, 0);
insert into PORTEFEUILLE (idPortefeuille  , libellePortefeuille, numUtilisateur, version) values 
(2, 'unportefeuille', 2, 0);
insert into PORTEFEUILLE (idPortefeuille  , libellePortefeuille, numUtilisateur, version) values 
(3, 'unportefeuille', 3, 0);
insert into PORTEFEUILLE (idPortefeuille  , libellePortefeuille, numUtilisateur, version) values 
(4, 'unportefeuille', 4, 0);
insert into PORTEFEUILLE (idPortefeuille  , libellePortefeuille, numUtilisateur, version) values 
(5, 'unportefeuille', 5, 0);

SELECT * FROM PORTEFEUILLE;

#------------------------------------------------------------
# Table: INTERLOCUTEUR_STRUCTURE
#------------------------------------------------------------
insert into INTERLOCUTEUR_STRUCTURE (id_interlocuteur , num_structure, version) values 
(1, 1, 0);, version
insert into INTERLOCUTEUR_STRUCTURE (id_interlocuteur , num_structure, version) values 
(2, 2, 0);
insert into INTERLOCUTEUR_STRUCTURE (id_interlocuteur , num_structure, version) values 
(3, 3, 0);

SELECT * FROM INTERLOCUTEUR_STRUCTURE;

#------------------------------------------------------------
# Table: SUIVRE
#------------------------------------------------------------
insert into SUIVRE (id_rdv  , id_rdv_RDV, version) values 
(2, 1, 0);
insert into SUIVRE (id_rdv  , id_rdv_RDV, version) values 
(3, 2, 0);
insert into SUIVRE (id_rdv  , id_rdv_RDV, version) values 
(4, 3, 0);
insert into SUIVRE (id_rdv  , id_rdv_RDV, version) values 
(5, 4, 0);

SELECT * FROM SUIVRE;
, 0
SET foreign_key_checks = 1;
