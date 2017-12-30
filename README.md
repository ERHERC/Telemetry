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
 * [Live Video from Raspberry Pi to .NET - **CodeProject**](https://www.codeproject.com/Articles/810004/Live-Video-from-Raspberry-Pi-to-NET) pour le **stream vidéo Voiture -> PC**
 * [Control Raspberry Pi with another Program - **Raspberry Forums**](https://www.raspberrypi.org/forums/viewtopic.php?t=34019) pour la **communication .NET <--> Hardware**
 * [Package Manager Console - **MSDN Documentation**](https://docs.microsoft.com/en-us/nuget/tools/package-manager-console) pour l'utilisation du **gestionnaire de packages**
 * [Storing referenced Dlls in visual studio solution folder - **StackOverflow**](https://stackoverflow.com/questions/4971807/storing-referenced-dlls-in-visual-studio-solution-folder) pour l'utilisation du dossier ***Solution Items*** et l'ajout de références (.dll) en tant que fichier de la solution
 * [Equivalent of static classes is VB.Net - **AndyFrench.Info**](http://www.andyfrench.info/2010/08/equivalent-of-static-classes-is-vbnet.html) pour l'utilisation des classes partagées
 * [Visual Studio 2015: How to manage resources in a shared project? - **MSDN Forums**](https://social.msdn.microsoft.com/Forums/vstudio/en-US/f5600bb4-b334-4893-a2ed-b21a2b1b5fc9/visual-studio-2015-how-to-manage-resources-in-a-shared-project?forum=wpdevelop) pour l'utilisation des ***Shared projects*** (projets partagés) en VisualBasic
 * [Convert String to System.IO.Stream [duplicate] - **StackOverflow**](https://stackoverflow.com/questions/8047064/convert-string-to-system-io-stream) pour la conversion du type **String** vers **MemoryStream** (notamment utilisé dans le système de thèmes)
 * [Is it possible to access resources from a different project using the designer in WinForms? - **StackOverflow**](https://stackoverflow.com/questions/14904170/is-it-possible-to-access-resources-from-a-different-project-using-the-designer-i) pour le **stockage de resources dans un autre projet** (notamment utilisé dans le système de thèmes)
 * [Krypton WinForms components for .NET (ComponentFactory/Krypton/2013) - **GitHub**](https://github.com/ComponentFactory/Krypton/tree/2013) pour les controles d'interface graphique **Krypton Toolkit**
 * [Using Shell Progress Dialogs in Windows Forms Applications - **brad-smith.info**](https://www.brad-smith.info/blog/archives/523) pour l'utilisation de la **fenêtre de progression par défaut de Windows (celle de la copie de fichiers)**
 * [How can I loop through all sub folder of FolderA and execute o.bat in each when I execute a.bat? - **SuperUser**](https://superuser.com/questions/323775/how-can-i-loop-through-all-sub-folder-of-foldera-and-execute-o-bat-in-each-when) pour l'utilisation de la commande **FOR** (notamment utilisé dans CleanBuild.cmd)
 * [How to delete a folder with all contents using a bat file in windows? - **StackOverflow**](https://stackoverflow.com/questions/7331056/how-to-delete-a-folder-with-all-contents-using-a-bat-file-in-windows) pour l'utilisation de la commande **RMDIR** (notamment utilisé dans CleanBuild.cmd)
 * [How to determine if a type is in the inheritance hierarchy - **StackOverflow**](https://stackoverflow.com/questions/16859728/how-to-determine-if-a-type-is-in-the-inheritance-hierarchy) et [How to see if a type implements an interface? - **StackOverflow**](https://stackoverflow.com/questions/4015761/how-to-see-if-a-type-implements-an-interface) pour la **détection d'héritage de classe** (pour les tests unitaires)
 * [How to use .Where in generic list - **StackOverflow**](https://stackoverflow.com/questions/4197899/how-to-use-where-in-generic-list) pour la documentation sur l'utilisation de la fonction **Where()** en VisualBasic
 * [Créer une (très simple) application modulable en .Net - **Etienne Baudoux - BLOG**](http://blog.velersoftware.com/2012/09/create-a-very-simple-modular-application-in-net/) pour l'utilisation de **System.Reflection**
 * [How can I get all classes within a namespace? - **StackOverflow**](https://stackoverflow.com/questions/949246/how-can-i-get-all-classes-within-a-namespace) pour le **listage au runtime des classes d'un namespace héritant d'un type spécifié**
 * [How to get the list of properties of a class? - **StackOverflow**](https://stackoverflow.com/questions/737151/how-to-get-the-list-of-properties-of-a-class?rq=1) pour le **listage au runtime des propriétés d'une classe donnée**

### Codes secrets:

Voici des codes à entrer dans la fenêtre du logiciel (à taper quand elle est active et assez rapidement) :smile:

Code|Action
----|------
*Haut Haut Bas Bas Gauche Droite Gauche Droite B A* |Running in the 90's
*N A N I* |Omae Wa Mou Shindeiru ... **NANI ?!**
*G H O S T* |Le logiciel devient transparent pendant 2 secondes
*A H* ou *D E N I S* |Le "AH !" de denis Brogniart
*R O S E S   A R E   R E D* | Juste un petit poème ...