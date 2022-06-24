using Android.OS;
using SQLite;
using Xamarin.Forms;
using XamarinKofteciYusufClone.Droid;
using XamarinKofteciYusufClone.Models;
using Path = System.IO.Path;

[assembly:Dependency(typeof(SQLite_Android))]
namespace XamarinKofteciYusufClone.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            //var sqliteFileName = "Mydatabase.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            //var path = Path.Combine(documentsPath, sqliteFileName);
            string path = Path.Combine(
                System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),
                "ormdemo.db3");
            var cn = new SQLiteConnection(path);
            return cn;
        }
    }
}