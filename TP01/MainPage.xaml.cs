using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP01
{
    public partial class MainPage : ContentPage
    {

        public string id;
        public string pass;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void BotaoOK_Clicked(object sender, EventArgs e)
        {
            if (id == "admin" && pass == "@dmin")
            {
                await DisplayAlert("Alerta!", "Logou com sucesso", "OK");
            }
            else
            {
                await DisplayAlert("Alerta!", "Erro no login ou senha", "Tente novamente");
            }
        }

        private void Button_Clean(object sender, EventArgs e)
        {
            idEntry.Text = string.Empty;
            passEntry.Text = string.Empty;
            idEntry.Focus();
        }
        private async void Button_Creditos(object sender, EventArgs e)
        {
            await DisplayAlert("Aviso", "Huandrio Avelino e João Antonio", "Obrigado");
        }

        void idchange(object sender, TextChangedEventArgs e)
        {
            id = e.NewTextValue;
        }

        void passchange(object sender, TextChangedEventArgs e)
        {
            pass = e.NewTextValue;
        }
    }
}
