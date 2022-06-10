using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Entity;

namespace Dall
{
    public class EntrenadorRepository
    {
        private readonly SqlConnection connecion;
        public EntrenadorRepository(ConnectionManager connection)
        {
            connecion = connection._conexion;
        }
        public void Guardar(Entrenador entrenador)
        {
            using (var command = connecion.CreateCommand())
            {
                command.CommandText = "insert into Paciente(identificacion,nombre,fechaDeNacimiento,edad,direccion,sexo,estado,codigoMembresiaEntrenador,cantidadUsuarios,cantidadHorasDeEntrenamientosPorUsuario) values(@identificacion,@nombre,@fechaDeNacimiento,@edad,@direccion,@sexo,@estado,@codigoMembresiaEntrenador,@cantidadUsuarios,@cantidadHorasDeEntrenamientosPorUsuario)";
                command.Parameters.Add(new SqlParameter("@identificacion", entrenador.Identificacion));
                command.Parameters.Add(new SqlParameter("@nombre", entrenador.Nombre));
                command.Parameters.Add(new SqlParameter("@fechaDeNacimiento", entrenador.FechaDeNacimiento));
                command.Parameters.Add(new SqlParameter("@edad", entrenador.Edad));
                command.Parameters.Add(new SqlParameter("@direccion", entrenador.Direccion));
                command.Parameters.Add(new SqlParameter("@sexo", entrenador.Sexo));
                command.Parameters.Add(new SqlParameter("@estado", entrenador.Estado));
                command.Parameters.Add(new SqlParameter("@codigoMembresiaEntrenador", entrenador.CodigoMembresiaEntrenador));
                command.Parameters.Add(new SqlParameter("@cantidadUsuarios", entrenador.CantidadDeUsuarios));
                command.Parameters.Add(new SqlParameter("@cantidadHorasDeEntrenamientosPorUsuario", entrenador.CantidadHorasDeEntrenamientosPorUsuario));
                var filas = command.ExecuteNonQuery();
            }
        }
        private Entrenador MapearEntrenador(SqlDataReader Reader)
        {
            if (!Reader.HasRows) return null;
            Entrenador entrenador = new Entrenador();
            entrenador.Identificacion = Reader.GetString(0);
            entrenador.Nombre = Reader.GetString(1);
            entrenador.FechaDeNacimiento = Reader.GetDateTime(2);
            entrenador.Edad = Reader.GetString(3);
            entrenador.Direccion = Reader.GetString(4);
            entrenador.Sexo = Reader.GetString(5);
            entrenador.Estado = Reader.GetString(6);
            entrenador.CodigoMembresiaEntrenador = Reader.GetString(7);
            entrenador.CantidadDeUsuarios = Reader.GetString(8);
            entrenador.CantidadHorasDeEntrenamientosPorUsuario = Reader.GetString(9);
            return entrenador;
        }
        public List<Entrenador> BuscarPorIdentificacion(string identificacion)
        {
            List<Entrenador> entrenadores = new List<Entrenador>();
            using (var command = connecion.CreateCommand())
            {
                command.CommandText = "select * from Entrenador where identificacion=@identificacion";
                command.Parameters.Add(new SqlParameter("@identificacion", identificacion));
                var Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Entrenador entrenador = MapearEntrenador(Reader);
                    entrenadores.Add(entrenador);
                }
                Reader.Close();
            }
            return entrenadores;
        }
        public List<Entrenador> Consultar()
        {
            List<Entrenador> entrenadores = new List<Entrenador>();
            using (var command = connecion.CreateCommand())
            {
                command.CommandText = "select *from Entrenador";
                var Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    Entrenador entrenador = new Entrenador();
                    entrenador.Identificacion = Reader.GetString(0);
                    entrenador.Nombre = Reader.GetString(1);
                    entrenador.FechaDeNacimiento = Reader.GetDateTime(2);
                    entrenador.Edad = Reader.GetString(3);
                    entrenador.Direccion = Reader.GetString(4);
                    entrenador.Sexo = Reader.GetString(5);
                    entrenador.Estado = Reader.GetString(6);
                    entrenador.CodigoMembresiaEntrenador = Reader.GetString(7);
                    entrenador.CantidadDeUsuarios = Reader.GetString(8);
                    entrenador.CantidadHorasDeEntrenamientosPorUsuario = Reader.GetString(9);
                    entrenadores.Add(entrenador);
                }
                Reader.Close();
            }
            return entrenadores;
        }
    }
}
