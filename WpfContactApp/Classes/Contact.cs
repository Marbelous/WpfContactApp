using SQLite;

namespace WpfContactApp.Classes
{
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} - NAME: {Name} - EMAIL: {Email} - PHONE: {Phone}";
        }
    }
}
