using IDemogApp.Views;

namespace IDemogApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();


            //Routing.RegisterRoute(nameof(Views.MainPage), typeof(Views.MainPage));
            
            Routing.RegisterRoute(nameof(AjoutPage), typeof(AjoutPage));

        }
    }
}
