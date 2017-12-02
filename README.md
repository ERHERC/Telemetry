# Telemetry
Projet de logiciel pour l'affichage des informations de télémétrie d'une voiture solaire via un arduino ou rasbery pi

## :page_facing_up: Le projet 

### Description:

Ce projet a pour but de connecter une voiture télécommandée à un ordinateur via un *arduino* ou *raspberry pi* et d'envoyer des données de télémétrie (voir Fonctionnalités)

Le projet à été créé pour récupérer des données sur une voiture solaire radiocommandée pour un concours appelé [Les défis solaires](http://www.planete-sciences.org/blogs/defissolaires/)



### Fonctionnalités:

 * Affichage d'un stream vidéo
 * Affichage du pourcentage de charge de la batterie
 * Envoi de commandes Ping
 * Chronomètre intégré
 * Assistant de mise en route (setup wizard)
 * Génération de tableaux au format .csv (comma separated values) [génération d'un .xml]
 * Système de notifications


### Obtenir le projet via la ligne de commande GIT:
```{r, engine='bash', count_lines}
git clone https://github.com/NawakCreations/Telemetry
```

### Prérequis:
Ce projet à été codé avec le `.NET Framework 4.6` , [téléchargez-le](https://github.com/NawakCreations/Telemetry) pour pouvoir compiler et lancer l'exécutable.

Pour éditer le projet , veuillez [télécharger](https://www.visualstudio.com/fr/downloads) Visual Studio (Version 2015 Community ou supérieure)

---

### Technologies tierces et remerciements:

 * [Wait .5 seconds before continuing code VB.net - StackOverflow](https://stackoverflow.com/a/36362504) pour la fonction attendre qui ne bloque pas le logiciel (A céssé de fonctionner)
 * [A Beginner's Tutorial for Understanding Windows Communication Foundation (WCF) - CodeProject](https://www.codeproject.com/Articles/406096/A-beginners-tutorial-for-understanding-Windows) pour le guide d'utilisation des services WCF
 * [A Quick and Dirty WCF Service and Client (Using WCF and Winforms) - CodeProject](https://www.codeproject.com/Articles/18789/A-Quick-and-Dirty-WCF-Service-and-Client-Using-WCF) pour les exemples de code pour l'utilisation de WCF
 * [Disable Close Button[X] in the Vb.Net - CodeProject](https://www.codeproject.com/Questions/354393/Disable-Close-Button-X-in-the-Vb-Net) pour la désactivation du boutton fermer des fenêtres popup

