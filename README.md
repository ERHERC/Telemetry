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

 * [Wait .5 seconds before continuing code VB.net - **StackOverflow**](https://stackoverflow.com/a/36362504) pour la fonction attendre qui ne bloque pas le logiciel (A céssé de fonctionner)
 * [A Beginner's Tutorial for Understanding Windows Communication Foundation (WCF) - **CodeProject**](https://www.codeproject.com/Articles/406096/A-beginners-tutorial-for-understanding-Windows) pour le guide d'utilisation des services WCF
 * [A Quick and Dirty WCF Service and Client (Using WCF and Winforms) - **CodeProject**](https://www.codeproject.com/Articles/18789/A-Quick-and-Dirty-WCF-Service-and-Client-Using-WCF) pour les exemples de code pour l'utilisation de WCF
 * [Disable Close Button[X] in the Vb.Net - **CodeProject**](https://www.codeproject.com/Questions/354393/Disable-Close-Button-X-in-the-Vb-Net) pour la désactivation du boutton fermer des fenêtres popup
 * [How to detect arrow keys in vb.net? - **MSDN Forums**](https://social.msdn.microsoft.com/Forums/windows/en-US/ffeeea42-f6ba-420f-827e-74879fd29b26/how-to-detect-arrow-keys-in-vbnet?forum=winforms) pour la capture des touches de navigation dans la fenêtre 
 * [TableLayoutPanel resize column width at runtime, ColumnStyles collection isn't updated - **MSDN Forums**](https://social.msdn.microsoft.com/Forums/en-US/fc62c7c9-2a3f-4944-ac0d-39b088cda63b/tablelayoutpanel-resize-column-width-at-runtime-columnstyles-collection-isnt-updated?forum=winforms) pour la modification des colones dans les table layout panels lors de l'exécution
 * [Live Video from Raspberry Pi to .NET - **CodeProject**](https://www.codeproject.com/Articles/810004/Live-Video-from-Raspberry-Pi-to-NET) pour le stream vidéo Voiture -> PC
 * [Control Raspberry Pi with another Program - **Raspberry Forums**](https://www.raspberrypi.org/forums/viewtopic.php?t=34019) pour la communication .NET <--> Hardware
 * [Package Manager Console - **MSDN Documentation**](https://docs.microsoft.com/en-us/nuget/tools/package-manager-console) pour l'utilisation du gestionnaire de packages
 * [Storing referenced Dlls in visual studio solution folder - **StackOverflow**](https://stackoverflow.com/questions/4971807/storing-referenced-dlls-in-visual-studio-solution-folder) pour l'utilisation du dossier 'Solution Items' et l'ajout de références (.dll) en tant que fichier de la solution
 * [Equivalent of static classes is VB.Net - **AndyFrench.Info**](http://www.andyfrench.info/2010/08/equivalent-of-static-classes-is-vbnet.html) pour l'utilisation des classes partagées
 * [Visual Studio 2015: How to manage resources in a shared project? - **MSDN Forums**](https://social.msdn.microsoft.com/Forums/vstudio/en-US/f5600bb4-b334-4893-a2ed-b21a2b1b5fc9/visual-studio-2015-how-to-manage-resources-in-a-shared-project?forum=wpdevelop) pour l'utilisation des 'Shared projects' (projets partagés) en VisualBasic
 * [Convert String to System.IO.Stream [duplicate] - **StackOverflow**](https://stackoverflow.com/questions/8047064/convert-string-to-system-io-stream) pour la conversion du type String vers MemoryStream (notamment utilisé dans le système de thèmes)
 * [Is it possible to access resources from a different project using the designer in WinForms? - **StackOverflow**](https://stackoverflow.com/questions/14904170/is-it-possible-to-access-resources-from-a-different-project-using-the-designer-i) pour le stockage de resources dans un autre projet (notamment utilisé dans le système de thèmes)
### Codes secrets:

Voici des codes à entrer dans la fenêtre du logiciel (à taper quand elle est active et assez rapidement)

Code|Action
----|------
*Haut Haut Bas Bas Gauche Droite Gauche Droite B A* |Running in the 90's
*N A N I* |Omae Wa Mou Shindeiru ... **NANI ?!**
*G H O S T* |Le logiciel devient transparent pendant 2 secondes
*A H* ou *D E N I S* |Le "AH !" de denis Brogniart
