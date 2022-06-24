using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Graphics;
using SQLite;
using XamarinKofteciYusufClone.Models;
using Environment = Android.OS.Environment;

namespace XamarinKofteciYusufClone.Droid.SQLite_Android
{
    public class SQLite_Android : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "Mydatabase.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentsPath, "..", "Library");
        }
    }
}