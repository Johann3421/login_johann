
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Login2
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, contraseña;
            nombre = user1.Text;
            contraseña = password.Text;
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-7LDGQBD;Initial Catalog=LoginDB;Integrated Security=True"))
                {
                    con.Open();
                    string query = "SELECT COUNT(1) FROM Usuarios WHERE nombre=@usuario AND Contraseña=@contrasena";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@usuario", nombre);
                    cmd.Parameters.AddWithValue("@contrasena", contraseña);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        MessageBox.Show ("Inicio de sesión exitoso");
                        this.Hide();
                        Pestaña p = new Pestaña();
                        p.Nombre = nombre;
                        p.Contraseña = contraseña;
                        p.Show();
                    }
                    else
                    {
                        MessageBox.Show ( "Credenciales incorrectas. Inténtalo de nuevo.");
                    }
                }
        }

        private void Muestra_TextChanged(object sender, EventArgs e)
        {

        }

        private void user1_Leave(object sender, EventArgs e)
        {
            if (user1.Text == "")
            {
                user1.Text = "Ingrese su usuario";
                user1.ForeColor = Color.Black;
            }
        }

        private void user1_Enter(object sender, EventArgs e)
        {
            if (user1.Text == "Ingrese su usuario")
            {
                user1.Text = "";
                user1.ForeColor = Color.Black;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Ingrese su contraseña";
                password.ForeColor = Color.Black;
                password.UseSystemPasswordChar = false;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Ingrese su contraseña")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
                password.UseSystemPasswordChar = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                password.UseSystemPasswordChar = false;
            }
            else
            {
                password.UseSystemPasswordChar = true;
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registrarme_Click(object sender, EventArgs e)
        {
            Registro2 r = new Registro2();
            r.Show();
            this.Hide();
        }
    }
}

