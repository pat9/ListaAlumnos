using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BO;

namespace DAO
{
    class ListaDAO
    {

        conexionDAO conectar = new conexionDAO();
        public int agregar(object agregar)
        {
            listaBO obejto = (listaBO)agregar;
            SqlCommand dir = new SqlCommand("INSERT INTO asistencia (fecha ,id_alumno)VALUES (@fecha,@idalum)");

            dir.Parameters.Add("@fecha", SqlDbType.Date).Value = obejto.Fecha;//----
            dir.Parameters.Add("@idalum", SqlDbType.Int).Value = obejto.Id_alumno;
           
            dir.CommandType = CommandType.Text;
            return conectar.EjecutarComando(dir);

        }

        public int eliminar(object eliminar)
        {
            listaBO obje = (listaBO)eliminar;
            SqlCommand coma = new SqlCommand("delete from asistencia where id_asistencia=@id");
            coma.Parameters.Add("id", SqlDbType.Int).Value = obje.Id;
            coma.CommandType = CommandType.Text;
            return conectar.EjecutarComando(coma);
        }
        public int actualizar(object actualizar)
        {
            listaBO obejto = (listaBO)actualizar;
            SqlCommand dir = new SqlCommand("update asistencia set fecha=@fecha,id_alumno=@id_alum where id_asitencia=@id");
            dir.Parameters.Add("@fecha", SqlDbType.VarChar).Value = obejto.Fecha;//----
            dir.Parameters.Add("@id_alum", SqlDbType.VarChar).Value = obejto.Id_alumno;
                 dir.Parameters.Add("id", SqlDbType.Int).Value = obejto.Id;

            dir.CommandType = CommandType.Text;
            return conectar.EjecutarComando(dir);
        }
        public DataSet mostrarlista()
        {
            SqlCommand comando = new SqlCommand("select * from asistencia");
            comando.CommandType = CommandType.Text;
            return conectar.EjecutarSentencia(comando);
        }






    }
}
