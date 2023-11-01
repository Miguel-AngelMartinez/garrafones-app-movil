using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace purificadoras
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Ingresar_Clicked(object sender, EventArgs e)
        {
            string user=usuarios.Text;
            string pass=password.Text;

        }

        private void nuevo_usuario_Clicked(object sender, EventArgs e)
        {

        }
    }
}
