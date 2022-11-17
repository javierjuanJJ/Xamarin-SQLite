using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin_SQLite.Model;

namespace Xamarin_SQLite
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            ContactModel contactModel = new ContactModel()
            {
                Name1 = Name.Text,
                Lastname1 = Lastname.Text,
                Address1 = Address.Text,
                PhoneNumber1 = Convert.ToInt32(PhoneNumber.Text),
                Email1 = Email.Text
            };

            using (SQLiteConnection conn = new SQLiteConnection(App.FILE_PATH))
            {
                conn.CreateTable<ContactModel>();
                int rowsAffected = conn.Insert(contactModel);
            }
            
        }
    }
}