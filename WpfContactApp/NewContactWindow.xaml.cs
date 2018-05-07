using SQLite;
using System.Windows;
using WpfContactApp.Classes;

namespace WpfContactApp
{
    /// <summary>
    /// Interaction logic for NewContactWindow.xaml
    /// </summary>
    public partial class NewContactWindow : Window
    {
        public NewContactWindow()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            // todo: Implement save functionality.
            var contact = new Contact()
            {
                Name = nameTextBox.Text,
                Email = emailTextBox.Text,
                Phone = phoneTextBox.Text,
            };

            using (var dbConn = new SQLiteConnection(App.dbPath))
            {
                dbConn.CreateTable<Contact>();
                dbConn.Insert(contact);
            }

            Close();
        }
    }
}
