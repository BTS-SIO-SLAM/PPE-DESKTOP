# PPE-DESKTOP
## Belle-Table Company

## Informations sur le projet
Groupe :  	LHUILLIER, SAILLY, DULONG, DELBE, COUTROT, DUPARC, ROBERTO, CANAVAGGIO 

Nom du projet :  	BTAD ? GPE ? GEPEV ? GEPLEV ?

Type de document :  	Cahier des charges  

Version :  	2.0

Référence :  	BTAD-CDC-0.0

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


- Création des rendez-vous avec les clients qui se trouvent dans les portefeuilles.
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
 
2.4 Planning des commerciaux

2.5 Gestion des clients

2.6 Création d’un rendez-vous
 
2.7 Visualisation des e-mails
    Chaque mail sera rédiger selon l'interlocuteur avec son nom, son prénom ou le nom de son organisation et la nature du rendez-vous.
    
2.8 Gestion des utilisateurs
    Pour la gestion des utilisateurs, on créera une classe "Utilisateur" avec tous les informations nécessaires qui nous permettra d'indentifier chaque utilisateur de l'application.
    
2.9 Statistiques

2.10 Documentation accessible depuis l'application
 

### 3. PRÉCONISATIONS GÉNÉRALES
 
3.1 Charte graphique et navigation
    
    - L'application devra être 100% responsive pour tablettes et téléphonnes.
    
    - L'application doit être intuitive et simple d'utilisattion
    
 
3.2 Développement
    
    - Le code devra être le plus claire et simple possible.
    
    - Minimiser le junk code.
    
    - Chaque développeur se vera attribuer une charge de développement précise.
 
3.3 Matériels et compétences
    
    - Un Windows Server 2012 comportant MySQl et SQLserver.
    
    - Une virtualisation des serveurs WEB peut avoir lieu pour mettre en place un environement de PREPROD et PROD (apache virtualisation).
    
    - PC pouvant faire fonctionner visualStudio.

3.4 Sécurité
    - Toute les requêtes devront être des requêtes préparées. 
   
    - Une obfuscation du code peut être abordée.
   
    - Chaque accès devra s'éffectuer par mot de passe hacher en SHA-256() OU MD5().
   
    - Chaque droit des utilisateurs doit être clairement délimité.
   
    - Les administrateurs ont une vue sur les actions éfféctuées sur les données.
   
    - Un pentest peut être éfféctué une fois l'application terminée.
   
    - Historique des connexions.
   
    - Fonction mot de passe brûlé après 6 tentativers infructueuses.

 
### 4. DÉROULEMENT DU PROJET
 
4.1 Phases du projet
 
4.1.1 Conception

4.1.2 Réalisation

4.1.3 Recette

Phase de test permettant

Vérification des fonctionnalités, de l’algorithme, de l’interface utilisateurs (ergonomie)

4.1.4 Déploiement

Basculer de la réalisation à la production, avec des procédures de retour en arrière, les tests de validité de comportement de l’application avec l’identification des risques possibles.

4.1.5 Exploitation // a assigner --> Lorenzo


### 5. MODALITÉS
 
5.1 Réception des résultats des prestations
                                                                                   
5.2. Livrables

5.3 Recettage
-> Cela consiste à effectuer une check list pour le point ergonomique et une pour le point technique afin de valider une version définitive et durable de l'application produite.
 
5.3.1 Au niveau technique
-> Check List :
 - l'application fonctionne t'elle ? Tout le cahier des charges est-il mis en place et fonctionnel ?
 - l'application est-elle adaptée à son environnement de déploiement, ici un PC sous windows ?
 - l'application est-elle fonctionnelle sur d'autres versions de windows que celle utilisée pour la développer ?
 - l'application comporte-elle une documentation technique ?

5.3.2 Au niveau ergonomique
-> Check List :
 - l'application est-elle facilement compréhensible pour une prise en mains rapide ?
 - l'application permet-elle un accès efficace aux données ?
 - l'application est-elle visuellement agréable ?
 - la fenêtre de l'application est-elle redimensionnable (le contenu y compris) ?

## Diffusion	   
LHUILLIER JESSIE  lhuillier14@gmail.com  Dév.	   

DUPARC ALEXANDRE duparc.alexandre94@gmail.com Dév.
 
ROBERTO BENEDICTE benedicte.roberto@gmail.com Dév. 

DULONG RAPHAEL 	raphael.dulong@gmail.com Dév.
 
DELBE SEBASTIEN  sebas9241@hotmail.fr Dév. 

COUTROT SYLVAIN	sylvain.coutrot@hotmail.fr Dév.

CANAVAGGIO LORENZO lorenzo.canavaggio@laposte.net Dév.

SAILLY AXELLE saillyaxelle@hotmail.fr Dév.

Historique	 des révisions du document
  
0.0.0	16/01/2017	CANAVAGGIO	Initialisation
0.1.1	17/01/2017	DULONG	   	Mise en forme, déploiement sur github
0.1.2	17/01/2017	SAILLY	   	Corrections mineures
0.1.3 18/01/2017	SAILLY	   	Remplissage de la partie "Recettage"
0.1.3 20/01/2017 ROBERTO    Remplissage de la partie "Visualisation des e-mails" et "Gestion des utilisateurs"
0.1.4 19/01/2017 CANAVAGGIO Remplissage de ma partie.
