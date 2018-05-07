using System;
using System.Windows;

namespace WpfContactApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string dbName = "SQLiteContacts.db";
        static string dbFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string dbPath = System.IO.Path.Combine(dbFolderPath, dbName);
    }
}
