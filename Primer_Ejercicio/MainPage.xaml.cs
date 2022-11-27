﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Primer_Ejercicio
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void btnsuma_Clicked(object sender, EventArgs e)
        {

            var num1 = Convert.ToInt32(txtnum1.Text);
            var num2 = Convert.ToInt32(txtnum2.Text);
            var resul = num1 + num2;

            await DisplayAlert("Respuesta", "El resultado de la suma es: " + resul, "OK");

            txtnum1.Text = "";
            txtnum2.Text = "";
        }

        private async void btnresta_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(txtnum1.Text);
            var num2 = Convert.ToInt32(txtnum2.Text);
            var resul = num1 - num2;

            await DisplayAlert("Respuesta", "El resultado de la resta es: " + resul, "OK");

            txtnum1.Text = "";
            txtnum2.Text = "";
        }

        private async void btndivision_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(txtnum1.Text);
            var num2 = Convert.ToInt32(txtnum2.Text);
            var resul = num1 / num2;

            await DisplayAlert("Respuesta", "El resultado de la divicion es: " + resul, "OK");

            txtnum1.Text = "";
            txtnum2.Text = "";
        }

        private async void btnmultiplicacion_Clicked(object sender, EventArgs e)
        {
            var num1 = Convert.ToInt32(txtnum1.Text);
            var num2 = Convert.ToInt32(txtnum2.Text);
            var resul = num1 * num2;

            await DisplayAlert("Respuesta", "El resultado de la multiplicacion es: " + resul, "OK");

            txtnum1.Text = "";
            txtnum2.Text = "";
        }
    }
}
