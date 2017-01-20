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
- La création des rendez-vous en reespectant les contraintes de nombre et de distance et la visualisation de ceux-ci sous forme de planning 
- L'envoi des notifications aux clients
- L'assignation des clients aux différents commerciaux
- La gestion des commerciaux et de leurs congés

En outre, l'application devra être consultable sur des systèmes embarqués (mobiles, tablettes)

1.2.2 Description de l’application

L'utilisateur se verra attribué aupparavant un couple login/mdp pour la connection à l'application. 
Le planning du commercial sera affiché à l'acceuil de l'application pour une information rapide sur les prochains rendez-vous. De là il aura accès à la création d'un rendez-vous, si son statut le permet, ainsi qu'a la visualisation des e-mails et/ou sms envoyés en son nom aux clients.
Il pourra de plus modifer certaines informations concernant les clients dont il a charge, mais aussi indiquer ses jours d'indisponibilité ou de congés.
Un administrateur aura la visualisation complete des plannings de chaque commercial ainsi que leur fonctionnalités et aura la possiblité de gérer l'assignation des commerciaux et de leur clients. Outils statistiques ?

1.2.3 Utilisateurs

1.2.4 Fonctionnalités principales

  
### 2. LES EXIGENCES FONCTIONNELLES
 
2.1 L’arborescence
 
2.2 Accès à l’application 
 
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
    L'application devra être 100% responsive pour tablettes et téléphonnes.
    
    L'application doit être intuitive et simple d'utilisattion
    
 
3.2 Développement
    
    Le code devra être le plus claire et simple possible.
    
    Minimiser le junk code.
    
    Chaque développeur se vera attribuer une charge de développement précise.
 
3.3 Matériels et compétences
    
    Deux serveurs WEB un pouvant intégré MySQL l'autre SQLserver.
    
    Une virtualisation des serveurs WEB peut avoir lieu pour mettre en place un environement de PREPROD et PROD.
    
    PC de développement.

3.4 Sécurité
    Toute les requêtes devront être des requêtes préparées. 
   
    Une obfuscation du code peut être abordée.
   
    Chaque accès devra s'éffectuer par mot de passe hacher en SHA-256() OU MD5().
   
    Chaque droit des utilisateurs doit être clairement délimité.
   
    Les administrateurs ont une vue sur les actions éfféctuées sur les données.
   
    Un pentest peut être éfféctué une fois l'application terminée.
   
    Historique des connexions.
   
    Fonction mot de passe brûlé après 6 tentativers infructueuses.

3.5 Mises en ligne
 
### 4. DÉROULEMENT DU PROJET
 
4.1 Phases du projet
 
4.1.1 Conception

4.1.2 Réalisation

4.1.3 Recette

4.1.4 Déploiement


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
