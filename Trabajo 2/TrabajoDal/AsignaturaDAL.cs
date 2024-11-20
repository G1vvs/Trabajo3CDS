using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoBOL;

namespace TrabajoDAL
{
    public class AsignaturaDAL
    {
        // Cadena de conexión para conectarse a la base de datos.
        string connectionString = "Data Source=L301-09\\SQLEXPRESS;Initial Catalog=Trabajo2;Integrated Security=True;";

        // Método para insertar una nueva asignatura en la base de datos.
        public void InsertarAsigna(AsignaturaBOL asig)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open(); // Abrir la conexión.

                // Consulta SQL para insertar un nuevo registro en la tabla Asignaturas.
                string query = "INSERT INTO Asignaturas (NombreAsignatura, Creditos) " +
                               "VALUES (@NombreAsignatura, @Creditos)";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Asignar valores a los parámetros de la consulta.
                    comando.Parameters.AddWithValue("@NombreAsignatura", asig.NombreAsignatura);
                    comando.Parameters.AddWithValue("@Creditos", asig.Creditos);

                    comando.ExecuteNonQuery(); // Ejecutar la consulta.
                }
            }
        }

        // Método para modificar una asignatura existente en la base de datos.
        public void Modificar(AsignaturaBOL asig)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open(); // Abrir la conexión.

                // Consulta SQL para actualizar la información de la asignatura.
                string query = "UPDATE Asignaturas " +
                               "SET NombreAsignatura = @NombreAsignatura, " +
                               "Creditos = @Creditos " +
                               "WHERE IDAsignatura = @IDAsignatura";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Asignar valores a los parámetros de la consulta.
                    comando.Parameters.AddWithValue("@IDAsignatura", asig.IDAsignatura);
                    comando.Parameters.AddWithValue("@NombreAsignatura", asig.NombreAsignatura);
                    comando.Parameters.AddWithValue("@Creditos", asig.Creditos);

                    comando.ExecuteNonQuery(); // Ejecutar la consulta.
                }
            }
        }

        // Método para borrar una asignatura de la base de datos usando su ID.
        public int Borrar(int IDAsignatura)
        {
            int res = 0; // Variable para almacenar el resultado de la operación.
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open(); // Abrir la conexión.

                // Consulta SQL para eliminar un registro de la tabla Asignaturas.
                string query = "DELETE FROM Asignaturas WHERE IDAsignatura = @IDAsignatura";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@IDAsignatura", IDAsignatura); // Añadir el ID de la asignatura a eliminar.
                    res = comando.ExecuteNonQuery(); // Ejecutar la consulta y almacenar el número de filas afectadas.
                }
            }
            return res; // Retornar el número de filas eliminadas.
        }

        // Método para seleccionar todas las asignaturas de la base de datos.
        public List<AsignaturaBOL> SelecionarTodo()
        {
            List<AsignaturaBOL> asignaturas = new List<AsignaturaBOL>(); // Lista para almacenar las asignaturas.

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open(); // Abrir la conexión.

                // Consulta SQL para seleccionar todos los registros de la tabla Asignaturas.
                string query = "SELECT IDAsignatura, NombreAsignatura, Creditos " +
                               "FROM Asignaturas";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader leer = comando.ExecuteReader()) // Ejecutar la consulta y obtener un lector.
                    {
                        while (leer.Read()) // Leer cada registro.
                        {
                            AsignaturaBOL asignaturaBOLs = new AsignaturaBOL(); // Crear un nuevo objeto AsignaturaBOL.
                            asignaturaBOLs.IDAsignatura = leer.GetInt32(0); // Asignar el ID.
                            asignaturaBOLs.NombreAsignatura = leer.GetString(1); // Asignar el nombre de la asignatura.
                            asignaturaBOLs.Creditos = leer.GetInt32(2); // Asignar los créditos.

                            asignaturas.Add(asignaturaBOLs); // Añadir la asignatura a la lista.
                        }
                    }
                }
            }
            return asignaturas; // Retornar la lista de asignaturas.
        }

        // Método para seleccionar una asignatura específica usando su ID.
        public AsignaturaBOL SeleccionarUno(int IDAsignatura)
        {
            AsignaturaBOL obj = null; // Inicializar el objeto a null.
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open(); // Abrir la conexión.

                // Consulta SQL para seleccionar un registro específico de la tabla Asignaturas.
                string query = "SELECT IDAsignatura, NombreAsignatura, Creditos " +
                               "FROM Asignaturas WHERE IDAsignatura = @IDAsignatura";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@IDAsignatura", IDAsignatura); // Añadir el ID de la asignatura a seleccionar.

                    using (SqlDataReader leer = comando.ExecuteReader()) // Ejecutar la consulta y obtener un lector.
                    {
                        if (leer.Read()) // Si se encuentra un registro.
                        {
                            obj = new AsignaturaBOL // Crear un nuevo objeto AsignaturaBOL.
                            {
                                IDAsignatura = leer.GetInt32(0), // Asignar el ID.
                                NombreAsignatura = leer.GetString(1), // Asignar el nombre de la asignatura.
                                Creditos = leer.GetInt32(2) // Asignar los créditos.
                            };
                        }
                    }
                }
            }
            return obj; // Retornar el objeto de la asignatura encontrada, o null si no se encontró.
        }

        // Método para contar registros de asignaturas que tienen el mismo nombre.
        public int DatosRepetidos(AsignaturaBOL asig)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open(); // Abrir la conexión.

                // Consulta SQL para contar los registros que coinciden con el nombre de la asignatura proporcionado.
                string query = "SELECT COUNT(*) FROM Asignaturas WHERE NombreAsignatura = @NombreAsignatura";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@NombreAsignatura", asig.NombreAsignatura ?? (object)DBNull.Value); // Añadir el nombre de la asignatura a contar.

                    // Ejecutar la consulta y convertir el resultado a un entero.
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result; // Retornar el conteo de registros encontrados.
                }
            }
        }
    }



}

