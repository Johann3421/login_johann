using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using AdminEmpleados.BLL;


namespace AdminEmpleados.DAL
{
    internal class DepartamentosDAL
    {
        ConexionDAL conexion;

        public DepartamentosDAL() {

            conexion = new ConexionDAL();
        }

        public bool Agregar(DepartamentoBLL oDepartamentosBLL)
        {
            SqlCommand SQLComando = new SqlCommand("INSERT INTO Departamentos VALUES(@Departamente)");

            SQLComando.Parameters.Add("@Departamente",SqlDbType.VarChar).Value=oDepartamentosBLL.Departamento;

            return conexion.ejecutarComandoSinRetornoDatos(SQLComando);

            //return conexion.ejecutarComandoSinRetornoDatos("INSERT INTO Departamentos(departamento)VALUES('"+oDepartamentosBLL.Departamento +"')");
            
        
        
        
        }
        public bool Eliminar(DepartamentoBLL oDepartamentosBLL)
        {
            SqlCommand SQLComando = new SqlCommand("DELETE FROM Departamentos WHERE ID=@ID");
            SQLComando.Parameters.Add("@ID", SqlDbType.Int).Value = oDepartamentosBLL.ID;
            return conexion.ejecutarComandoSinRetornoDatos(SQLComando);

            //conexion.ejecutarComandoSinRetornoDatos("DELETE FROM Departamentos WHERE ID="+oDepartamentosBLL.ID);

            

        }
        public bool Modificar(DepartamentoBLL oDepartamentosBLL)
        {
            SqlCommand SQLComando = new SqlCommand("UPDATE Departamentos SET departamento=@Departamento WHERE ID=@ID ");
            SQLComando.Parameters.Add("@Departamento", SqlDbType.VarChar).Value = oDepartamentosBLL.Departamento;
            SQLComando.Parameters.Add("@ID", SqlDbType.Int).Value = oDepartamentosBLL.ID;

            return conexion.ejecutarComandoSinRetornoDatos(SQLComando);



            //conexion.ejecutarComandoSinRetornoDatos("UPDATE Departamentos " + "SET departamento='"+oDepartamentosBLL.Departamento +"' " +" WHERE ID="+oDepartamentosBLL.ID);


        }


        public DataSet MostrarDepartamentos()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Departamentos");
            return conexion.EjecutarSentencia(sentencia);
        }


    }
}
