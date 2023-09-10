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
        public Pestaña()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible= false;
            btnRestaurar.Visible= true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Normal;
            btnRestaurar.Visible= false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            labelhora.Text = DateTime.Now.ToString("HH:mm:ss");
            labelfecha.Text = DateTime.Now.ToString("dddd:MMMM:yyy");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliste con exito");
            this.Hide();
            user n = new user();
            n.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Juego 2");
            flapyBird f = new flapyBird();
            f.Show();
            this.Hide();
        }
    }
}
