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
    public partial class Resumen : ContentPage
    {
        public Resumen(String user, String nombre, Double total)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario: " + user;
            txtNombre.Text = nombre;
            txtTotalPagar.Text = total.ToString();
        }
    }
}