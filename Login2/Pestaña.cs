using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login2
{

    public partial class Pestaña : Form
    {
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public Pestaña()
        {
            InitializeComponent();
            // En este punto, puedes usar las propiedades Nombre y Contraseña para mostrar los valores en controles de tu formulario.
            labelNombre.Text = Nombre;
            labelContraseña.Text = Contraseña;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
