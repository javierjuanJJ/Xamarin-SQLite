using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_SQLite
{
    public partial class Contacts : ContentPage
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            
        }

        private void MenuItem_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}