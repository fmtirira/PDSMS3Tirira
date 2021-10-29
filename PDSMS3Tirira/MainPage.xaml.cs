using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDSMS3Tirira
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            //Almacenar los datos en variables
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;
            //Navegando a la ventana dos
            if (usuario == "estudiante2021" && clave == "uisrael2021")
            {
                await Navigation.PushAsync(new ViewDos(usuario, clave));
            }
            else
            {
                await DisplayAlert("MENSAJE DE ALERTA", "Usuario o Contraseña Incorrectos", "OK");
            }

        }
    }
}
