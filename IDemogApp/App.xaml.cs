using IDemogApp.Services;
using IDemogApp.ViewModels;
using IDemogApp.Views;
namespace IDemogApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            
        }

       
    }
}
