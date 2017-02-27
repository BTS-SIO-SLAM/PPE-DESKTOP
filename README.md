# PPE-DESKTOP
## Belle-Table Company

## Informations sur le projet
Groupe :  	LHUILLIER, SAILLY, DULONG, DELBE, COUTROT, DUPARC, ROBERTO, CANAVAGGIO 

Nom du projet :  	 GEPEV 

Type de document :  	Cahier des charges  

Version :  	1.3

Référence :  	GPEV-CDC-1.3

Statut du document :  	Livré


### 1. PRÉSENTATION GÉNÉRALE DU PROJET
 

1.1.Pitch

Une application desktop permettant la gestion des rendez-vous et des plannings des commerciaux de l'entreprise BELLETABLE écrite en C# et connectée à une base de donnée SQL.

1.2 Brief

1.2.1.Besoin et contexte

Les commerciaux de Belletable utilisent des solutions différentes d'agendas individuels pour leur rendez-vous avec les clients. Par soucis de sécurité, de centralisation des données et de performance, L'entreprise souhaite acquérir une application qui permettrait :


- La gestion des rendez-vous en respectant les contraintes indiquées par BelleTable (nombre et distance parcourue) et la visualisation de ceux-ci sous forme de planning. 
- L'envoi automatique des notifications aux clients sous forme de mails et/ou SMS.
- La gestion des portefeuilles de clients et leur assignations aux commerciaux.
- La gestion des congés des commerciaux.
- La consultation de statistiques liées à l'utilisation de l'application
- La gestion des utilisateurs

En outre, le planning d'un commercial devra être consultable sur des systèmes embarqués (mobiles, tablettes)

1.2.2 Description de l’application

L'utilisateur se verra attribué aupparavant un couple login/mdp pour la connection à l'application.
Selon les droits, le planning du commercial ou la liste des commerciaux ou la liste des utilisateurs et leurs types seront affichés à l'acceuil de l'application et des boutons situés en haut de page permettront l'accès aux fonctionnalités respectives des utilisateurs :


- Création des ren3dez-vous avec les clients qui se trouvent dans les portefeuilles.
- Consulation des plannings de rendez-vous et leur gestion (ajouter/modifier/supprimer)
- Consultation et/ou impression en pdf d'un récapitulatif de rendez-vous avec les informations nécéssaires (accès, commentaire, etc)
- Gestion des périodes d'indisponibilité des commerciaux.
- Consultation des portefeuilles de clients.
- Visualisation des e-mails envoyés aux clients aux noms des commerciaux.
- Attribution des portefeuilles clients aux commerciaux et leur gestion (ajouter/modifier/supprimer).
- Gestion de la liste des utilisateurs (ajouter/modifier/supprimer)
- Consultation de l'historique des connexions à l'application ainsi que d'outils statistiques à définir.


1.2.3 Utilisateurs

Trois types d'utilisateurs pourront se connecter à l'application :


- Les commerciaux qui pourront :


- Créer des rendez-vous avec les clients qui se trouvent dans leurs portefeuilles respectifs.
- Consulter leurs plannings de rendez-vous et assurer leur gestion (ajouter/modifier/supprimer)
- Consulter et/ou imprimer en pdf un récapitulatif du rendez-vous avec les informations nécéssaires (accès, commentaire, etc)
- Poser des périodes d'indisponibilité.
- Consulter leurs portefeuilles de clients.
- Visualiser les e-mails envoyés aux clients en leur noms.


- Les gestionnaires qui auront les mêmes droits que les commerciaux mais qui pourront en plus :

- Attribuer les portefeuilles clients aux commerciaux et assurer leur gestion (ajouter/modifier/supprimer).
- Gérer les commerciaux (ajouter/modifier/supprimer)


- Les administrateurs qui cumuleront les droits des commerciaux et des gestionnaires mais qui pourront aussi :

- Gérer la liste des utilisateurs (ajouter/modifier/supprimer)
- Consulter l'historique des connexions à l'application
	

1.2.4 Fonctionnalités principales

- Se connecter à l'application grâce à un login et un mot de passe
- Fonction mot de passe perdu 
- Création des rendez-vous avec les clients qui se trouvent dans les portefeuilles.
- Consulation des plannings de rendez-vous et leur gestion (ajouter/modifier/supprimer)
- Consultation et/ou impression pdf d'un récapitulatif de rendez-vous avec les informations nécéssaires (accès, commentaire, etc)
- Gestion des périodes d'indisponibilité des commerciaux.
- Consultation des portefeuilles de clients.
- Visualisation des e-mails envoyés aux clients aux noms des commerciaux.
- Attribution des portefeuilles clients aux commerciaux et leur gestion (ajouter/modifier/supprimer).
- Gestion de la liste des utilisateurs (ajouter/modifier/supprimer)
- Consultation de l'historique des connexions à l'application ainsi que d'outils statistiques à définir.

  
### 2. LES EXIGENCES FONCTIONNELLES
 
