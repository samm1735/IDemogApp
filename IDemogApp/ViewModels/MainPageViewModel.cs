using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IDemogApp.Models;
using IDemogApp.Services;
using IDemogApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDemogApp.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        private readonly PersonneService _personneService;

        [ObservableProperty]
        public ObservableCollection<Personne> modelViewPersonnes = new();
        public MainPageViewModel(PersonneService personneService)
        {
            _personneService = personneService;
            
            GetData();
        }

        public async void GetData()
        {
            //TO-DO : ...
            List<Personne> temp = await _personneService.LoadPersonnes();

            if (ModelViewPersonnes.Count > 0)
                ModelViewPersonnes.Clear();

            foreach (Personne personne in temp)
            {
                ModelViewPersonnes.Add(personne);
            }
            OnPropertyChanged(nameof(ModelViewPersonnes));

        }



        
        /// <summary>
        /// Methode pour ajouter une nouvelle personne
        /// </summary>
        /// <returns></returns>
        [RelayCommand]

        private async Task EntreNouvellePersonne()
        {
            Personne personne = new();

            var parameters = new Dictionary<string, object>
            {
                {"UnePersonne", personne}
            };

            await Shell.Current.GoToAsync(nameof(AjoutPage), true, parameters);
        }


        /// <summary>
        /// Methode pour modifier une personne existante
        /// </summary>
        /// <param name="personne"></param>
        /// <returns></returns>
        [RelayCommand]
        private async Task EditPersonne(Personne personne)
        {
            

            var parameters = new Dictionary<string, object>
            {
                {"UnePersonne", personne}
            };

            await Shell.Current.GoToAsync(nameof(AjoutPage), true, parameters);
        }


    }
}
