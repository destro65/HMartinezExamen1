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
    public partial class Resumen : ContentPage
    {
        string usuario;
        public Resumen(String usuario, String nombre, String apellido, String edad, String fecha, String pais, String ciudad, String monto, String pagom, String pagot1)
        {
            InitializeComponent();
            lblusuario1.Text = "Usuario conectado:" + usuario;
            //txtDato.Text = dato.ToString();
            //txtapellido.Text = apellido;
            //txtEstudiante.Text = estudiante;
            txtNombre.Text = nombre;
            txtapellido.Text = apellido;
            txtedad.Text = edad;
            txtfecha.Text = fecha;
            txtpais.Text = pais;    
            txtciudad.Text = ciudad;    
            txtmonto.Text = monto;
            txtpago.Text = pagom;
            txttotal.Text = pagot1;
        }

        private void btnsalir_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }
    }
}