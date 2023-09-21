using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login2
{
    public partial class Registro2 : Form
    {
        public Registro2()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-7LDGQBD;Initial Catalog=LoginDB;Integrated Security=True"))
            {
                try
                {
                    con.Open();
                    MessageBox.Show("Conexión Exitosa");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    throw;
                }

                string sql = "INSERT INTO Usuarios (nombre, Contraseña) VALUES (@user, @password)";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@user", n_user.Text);
                    cmd.Parameters.AddWithValue("@password", n_password.Text);

                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario Registrado");
                            this.Hide();
                            user n = new user();
                            n.Show();
                            // Aquí deberías mostrar la siguiente ventana o formulario
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el usuario");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void Registro2_Load(object sender, EventArgs e)
        {

        }
    }
}
