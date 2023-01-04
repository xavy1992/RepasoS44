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
    public partial class Regstro : ContentPage
    {
        public Regstro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text ="Bienvenido "+ usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double precio = Convert.ToDouble(txtPrecio.Text);
                int cantidadx = Convert.ToInt32(txtCantidad.Text);

                double valor = precio * cantidadx;//(%5)
                DisplayAlert("VALOR TOTAL DEL PRODUCTO", valor.ToString(), "Cerrar");
            }
            catch (Exception ex )
            {

                DisplayAlert("Alerta", ex.Message, "Cerrar");
            }




            

        }
    }
}