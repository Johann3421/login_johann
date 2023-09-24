using AdminEmpleados.BLL;
using AdminEmpleados.DAL;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AdminEmpleados.PL
{
    public partial class frmEmpleados : Form
    {
        byte[] imagenByte;
        EmpleadosDAL oEmpleadosDAL;
        public frmEmpleados()
        {
            oEmpleadosDAL = new EmpleadosDAL();
            InitializeComponent();
            LLenarGrid();
            LimpiarEntradas();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            DepartamentosDAL objDepartamentos = new DepartamentosDAL();

            cbxDepartamento.DataSource = objDepartamentos.MostrarDepartamentos().Tables[0];
            cbxDepartamento.DisplayMember = "departamento";
            cbxDepartamento.ValueMember = "ID";

        }

        private void picFoto_Click(object sender, EventArgs e)
        {

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectorImagen = new OpenFileDialog();
            selectorImagen.Title = "Seleccionar Imagen";

            if (selectorImagen.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = Image.FromStream(selectorImagen.OpenFile());
                MemoryStream memoria = new MemoryStream();
                picFoto.Image.Save(memoria, System.Drawing.Imaging.ImageFormat.Png);

                imagenByte = memoria.ToArray();

            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            oEmpleadosDAL.Agregar(RecuperarInformacion());
            LLenarGrid();
            LimpiarEntradas();
        }
        private EmpleadoBLL RecuperarInformacion()
        {
            EmpleadoBLL oEmpleadosBLL = new EmpleadoBLL();

            int ID = 0;
            int.TryParse(txtID.Text, out ID);

            oEmpleadosBLL.ID = ID;
            oEmpleadosBLL.NombreEmpleado = txtNombre.Text;
            oEmpleadosBLL.PrimerApellido = txtPrimerApellido.Text;
            oEmpleadosBLL.SegundoApellido = txtSegundoApellido.Text;
            oEmpleadosBLL.Correo = txtCorreo.Text;

            return oEmpleadosBLL;
        }

        private void Mostrar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;
            dgvEmpleados.ClearSelection();

            if (indice >= 0)
            {
                txtID.Text = dgvEmpleados.Rows[indice].Cells[0].Value.ToString();
                txtNombre.Text = dgvEmpleados.Rows[indice].Cells[1].Value.ToString();
                txtPrimerApellido.Text = dgvEmpleados.Rows[indice].Cells[2].Value.ToString();
                txtSegundoApellido.Text = dgvEmpleados.Rows[indice].Cells[3].Value.ToString();
                txtCorreo.Text = dgvEmpleados.Rows[indice].Cells[4].Value.ToString();

                btnAgregar.Enabled = false;
                btnBorrar.Enabled = true;
                btnModificar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            oEmpleadosDAL.Modificar(RecuperarInformacion());
            LLenarGrid();
            LimpiarEntradas();
        }
        public void LLenarGrid()
        {
            dgvEmpleados.DataSource = oEmpleadosDAL.MostrarEmpleados().Tables[0];

            dgvEmpleados.Columns[0].HeaderText = "ID";
            dgvEmpleados.Columns[1].HeaderText = "Nombre";
            dgvEmpleados.Columns[2].HeaderText = "Primer Apellido";
            dgvEmpleados.Columns[3].HeaderText = "Segundo Apellido";
            dgvEmpleados.Columns[4].HeaderText = "Correo";
            dgvEmpleados.Columns[5].HeaderText = "Departamento";
        }
        public void LimpiarEntradas()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtCorreo.Text = "";

            btnAgregar.Enabled = true;
            btnBorrar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            oEmpleadosDAL.Eliminar(RecuperarInformacion());
            LLenarGrid();
            LimpiarEntradas();
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
