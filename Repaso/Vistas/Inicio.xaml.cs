using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Repaso.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            //validacion
            Navigation.PushAsync(new Regstro(txtUsuario.Text));
        }

        private void btnCancelar_Clicked(object sender, EventArgs e)
        {

        }
    }
}