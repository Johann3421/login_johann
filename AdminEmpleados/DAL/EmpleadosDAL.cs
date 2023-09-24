using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using AdminEmpleados.BLL;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace AdminEmpleados.DAL
{
    internal class EmpleadosDAL
    {
        ConexionDAL conexion;
        public EmpleadosDAL()
        {

            conexion = new ConexionDAL();
        }
        public bool Agregar(EmpleadoBLL oEmpleadosBLL)
        {
            SqlCommand SQLComando = new SqlCommand("INSERT INTO Empleados (nombres, primerapellido, segundoapellido, departamento, correo, foto) VALUES (@NombreEmpleado, @PrimerApellido, @SegundoApellido, @Departamento, @Correo, @FotoEmpleado)");

            SQLComando.Parameters.Add("@NombreEmpleado", SqlDbType.VarChar).Value = oEmpleadosBLL.NombreEmpleado;
            SQLComando.Parameters.Add("@PrimerApellido", SqlDbType.VarChar).Value = oEmpleadosBLL.PrimerApellido;
            SQLComando.Parameters.Add("@SegundoApellido", SqlDbType.VarChar).Value = oEmpleadosBLL.SegundoApellido;
            SQLComando.Parameters.Add("@Departamento", SqlDbType.Int).Value = oEmpleadosBLL.Departamento; // Asumiendo que Departamento es de tipo entero en la base de datos
            SQLComando.Parameters.Add("@Correo", SqlDbType.VarChar).Value = oEmpleadosBLL.Correo;
            SQLComando.Parameters.Add("@FotoEmpleado", SqlDbType.Image).Value = oEmpleadosBLL.FotoEmpleado;

            return conexion.ejecutarComandoSinRetornoDatos(SQLComando);
        }
        public bool Eliminar(EmpleadoBLL oEmpleadosBLL)
        {
            SqlCommand SQLComando = new SqlCommand("DELETE FROM Empleados WHERE ID=@ID");
            SQLComando.Parameters.Add("@ID", SqlDbType.Int).Value = oEmpleadosBLL.ID;
            return conexion.ejecutarComandoSinRetornoDatos(SQLComando);
        }
        public bool Modificar(EmpleadoBLL oEmpleadosBLL)
        {
            SqlCommand SQLComando = new SqlCommand("UPDATE Empleados SET nombres=@Nombres, primerapellido=@PrimerApellido, segundoapellido=@SegundoApellido, correo=@Correo, foto=@Foto WHERE ID=@ID");

            SQLComando.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = oEmpleadosBLL.NombreEmpleado;
            SQLComando.Parameters.Add("@PrimerApellido", SqlDbType.VarChar).Value = oEmpleadosBLL.PrimerApellido;
            SQLComando.Parameters.Add("@SegundoApellido", SqlDbType.VarChar).Value = oEmpleadosBLL.SegundoApellido;
            SQLComando.Parameters.Add("@Correo", SqlDbType.VarChar).Value = oEmpleadosBLL.Correo;
            SQLComando.Parameters.Add("@Foto", SqlDbType.VarBinary).Value = oEmpleadosBLL.FotoEmpleado;
            SQLComando.Parameters.Add("@ID", SqlDbType.Int).Value = oEmpleadosBLL.ID;

            return conexion.ejecutarComandoSinRetornoDatos(SQLComando);
        }
        public DataSet MostrarEmpleados()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Empleados");
            return conexion.EjecutarSentencia(sentencia);
        }
    }
}