2.1 L’arborescence
 
2.2 Accès à l’application

- Première interface : login et password : L'utilisateur rentre ses identifiants qui sont comparés à la base et l'application l'authentifie selon son type et charge les fonctionnalités adéquates.
- La saisie du mot de passe sera hachée.
- Après 6 tentatives d'authentification érronés, l'administrateur sera informé et une redirection sur l'interface "mot de passe oublié" sera effectuée. 
- Possibilité de récupérer un mot de passe perdu par un bouton "mot de passe oublié", qui chargera une interface ou l'utilisateur saisira son adresse e-mail pour changer de mot de passe.
 
2.3 Accueil
 
L'acceuil sera différent selon le type d'utilisateur :


- Les commerciaux auront la vue directe sur leur plannings et auront la possibilié via des boutons de poser leurs périodes d'indisponibilités, de consulter leurs portefeuilles clients, créer des rendez-vous et générer les fichiers pdf de leurs prochains rendez-vous.

- Les gestionnaires auront accès à une double liste commerciaux/portefeuilles clients qui affichera le contenu du portefeuille client pour un commercial séléctionné. D'ici ils auront la possibilité d'effectuer les opérations de gestion nécéssaires sur les commerciaux, les clients et les portefeuilles. En cliquant sur un onglet "commercial", le gestionnaire pourra consulter la liste des commerciaux et en cliquant sur l'un d'eux effectuer des opérations en son nom.

- Les administrateurs auront une vue sur la liste des utilisateurs et auront la possibilité d'effectuer des opérations d'ajout, de modification et de supression. De plus, une fenetre affichera la liste des logs à l'application avec l'utilisateur concerné, la date et l'heure. En cliquant sur un onglet "commercial", le gestionnaire pourra consulter la liste des commerciaux et en cliquant sur l'un d'eux effectuer des opérations en son nom. En cliquant sur un onglet "gestionnaire", il pourra consulter la vue gestionnaires et effectuer des opérations d'un gestionnaire.

2.4 Commerciaux

2.4.1 Planning des commerciaux

L'application affichera le planning respectif des rendez-vous des commerciaux avec la possibilité de générer un fichier pdf de chaque rendez-vous comportant toutes les informations relatives à celui-ci ainsi qu'un plan d'accès.

2.4.2 Periodes d'indisponibilité

Le commercial disposera d'un calendrier ou il pourra signaler ses périodes d'indisponibilités.

2.4.3 Portefeuille client

Le commercial aura accès à la liste des clients de son portefeuille et il pourra consulter en un clic les informations de chacun de ces derniers.

2.4.4 Affichage client

Toutes les informations relatives au client seront affichées, ainsi que les derniers e-mails envoyés sous forme de liste.


2.4.5 Affichage d'e-mail

Simple affichage d'e-mail avec destinataire, objet et contenu du mail.

2.4.6 Création de rendez-vous

Formulaire de création de rendez vous avec chargement de la liste des clients du portefeuille du commercial qui comprendra le type du rendez-vous, la date du rendez-vous, l'heure de début, l'heure de fin ainsi qu'une option qui permettra de spécifier si besoin un lieu dérogatoire. 

2.4.7 Génération PDF d'un rendez-vous

Simple génération en pdf des informations d'un rendez-vous qui comprendra un plan d'accès.

2.5 Gestionnaires

Les gestionnaires auront accès à tous leurs outils sur l'accueil de l'application et pourront utiliser les outils des commerciaux en selectionnant l'un d'eux dans la liste de l'onglet "Commercial".
  
2.6 Administrateurs

Les administrateurs auront accès à leurs outils de gestion des utilisateurs sur l'accueil de l'application et pourront utiliser les outils des commerciaux en selectionnant l'un d'eux dans la liste de l'onglet "Commercial" et ceux des gestionnaires en cliquant sur l'onglet "Gestionnaire".
    
2.6.1 Outils statistiques

// TODO à définir

2.7 Documentation accessible depuis l'application

Un bouton "Aide" sera accessible sur chaque page de l'application dans le coin haut droite et délivrera une documentation pdf en fonction des droits des utilisateurs.
 

### 3. PRÉCONISATIONS GÉNÉRALES
 

3.1 Charte graphique et navigation

•	L'application devra être responsive pour tablettes et téléphones.
•	L'application doit être intuitive et simple d'utilisation.
•	L’accès aux informations et aux outils doit être rapide.


3.2 Développement

