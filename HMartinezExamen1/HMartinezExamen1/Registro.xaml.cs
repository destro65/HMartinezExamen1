using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HMartinezExamen1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string usuario;
        public Registro(string usuario)
        {
            InitializeComponent();
            lblusuario.Text = "Usuario conectado:" + usuario;
        }
        
                

        private void btnpagomensual_Clicked(object sender, EventArgs e)
        {
            double dato = Convert.ToDouble(txtmonto.Text);            
            double interes = 4 % 1500;
            double pago = Convert.ToDouble(txtpago.Text);

            pago =(1500-dato)/4;
            pago = pago + 60 ;
            txtpago.Text=pago.ToString();
        }

        private void btnresumen_Clicked(object sender, EventArgs e)
        {
            double dato = Convert.ToDouble(txtmonto.Text);
            double interes = 4 % 1500;
            double pago = Convert.ToDouble(txtpago.Text);

            pago = (1500 - dato) / 4;
            txtpago.Text = pago.ToString();

            {

                string nombre = txtnombre.Text;
                string apellido = txtapellido.Text;
                string edad = txtedad.Text;                
                string fecha = dtfecha.Date.ToString();
                string pais = pkPais.Items[pkPais.SelectedIndex];
                string ciudad = pkCiudad.Items[pkCiudad.SelectedIndex];
                string monto=txtmonto.Text;

                string pagom = txtpago.Text;
                double pagot = (dato * 4)+60;
                
                
                string pagot1=pagot.ToString();



                Navigation.PushAsync(new Resumen( usuario,  nombre,  apellido,  edad,  fecha,  pais,  ciudad,  monto,  pagom,  pagot1));
            }
            
        }

        private void txtmonto_TextChanged(object sender, TextChangedEventArgs e)
        {
            double dato = Convert.ToDouble(txtmonto.Text);
            if (dato > 1500)
            {
                DisplayAlert("Alerta", "Dato fuera de rango", "Cerrar");
                txtmonto.Text = "";
            }
        }

        private void txtpago_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}