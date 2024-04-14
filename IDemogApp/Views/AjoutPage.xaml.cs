using IDemogApp.ViewModels;

namespace IDemogApp.Views;

public partial class AjoutPage : ContentPage
{
	public AjoutPage(AjoutPageViewModel ajoutPageViewModel)
	{
		InitializeComponent();

		BindingContext = ajoutPageViewModel;
	}
}