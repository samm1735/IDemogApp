using CommunityToolkit.Mvvm.ComponentModel;
using IDemogApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDemogApp.Services
{
    public class PersonneService : ObservableObject
    {
        

        PersonneDatabase _personneDatabase;
        public PersonneService(PersonneDatabase personneDatabase)
        {
            _personneDatabase = personneDatabase;
        }

        /// <summary>
        /// Cette methode recupere les donnes de la base de donnees
        /// </summary>
        /// <returns>Une liste de Personne</returns>
        public async Task<List<Personne>> LoadPersonnes()
        {

            
            //if(listePersonnes?.Count == 0)
            //{
            //    listePersonnes.Add(new Personne(nom: "Dessalines", prenom: "Jean Jacques", email: "jj@dessalines.com", phone: "50900000000"));
            //    listePersonnes.Add(new Personne(nom: "Petion", prenom: "Alexandre", email: "a@petion.com", phone: "50900000000"));
            //    listePersonnes.Add(new Personne(nom: "Henry", prenom: "Christophe", email: "c@henry.com", phone: "50900000000"));
            //    listePersonnes.Add(new Personne(nom: "Boyer", prenom: "Jean-Pierre", email: "jp@boyer.com", phone: "50900000000"));
            //}


            return await _personneDatabase.GetPersonnesAsync();
        }


    }
}
