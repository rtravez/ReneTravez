﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReneTravez
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        Double valorTotal = 1800;
        Double valorPendiente = 0;
        Double valorMensual = 0;
        String user;
        public Registro(string user, string pass)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario: " + user;
            this.user = user;
            
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            valorPendiente = valorTotal - Convert.ToDouble(txtMontoInicial.Text);

            valorMensual = valorPendiente / 3;            
            txtPagoMensual.Text = Convert.ToString(valorMensual * 0.5);



        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Información", "Elemento guardado con exito", "Cerrar");
            await Navigation.PushAsync(new Resumen(user, txtNombre.Text, Convert.ToDouble(txtPagoMensual.Text)));
            

        }

        private void txtMontoInicial_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtMontoInicial.Text))
            {
                DisplayAlert("Error", "El campo monto inical es obligatorio", "Atrás");
                return;
            }

            if (Convert.ToDouble(txtMontoInicial.Text) < 0 || Convert.ToDouble(txtMontoInicial.Text) > 1800)
            {

                DisplayAlert("Error", "El campo monto inicial debe ser mayor a cero y menor igual a 1800", "Atrás");
                return;
            }
        }
    }
}