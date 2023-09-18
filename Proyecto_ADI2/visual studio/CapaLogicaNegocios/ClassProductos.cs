using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaAccesoDatos;
using System.Collections;

namespace CapaLogicaNegocios
{
    public class ClassProductos
    {
        //atributos
        public Int32 n_id_prod { get; set; }
        public string n_cod_prod { get; set; }
        public string n_nom_prod { get; set; }
        //public string n_marc_prod { get; set; }
        public string n_cate_prod { get; set; } //agregado
        //public string n_orig_prod { get; set; }
        //public string n_fecha_prod { get; set; }
        public Int32 n_prec_prod { get; set; } 
       // public string n_garant_prod { get; set; }
        public string n_id_cate { get; set;} //agregado
        public byte[] n_Ruta_Imagen { get; set; } //agregado
        public Int32 n_cant_prod { get; set; }
        //agregar referencia a la clase conexion
        ClassConexion con = new ClassConexion();

        //////////////////////////////////
        //metodos registrar producto
        public String registrar_producto()
        {
            String msj = "";
            List<ClassParametros> lst = new List<ClassParametros>();

            try
            {
                //pasamos los parametros de entrada
                // lst.Add(new ClassParametros("@id",n_id));
               lst.Add(new ClassParametros("@cod_prod", n_cod_prod));
                lst.Add(new ClassParametros("@nom_prod", n_nom_prod));
                lst.Add(new ClassParametros("@prec_prod", n_prec_prod));     
                lst.Add(new ClassParametros("@img_prod", n_Ruta_Imagen));
               

                //pasamos los parametros de salida
                lst.Add(new ClassParametros("@mensaje", SqlDbType.VarChar,100 ));

                con.ejecutar_sp("spu_registrar_producto", lst);

                msj = lst[4].Valor.ToString();

            }
            catch (Exception e)
            {

                throw e;
            }
            return (msj);
        }
        //listar poroductos
        public DataTable listado_productos()
        {
            return (con.Listado_sp("spu_listado_productos", null));
        }
        public DataTable listado_productos_cod(String ci)
        {
            n_cod_prod = ci;
            List<ClassParametros> lst = new List<ClassParametros>();
            try
            {
                //pasamos los parametros de entrada
                lst.Add(new ClassParametros("@cod_prod", n_cod_prod));
                return (con.Listado_sp("spu_listado_productos_cod", lst));
            }
            catch (Exception e)
            {
                throw e;
            }
           
            }
        public String modificar_producto()
        {
            String msj = "";
            List<ClassParametros> lst = new List<ClassParametros>();

            try
            {
                //pasamos los parametros de entrada
                lst.Add(new ClassParametros("@id_prod", n_id_prod));
                lst.Add(new ClassParametros("@cod_prod", n_cod_prod));
                lst.Add(new ClassParametros("@nom_prod", n_nom_prod));                      
                lst.Add(new ClassParametros("@prec_prod", n_prec_prod));
                lst.Add(new ClassParametros("@img_prod", n_Ruta_Imagen));

                //pasamos los parametros de salida
                lst.Add(new ClassParametros("@mensaje", SqlDbType.VarChar, 100));

                con.ejecutar_sp("spu_modificar_producto", lst);

                msj = lst[5].Valor.ToString();

            }
            catch (Exception e)
            {

                throw e;
            }
            return (msj);


        }
        public String eliminar_producto(Int32 id)
        {
            String msj = "";
            n_id_prod = id;
            List<ClassParametros> lst = new List<ClassParametros>();

            try
            {
                //pasamos los parametros de entrada
                lst.Add(new ClassParametros("@id_prod", n_id_prod));

                //pasamos los parametros de salida
                lst.Add(new ClassParametros("@mensaje", SqlDbType.VarChar, 100));
                con.ejecutar_sp("spu_eliminar_producto", lst);
                msj = lst[1].Valor.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
            return (msj);
        }





    }
}
