using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfContactApp.Classes;

namespace WpfContactApp.Controls
{
    /// <summary>
    /// Interaction logic for ContactControl1.xaml
    /// </summary>
    public partial class ContactControl1 : UserControl
    {

        public Contact Contact
        {
            get { return (Contact)GetValue(ContactProperty); }
            set { SetValue(ContactProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Contact.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ContactProperty =
            DependencyProperty.Register("Contact", typeof(Contact), typeof(ContactControl1), new PropertyMetadata(new Contact() { Name = "Default Name", Phone = "Default Phone", Email = "Default Email" }, SetText));

        private static void SetText(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ContactControl1 control1 = d as ContactControl1;

            if (control1 != null)
            {
                control1.nameTextBlock.Text = (e.NewValue as Contact).Name;
                control1.emailTextBlock.Text = (e.NewValue as Contact).Email;
                control1.phoneTextBlock.Text = (e.NewValue as Contact).Phone;
            }
        }

        public ContactControl1()
        {
            InitializeComponent();
        }
    }
}
