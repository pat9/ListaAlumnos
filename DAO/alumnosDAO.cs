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
    class alumnosDAO
    {
        conexionDAO conectar = new conexionDAO();
        public int agregar(object agregar)
        {
            alumnoBO obejto = (alumnoBO)agregar;
            SqlCommand dir = new SqlCommand("INSERT INTO alumnos (nombres ,apellidos,grado ,grupo)VALUES (@nom,@apelido,@gra,@gru)");
           
            dir.Parameters.Add("@nom", SqlDbType.VarChar).Value = obejto.Nombres;//----
            dir.Parameters.Add("@apelido", SqlDbType.VarChar).Value = obejto.Apellidos;
            dir.Parameters.Add("@gra", SqlDbType.VarChar).Value = obejto.Grado;
            dir.Parameters.Add("@gru", SqlDbType.VarChar).Value = obejto.Grado;
            dir.CommandType = CommandType.Text;
        return    conectar.EjecutarComando(dir);

        }

        public int eliminar(object eliminar)
        {
            alumnoBO obje = (alumnoBO)eliminar;
            SqlCommand coma = new SqlCommand("delete from alumno where id=@id");
            coma.Parameters.Add("id", SqlDbType.Int).Value = obje.Id;
            coma.CommandType = CommandType.Text;
            return conectar.EjecutarComando(coma);
        }
        public int actualizar(object actualizar)
        {
            alumnoBO obejto = (alumnoBO)actualizar;
            SqlCommand dir = new SqlCommand("update lista set nombres=@nom,apellidos=@apelido,grado=@gra,grupo=@gru where id=@id");
            dir.Parameters.Add("@nom", SqlDbType.VarChar).Value = obejto.Nombres;//----
            dir.Parameters.Add("@apelido", SqlDbType.VarChar).Value = obejto.Apellidos;
            dir.Parameters.Add("@gra", SqlDbType.VarChar).Value = obejto.Grado;
            dir.Parameters.Add("@gru", SqlDbType.VarChar).Value = obejto.Grado;
            dir.CommandType = CommandType.Text;
            return conectar.EjecutarComando(dir);
        }
        public DataSet mostrarlista()
        {
            SqlCommand comando = new SqlCommand("select * from lista");
            comando.CommandType = CommandType.Text;
       return     conectar.EjecutarSentencia(comando);
        }
    }
}
