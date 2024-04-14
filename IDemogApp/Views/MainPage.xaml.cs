using IDemogApp.ViewModels;

namespace IDemogApp.Views;



/// <summary>
/// 
///     Nom         : ISAAC 
///     Prenom      : Sammuel Ramclief
///     Cours       : C# II
///     Devoir II
///     Description : Application mobile developpée avec .Net MAUI pour faire de la gestion démographique.
///                   Le projet utilise le système de design MVVM.
///                   
///                   Par conséquent notre folder structure est la suivante.
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
///                 Remarque : Nous aurions pu avoir declaré le field pour Models.Personne.Photo comme byte[]
///                            SQLite aurait créé cette colomne comme blob
///                            
///                            Cela nous aurait demandé d'avoir une méthode de conversion byte[] vers image pour affichage avec Image Source 
/// 
/// </summary>

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel mainPageViewModel)
	{
        InitializeComponent();
        BindingContext = mainPageViewModel;
    }

}