# Devoir II - Application mobile developpée avec .Net MAUI pour faire de la gestion démographique.
### Cours
- C# II
  
## Nom et prénom
- ISAAC Sammuel Ramclief

## App Preview

### Ajout de personne
<img src="https://github.com/samm1735/IDemogApp/blob/main/Media_240414_165343.gif" alt="App preview" width="200" height="350">

### Modification de personne
<img src="https://github.com/samm1735/IDemogApp/blob/main/Media_240414_165859.gif" alt="App preview" width="200" height="350">


## Description
Application mobile developpée avec .Net MAUI pour faire de la gestion démographique.

Le projet utilise le système de design MVVM.
Par conséquent notre folder structure est la suivante.

```csharp
///                   
///                   Models    |
///                             |--> Personne.cs    // Notre modèle principal
///                             |--> Constants.cs   // Pour des variables constantes - Mainly used for databse integration
///                   
///                   
///                   Services  |
///                             |--> PersonneDatabase.cs    // Définition des méthodes de création de table, insertion et update de champs.
///                             |--> PersonneService.cs  // Utilisée pour prendre des donnees depuis la base de données
///                                                             -> puis les envoyer au vieModel de la page principale
///                                                             
///                   ViewModels|
///                             |--> MainPageViewModel.cs    // Utilisée pour le Binding de Views.MainPage.
///                             |--> AjoutPageViewModel.cs  // Utilisée pour le Binding de Views.AjoutPage.
///                   
/// 
/// 
///                   Views     |
///                             |--> MainPage.xaml    // La page principale - 
///                                                     -> Utilisée pour afficher un collection view des personnes de la base de données
///                             |--------> MainPage.xaml.cs //Le code behind de la page principale
///                             |--> AjoutPage.xaml    // La page utilisée pour ajouter ou modifierles personnes
///                             |--------> AjoutPage.xaml.cs //Le code behind de la page d'ajout de personne 
///
```                         

## Nuget Packages utilisés
- CommunityToolkit.mvvm
- CommunityToolkit.maui
- sqlite-net-pcl
- SQLitePCLRaw.bundle_green



