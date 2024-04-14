using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDemogApp.Models
{
    public static class Constants
    {
        public const string DB_FILENAME = "personnes.db3";

        public const SQLite.SQLiteOpenFlags Flags =
            //Open DB in Read/Write Mode
            SQLite.SQLiteOpenFlags.ReadWrite | 
            //Create DB if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            //Multi-threaded DB access
            SQLite.SQLiteOpenFlags.SharedCache
            ;

        public static string DtabasePath => Path.Combine(FileSystem.AppDataDirectory, DB_FILENAME);
    }
}
