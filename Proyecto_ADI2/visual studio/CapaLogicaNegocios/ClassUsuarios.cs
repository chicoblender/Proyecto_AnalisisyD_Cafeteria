using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaAccesoDatos;

namespace CapaLogicaNegocios
{
    public class ClassUsuarios
    {
        //atributos
        public Int32 n_id { get; set; }
        public String n_nom_usr { get; set; }
        public String n_ci_usr { get; set; }
        public String n_nombres { get; set; }
        public String n_apellidos { get; set; }
        public String n_pass { get; set; }
        public String n_email { get; set; }
        public String n_img { get; set; }
        public String n_nivel { get; set; }
        public Int32 n_estado { get; set; }
        
        //agregar referencia a la clase conexion
        ClassConexion con = new ClassConexion();

        //metodos registrar usuario
        public String registrar_usuario() {
            String msj = "";
            List<ClassParametros> lst = new List<ClassParametros>(); 

            try
            {
                //pasamos los parametros de entrada
               // lst.Add(new ClassParametros("@id",n_id));
                lst.Add(new ClassParametros("@nom_usr",n_nom_usr));
                lst.Add(new ClassParametros("@ci_usr", n_ci_usr));
                lst.Add(new ClassParametros("@nombres",n_nombres));
                lst.Add(new ClassParametros("@apellidos",n_apellidos));
                lst.Add(new ClassParametros("@pass",n_pass));
                lst.Add(new ClassParametros("@email",n_email));
                lst.Add(new ClassParametros("@img",n_img));
                lst.Add(new ClassParametros("@nivel",n_nivel));
                lst.Add(new ClassParametros("@estado",n_estado));
                
                //pasamos los parametros de salida
                lst.Add(new ClassParametros("@mensaje",SqlDbType.VarChar, 100));
                
                con.ejecutar_sp("spu_registrar_usuario",lst);

                msj=lst[9].Valor.ToString();

            }
            catch (Exception e)
            {
                
                throw e;
            }
            return(msj);
        }

        //método para listar usuarios 
        public DataTable listado_usuarios() { 
            return (con.Listado_sp("spu_listado_usuarios",null));
        }

        //método para listar usuarios por ci
        public DataTable listado_usuarios_ci(String ci)
        {
            n_ci_usr = ci;            
            List<ClassParametros> lst = new List<ClassParametros>();
            try
            {
                //pasamos los parametros de entrada
                lst.Add(new ClassParametros("@ci_usr", n_ci_usr));                
                return (con.Listado_sp("spu_listado_usuarios_ci", lst));
            }
            catch (Exception e)
            {
                throw e;
            }                                    
        }

        //verificar usuarios
        public String verificar_usuario()
        {
            String msj = "";
            List<ClassParametros> lst = new List<ClassParametros>();

            try
            {
                //pasamos los parametros de entrada
                
                lst.Add(new ClassParametros("@nom_usr", n_nom_usr));                
                lst.Add(new ClassParametros("@pass", n_pass));                

                //pasamos los parametros de salida
                lst.Add(new ClassParametros("@mensaje", SqlDbType.VarChar, 100));

                con.ejecutar_sp("spu_verifica_usuario", lst);

                msj = lst[2].Valor.ToString();

            }
            catch (Exception e)
            {

                throw e;
            }
            return (msj);
        }

        //modificar usuarios
        public String modificar_usuario()
        {
            String msj = "";
            List<ClassParametros> lst = new List<ClassParametros>();

            try
            {
                //pasamos los parametros de entrada
                lst.Add(new ClassParametros("@id", n_id));
                lst.Add(new ClassParametros("@nom_usr", n_nom_usr));
                lst.Add(new ClassParametros("@ci_usr", n_ci_usr));
                lst.Add(new ClassParametros("@nombres", n_nombres));
                lst.Add(new ClassParametros("@apellidos", n_apellidos));
                lst.Add(new ClassParametros("@pass", n_pass));
                lst.Add(new ClassParametros("@email", n_email));
                lst.Add(new ClassParametros("@img", n_img));
                lst.Add(new ClassParametros("@nivel", n_nivel));
                lst.Add(new ClassParametros("@estado", n_estado));

                //pasamos los parametros de salida
                lst.Add(new ClassParametros("@mensaje", SqlDbType.VarChar, 100));

                con.ejecutar_sp("spu_modificar_usuario", lst);

                msj = lst[10].Valor.ToString();

            }
            catch (Exception e)
            {

                throw e;
            }
            return (msj);
        }

        //eliminar usuarios
        public String eliminar_usuario(Int32 id)
        {
            String msj = "";
            n_id = id;      
            List<ClassParametros> lst = new List<ClassParametros>();

            try
            {
                //pasamos los parametros de entrada
                lst.Add(new ClassParametros("@id", n_id));
                
                //pasamos los parametros de salida
                lst.Add(new ClassParametros("@mensaje", SqlDbType.VarChar, 100));
                con.ejecutar_sp("spu_eliminar_usuario", lst);
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
