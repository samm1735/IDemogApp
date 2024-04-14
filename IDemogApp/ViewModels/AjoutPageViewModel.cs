using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using IDemogApp.Models;
using IDemogApp.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDemogApp.ViewModels
{
    [QueryProperty("UnePersonne", "UnePersonne")]
    public partial class AjoutPageViewModel : ObservableObject
    {
        [ObservableProperty]
        Personne unePersonne;

        private MainPageViewModel _modelViewPersonnesPointer {  get; set; }
        private readonly PersonneDatabase _personneDatabase;

        public AjoutPageViewModel(PersonneDatabase personneDatabase, MainPageViewModel modelViewPersonnesPointer)
        {
            _personneDatabase = personneDatabase;
            _modelViewPersonnesPointer = modelViewPersonnesPointer;
        }

        /// <summary>
        /// Nous permet de capturer des photos avec la camera de notre appareil
        /// </summary>
        /// <returns></returns>
        [RelayCommand]
        private async Task TakePicture()
        {
            if (MediaPicker.Default.IsCaptureSupported)
            {
                FileResult photo = await MediaPicker.Default.CapturePhotoAsync();
                
                if (photo != null)
                {
                    UnePersonne.Photo = photo.FullPath;
                }
            }
        }

        /// <summary>
        /// Insert ou Update personne selon si elle existe deja ou pas
        /// </summary>
        /// <returns></returns>
        [RelayCommand]
        private async Task Sauvegarder()
        {
            if(UnePersonne != null)
            {
                if(UnePersonne.id == 0)
                {
                    try
                    {
                        Personne personne = new Personne(
                            nom: UnePersonne.Nom,
                            prenom: UnePersonne.Prenom,
                            email: UnePersonne.Email,
                            phone: UnePersonne.Phone,
                            photo: UnePersonne.Photo,
                            ddn: UnePersonne.Ddn
                            );




                        await _personneDatabase.SavePersonneAsync( personne );
                        _modelViewPersonnesPointer.GetData();

                        // Clean the Entries
                        UnePersonne.Nom = string.Empty;
                        UnePersonne.Prenom = string.Empty;
                        UnePersonne.Email = string.Empty;
                        UnePersonne.Phone = string.Empty;

                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }
                }
                else
                {
                    await _personneDatabase.SavePersonneAsync(UnePersonne);
                    _modelViewPersonnesPointer.GetData();
                }
            }
            await Shell.Current.GoToAsync("..");
        }
    }
}
