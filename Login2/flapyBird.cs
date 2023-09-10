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
    public partial class flapyBird : Form
    {
        int ContadorMovimientos = 1;
        bool VolarArriba = false;
        int distancia = 0;
        Random PosicionRandom = new Random();
        public flapyBird()
        {
            InitializeComponent();
            this.KeyPreview = true;
            IniciarJuego();
        }
        public void IniciarJuego()
        {
            Player.Location = new Point(19, 255);
            distancia = PosicionRandom.Next(-160, 118);
            TuboArriba.Location = new Point(270, -173 - distancia);
            TuboAbajo.Location = new Point(270, 319 - distancia);
            Puntaje.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int CantidadMovimiento = 5;
            if(ContadorMovimientos <= CantidadMovimiento)
            {
                Player.Image = Properties.Resources.Abajo;
                ContadorMovimientos++;
            }
            if((ContadorMovimientos > CantidadMovimiento / 2) && (ContadorMovimientos <= CantidadMovimiento * 2))
            {
                Player.Image = Properties.Resources.Arriba;
                ContadorMovimientos++;
            }
            ContadorMovimientos = (ContadorMovimientos > CantidadMovimiento * 2) ? 0 : ContadorMovimientos;

            int ly = Player.Location.Y;
            int lx = Player.Location.X;

            if (VolarArriba)
            {
                ly = ly - 15;
                VolarArriba = false;
            }
            else
            {
                ly++;
            }

            Player.Location = new Point(Player.Location.X, ly);


            if (((Player.Bounds.IntersectsWith(Barrera.Bounds) || (Player.Bounds.IntersectsWith(TuboArriba.Bounds)) || (Player.Bounds.IntersectsWith(TuboAbajo.Bounds)))))
            {
                IniciarJuego();
            }
            Puntaje.Location = new Point(Player.Location.X + 30, Player.Location.Y - 25);
            Puntaje.Text = (TuboArriba.Location.X == Player.Location.X) ? Convert.ToString((Convert.ToInt32(Puntaje.Text) + 1)).ToString() : Puntaje.Text;


        }

        private void flapyBird_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Space))
            {
                VolarArriba = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (TuboAbajo.Location.X > -140)
            {
                TuboAbajo.Location = new Point((TuboAbajo.Location.X) - 1, TuboAbajo.Location.Y);
                TuboArriba.Location = new Point((TuboArriba.Location.X) - 1, TuboArriba.Location.Y);
            }else
            {
                distancia = PosicionRandom.Next(-170, 118);
                TuboAbajo.Location = new Point(400, 319 + distancia);
                TuboArriba.Location = new Point(400, -173 + distancia);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Barrera.Location = (Barrera.Location.X > -480) ? new Point((Barrera.Location.X) - 1, Barrera.Location.Y) : Barrera.Location = new Point(-9, Barrera.Location.Y);
        }
    }
}
