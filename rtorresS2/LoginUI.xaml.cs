using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace rtorresS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private  async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new HomePage(txtUsuario.Text, txtClave.Text));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2022";
            string clave = "uisrael2022";

           

            string tUsuario = txtUsuario.Text;
            string tContrasenia = txtClave.Text;

            if (usuario == tUsuario & clave == tContrasenia)
            {
                await Navigation.PushAsync(new HomePage(txtUsuario.Text, txtClave.Text));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario  NO correcto", "cerrar");

            }
        }
        }
      
}