•	Il a été choisi de développer en C# sous VisualStudio et d’utiliser une base de donnée SQLserver ou MySQL d’après les compétences des développeurs du projet.
•	Le C# est un langage de programmation commercialisé par Microsoft utilisé pour développer des applications Web et de bureau. Tous les développeurs possèdent des licences VisualStudio, l’environnement de de développement C#.
•	MySQL  est un système de gestion de bases de données relationnelles (SGBDR). Il est distribué sous une double licence GPL et propriétaire. Il fait partie des logiciels de gestion de base de données les plus utilisés au monde.
•	Microsoft SQL Server est un système de gestion de base de données (abrégé en SGBD) développé et commercialisé par la société Microsoft. Il fonctionne sous les OS Windows, Linux, Mac OS (non natif)

Le code devra être le plus claire et simple possible.
Développer en suivant les bonnes pratiques et minimiser l'utilisation de Library externes sera minimisé et les bonnes pratiques seront une priorité.
Le développement est collaboratif : Le projet est partagé sur l’outil GitHub, ainsi chaque développeur peut fournir du travail et le remonter sur un dossier commun à tous.


3.3 Matériels et compétences

•	Connaissances en C#, Visual Studio Windows Forms et langage SQL.
•	Environnement Windows ou Mac récent (Vista min.)
•	Un serveur avec l'OS Windows Server 2012 comportant MySQl et SQLserver ouvert à internet.
•	Visual Studio (min. 2010)


3.4 Sécurité

•	Toutes les requêtes devront être préparées pour éviter les injections SQL.
•	Une offuscation du code peut être abordée.
•	Chaque accès devra s'effectuer par mot de passe haché en SHA-256 OU MD5 avec salage.
•	Les utilisateurs possèdent différents types de droits.
•	Les administrateurs possèdent une vue sur les actions effectuées en base de données.
•	Un Pentest peut être effectué une fois l'application terminée.
•	Historique des connexions.
•	Fonction mot de passe brûlé après 6 tentatives infructueuses.


### 4. DÉROULEMENT DU PROJET


4.1 Phases du projet

Le projet démarrera après la rédaction du cahier des charges.
L'étape suivante consiste à répartir les différentes tâches, qui composent le projet, avec chacun des participants, qui démarreront sur une même base. 
Suite à la conception (réalisation) de ces tâches, chaque développeur validera le travail effectué par tous les membres du groupe de travail. 
Ensuite, la phase d'assemblage des parties, préalablement approuvées par les participants, devra se faire avec une possible différenciation entre participants suivant les opinions de chacun (finition individuelle).
Chaque participant devra alors effectuer les tests et les éventuelles corrections nécessaires.
La dernière étape est le déploiement du projet sur un serveur ainsi qu’un test final de production. 
L’étape additionnelle facultative sera d’ajouter des améliorations à l’application.


4.1.1 Conception

•	Rédaction du cahier des charges.
•	Création du Modèle conceptuel de données
•	Création du Schéma UML
•	Répartition et assignation des différentes tâches du projet.


4.1.2 Réalisation

•	Tous les développeurs partent sur une même base.
•	Développement de l’interface et des fonctionnalités.
•	Assemblage des différentes parties.



4.1.3 Recette

Phase de test permettant
Vérification des fonctionnalités, de l’algorithme, de l’interface utilisateurs (ergonomie)


4.1.4 Déploiement

Basculer de la réalisation à la production, avec des procédures de retour en arrière, des tests de validité de comportement de l’application et l’identification des risques possibles.


### 5. MODALITÉS


5.1 Réception des résultats des prestations


5.2. Livrables


5.3 Recettage 

 Cela consiste à effectuer une check List pour le point ergonomique et une pour le point technique afin de valider une version définitive et durable de l'application produite.
 
 
5.3.1 Au niveau technique 

Check List :
•	L’application fonctionne-t-elle ? Tout le cahier des charges est-il mis en place et fonctionnel ?
•	L’application est-elle adaptée à son environnement de déploiement, ici un PC sous Windows ?
•	L’application est-elle fonctionnelle sur d'autres versions de Windows que celle utilisée pour la développer ?
•	L’application comporte-elle une documentation technique ?


5.3.2 Au niveau ergonomique 

Check List :
•	L’application est-elle facilement compréhensible pour une prise en mains rapide ?
•	L’application permet-elle un accès efficace aux données ?
•	L’application est-elle visuellement agréable ?
•	La fenêtre de l'application est-elle redimensionnable (le contenu y compris) ?

## Diffusion	

LHUILLIER JESSIE  lhuillier14@gmail.com  Dév.	   

DUPARC ALEXANDRE duparc.alexandre94@gmail.com Dév.
 
ROBERTO BENEDICTE benedicte.roberto@gmail.com Dév. 

DULONG RAPHAEL 	raphael.dulong@gmail.com Dév.
 
DELBE SEBASTIEN  sebas9241@hotmail.fr Dév. 

COUTROT SYLVAIN	sylvain.coutrot@hotmail.fr Dév.

CANAVAGGIO LORENZO lorenzo.canavaggio@laposte.net Dév.

SAILLY AXELLE saillyaxelle@hotmail.fr Dév.
