using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReneTravez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            if (!this.validarFormulario())
            {
                if (txtUsuario.Text.Equals("estudiante2022") && txtContrasenia.Text.Equals("uisrael2022"))
                {
                    await Navigation.PushAsync(new Registro(txtUsuario.Text, txtContrasenia.Text));
                }
                else
                {
                    await DisplayAlert("Error", "Usuario o contraseña incorrectos", cancel: "Atrás");
                }
            }

        }

        private bool validarFormulario()
        {
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                DisplayAlert("Error", "El campo usuario es obligatorio", cancel: "Atrás");
                return true;
            }

            if (String.IsNullOrEmpty(txtContrasenia.Text))
            {
                DisplayAlert("Error", "El campo contraseña es obligatorio", cancel: "Atrás");
                return true;
            }

            return false;
        }
    }
}