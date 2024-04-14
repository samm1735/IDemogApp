using IDemogApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDemogApp.Services
{
    public class PersonneDatabase
    {
        SQLiteAsyncConnection Database;

        public PersonneDatabase() { }


        /// <summary>
        ///     Méthode pour créer la base de donnée s'il n'existe pas encore
        /// </summary>
        /// <returns> Task: La base de donnée </returns>
        async Task Init()
        {
            if (Database is not null)
                return;
            try
            {
                Database = new SQLiteAsyncConnection(Constants.DtabasePath, Constants.Flags);
                var result = await Database.CreateTableAsync<Personne>();
            }
            catch (Exception ex) { Debug.WriteLine(ex); }
                
        }



        /// <summary>
        /// Equivalent à SELECT * FROM Personne
        /// </summary>
        /// <returns>Une liste de personne </returns>
        public async Task<List<Personne>> GetPersonnesAsync()
        {
            await Init();
            return await Database.Table<Personne>().ToListAsync();
        }


        /// <summary>
        /// Equivalent à SELECT * FROM Personne WHERE Personne.id = id
        /// </summary>
        /// <param name="id"> L'id de la personne a chercher</param>
        /// <returns> Une personne correspondant a cet id passé en paramètre </returns>
        public async Task<Personne> GetPersonneByIdAsync(int id)
        {
            await Init();
            return await Database.Table<Personne>().Where(x => x.id == id).FirstOrDefaultAsync();
        }

        /// <summary>
        ///     Ajoute ou Update une personne dans la base de données
        /// </summary>
        /// <param name="personne"> La personne à insérer </param>
        /// <returns>Int</returns>
        public async Task<int> SavePersonneAsync(Personne personne)
        {
            await Init();

            if(personne.id != 0)
            {
                //We'll update
                return await Database.UpdateAsync(personne);
            }
            else
            {
                //We'll create
                return await Database.InsertAsync(personne);
            }

        }

        

    }
}
