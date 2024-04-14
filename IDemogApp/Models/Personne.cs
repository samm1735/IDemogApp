using CommunityToolkit.Mvvm.ComponentModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDemogApp.Models
{
    public partial class Personne : ObservableObject
    {

        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [ObservableProperty]
        public string nom;

        [ObservableProperty]
        public string prenom;

        [ObservableProperty]
        public string ddn;

        [ObservableProperty]
        public string email;

        [ObservableProperty]
        public string phone;

        [ObservableProperty]
        public string photo;

        
        //public Image photo { get; set; }

        public Personne() { }
        public Personne(string nom, string prenom, string ddn, string email, string phone, string photo)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.ddn = ddn;
            this.email = email;
            this.phone = phone;
            this.photo = photo;
        }
        public Personne(string nom, string prenom, string email, string phone)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.phone = phone;
        }


        

    }
}
