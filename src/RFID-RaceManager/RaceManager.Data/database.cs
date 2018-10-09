using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace RaceManager.Data
{
    public class database
    {
        public SQLiteConnection get_SQLiteConnection()
        {
            if (!File.Exists("races.sqlite"))
                SQLiteConnection.CreateFile("races.sqlite");

            SQLiteConnection myConnection = new SQLiteConnection("data source=races.sqlite");
            myConnection.Open();
            return myConnection;
        }
    }
}
