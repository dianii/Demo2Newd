using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo2Newd
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
        }/*
        private void picMusik_Changed(object sender, EventArgs e)
        {
            var elementoSeleccionado = picMusik.SelectedItem.ToString();
            DisplayAlert("Musica", elementoSeleccionado, "Aceptar");
        }
        private void btnSimular_Clicked(object sender, EventArgs e)
        {
            var progreso = progProceso.Progress;
            if (progreso == 1)
            {
                progProceso.ProgressTo(.1, 250, Easing.Linear);
            }
            else
            {
                progProceso.ProgressTo(.1, 250, Easing.Linear);
            }
        }
        private void sbNombre_Pressed(object sender, EventArgs e)
        {
            DisplayAlert("Search Bar", "Estoy Buscando...", "Aceptar");
        }
        private void sbNombre_Changed(object sender, EventArgs e)
        {
            DisplayAlert("Search Bar", "Estoy Escribiendo...", "Aceptar");
        }

        private void sldEdad_Changed(object sender, EventArgs e)
        {
            lbEdad.Text = sldEdad.Value.ToString();
        }
        private void stpCantidad_Changed(object sender, EventArgs e)
        {
            lbCantidad.Text = stpCantidad.Value.ToString();
        }

        private void swDec_Toggled(object sender, EventArgs e)
        {
            if (swDec.IsToggled)
            {
                DisplayAlert("Mensaje", "Esta Activo", "Aceptar");
            }
            else
            {
                DisplayAlert("Mensaje", "No esta Activo", "Aceptar");
            }
        }*/
        private void wvActualizaP_Navigated(object sender, EventArgs e) {

            DisplayAlert("WebView", "Ha Finalizado  la carga de la pagina", "Aceptar");
        }
    }
}
