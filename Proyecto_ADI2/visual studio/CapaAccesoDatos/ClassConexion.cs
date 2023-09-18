using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//using System.Security.Cryptography;
namespace CapaAccesoDatos
{
    public class ClassConexion
    {
        SqlConnection conexion = new SqlConnection("Server =.; DataBase = cafeteria_2023; Integrated Security = True");

        //método para abrir la conexion
        public void abrirConexion() {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
        }

        //método para cerrar la conexion
        public void cerrarConexion() {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }

        //método para ejecutar sp (insert, update, delete)
        public void ejecutar_sp(String nombreSP, List<ClassParametros> lst) {
            
            SqlCommand cmd;

            try
            {
                abrirConexion();
                cmd = new SqlCommand(nombreSP, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direccion == ParameterDirection.Input)
                        {
                            cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        }

                        if (lst[i].Direccion == ParameterDirection.Output)
                        {
                            cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato,lst[i].Tamano).Direction = ParameterDirection.Output;
                        }

                    }
                    cmd.ExecuteNonQuery();

                    //recuperar parametros de salida
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            lst[i].Valor = cmd.Parameters[i].Value.ToString();
                    }                    
                }
            }
            catch (Exception e)
            {
                
                throw e;
            }
            cerrarConexion();
        }

        //método para los listados de consultas (select)
        public DataTable Listado_sp(String nombreSp, List<ClassParametros> lst){
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            
            try 
	        {	        
                da =  new SqlDataAdapter(nombreSp, conexion); 
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (lst != null){
		            for (int i = 0; i < lst.Count; i++)
			        {
			            da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);

			        }
            	}
		        da.Fill(dt);

	        }
	        catch (Exception e)
	        {
		
		        throw e;
	        }
            return(dt);

        }
    }
}
