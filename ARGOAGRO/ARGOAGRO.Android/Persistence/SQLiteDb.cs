using System;
using System.IO;
using ARGOAGRO.Droid.Persistence;
using ePMPro.Persistence;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]
namespace ARGOAGRO.Droid.Persistence
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}