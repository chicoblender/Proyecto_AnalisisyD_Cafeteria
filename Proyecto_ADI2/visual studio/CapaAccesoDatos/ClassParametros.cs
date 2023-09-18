using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class ClassParametros
    {
        //Parámetros de sp
        public String Nombre { get; set; }
        public Object Valor { get; set; }
        public SqlDbType TipoDato { get; set; }
        public Int32 Tamano { get; set; }
        public String nom_usr { get; set; }
        public ParameterDirection Direccion { get; set; } 
        public byte foto { get; set; }
        
        //constructores
        //parametros entrada
        public ClassParametros(String objNombre, Object objValor) {
            Nombre = objNombre;
            Valor = objValor;
            Direccion = ParameterDirection.Input;
        }

        //parametros salida
        public ClassParametros(String objNombre, SqlDbType objTipoDato, Int32 objTamano)
        {
            Nombre = objNombre;
            TipoDato = objTipoDato;
            Tamano = objTamano;
            Direccion = ParameterDirection.Output;
        }
    }
}
