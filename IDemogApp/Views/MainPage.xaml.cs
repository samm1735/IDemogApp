using IDemogApp.ViewModels;

namespace IDemogApp.Views;



/// <summary>
/// 
///     Nom         : ISAAC 
///     Prenom      : Sammuel Ramclief
///     Cours       : C# II
///     Devoir II
///     Description : Application mobile developp�e avec .Net MAUI pour faire de la gestion d�mographique.
///                   Le projet utilise le syst�me de design MVVM.
///                   
///                   Par cons�quent notre folder structure est la suivante.
///                   
///                   Models    |
///                             |--> Personne.cs    // Notre mod�le principal
///                             |--> Constants.cs   // Pour des variables constantes - Mainly used for databse integration
///                   
///                   
///                   Services  |
///                             |--> PersonneDatabase.cs    // D�finition des m�thodes de cr�ation de table, insertion et update de champs.
///                             |--> PersonneService.cs  // Utilis�e pour prendre des donnees depuis la base de donn�es
///                                                             -> puis les envoyer au vieModel de la page principale
///                                                             
///                   ViewModels|
///                             |--> MainPageViewModel.cs    // Utilis�e pour le Binding de Views.MainPage.
///                             |--> AjoutPageViewModel.cs  // Utilis�e pour le Binding de Views.AjoutPage.
///                   
/// 
/// 
///                   Views     |
///                             |--> MainPage.xaml    // La page principale - 
///                                                     -> Utilis�e pour afficher un collection view des personnes de la base de donn�es
///                             |--------> MainPage.xaml.cs //Le code behind de la page principale
///                             |--> AjoutPage.xaml    // La page utilis�e pour ajouter ou modifierles personnes
///                             |--------> AjoutPage.xaml.cs //Le code behind de la page d'ajout de personne  
///                             
///                 Remarque : Nous aurions pu avoir declar� le field pour Models.Personne.Photo comme byte[]
///                            SQLite aurait cr�� cette colomne comme blob
///                            
///                            Cela nous aurait demand� d'avoir une m�thode de conversion byte[] vers image pour affichage avec Image Source 
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