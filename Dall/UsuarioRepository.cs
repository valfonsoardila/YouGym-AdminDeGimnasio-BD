using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Entity;

namespace Dall
{
    public class UsuarioRepository
    {
        private readonly SqlConnection connecion;
        public UsuarioRepository(ConnectionManager connection)
        {
            connecion = connection._conexion;
        }
        public void Guardar(Usuario usuario)
        {
            using (var command = connecion.CreateCommand())
            {
                command.CommandText = "insert into Paciente(identificacion,nombre,fechaDeNacimiento,edad,direccion,sexo,estado,horaDeEntrenamiento,fechaDeIngresoGym,fechaDeSalidaGym,codigoMembresiaUsuario) values(@identificacion,@nombre,@fechaDeNacimiento,@edad,@direccion,@sexo,@estado,@horaDeEntrenamiento,@FechaDeIngresoGym,@FechaDeSalidaGym,@codigoMembresiaUsuario)";
                command.Parameters.Add(new SqlParameter("@identificacion", usuario.Identificacion));
                command.Parameters.Add(new SqlParameter("@nombre", usuario.Nombre));
                command.Parameters.Add(new SqlParameter("@FechaDeNacimiento", usuario.FechaDeSalidaGym));
                command.Parameters.Add(new SqlParameter("@edad", usuario.Edad));
                command.Parameters.Add(new SqlParameter("@direccion", usuario.Direccion));
                command.Parameters.Add(new SqlParameter("@sexo", usuario.Sexo));
                command.Parameters.Add(new SqlParameter("@estado", usuario.Estado));
                command.Parameters.Add(new SqlParameter("@horaDeEntrenamiento", usuario.HoraDeEntrenamiento));
                command.Parameters.Add(new SqlParameter("@fechaDeIngresoGym", usuario.FechaDeIngresoGym));
                command.Parameters.Add(new SqlParameter("@fechaDeSalidaGym", usuario.FechaDeSalidaGym));
                command.Parameters.Add(new SqlParameter("@codigoMembresiaUsuario", usuario.CodigoMembresiaUsuario));
                var filas = command.ExecuteNonQuery();
            }
        }
        private Usuario MapearUsuario(SqlDataReader Reader)
        {
            if (!Reader.HasRows) return null;
            Usuario usuario = new Usuario();
            usuario.Identificacion = Reader.GetString(0);
            usuario.Nombre = Reader.GetString(1);
            usuario.FechaDeNacimiento = Reader.GetDateTime(2);
            usuario.Edad = Reader.GetString(3);
            usuario.Direccion = Reader.GetString(4);
            usuario.Sexo = Reader.GetString(5);
            usuario.Estado = Reader.GetString(6);
            usuario.HoraDeEntrenamiento = Reader.GetString(7);
            usuario.FechaDeIngresoGym = Reader.GetDateTime(8);
            usuario.FechaDeSalidaGym = Reader.GetDateTime(9);
            usuario.CodigoMembresiaUsuario = Reader.GetString(10);
            return usuario;
        }
        public List<Usuario> BuscarPorIdentificacion(string identificacion)
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (var command = connecion.CreateCommand())
            {
                command.CommandText = "select * from Usuario where identificacion=@identificacion";
                command.Parameters.Add(new SqlParameter("@identificacion", identificacion));
                var Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Usuario usuario = MapearUsuario(Reader);
                    usuarios.Add(usuario);
                }
                Reader.Close();
            }
            return usuarios;
        }
        public List<Usuario> Consultar()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (var command = connecion.CreateCommand())
            {
                command.CommandText = "select *from Usuario";
                var Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Identificacion = Reader.GetString(0);
                    usuario.Nombre = Reader.GetString(1);
                    usuario.FechaDeNacimiento = Reader.GetDateTime(2);
                    usuario.Edad = Reader.GetString(3);
                    usuario.Direccion = Reader.GetString(3);
                    usuario.Sexo = Reader.GetString(5);
                    usuario.Estado = Reader.GetString(6);
                    usuario.HoraDeEntrenamiento = Reader.GetString(7);
                    usuario.FechaDeIngresoGym = Reader.GetDateTime(8);
                    usuario.FechaDeSalidaGym = Reader.GetDateTime(9);
                    usuario.CodigoMembresiaUsuario = Reader.GetString(10);
                    usuarios.Add(usuario);
                }
                Reader.Close();
            }
            return usuarios;
        }
    }
}
