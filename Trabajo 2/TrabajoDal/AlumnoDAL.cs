using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TrabajoBOL;

namespace TrabajoDAL
{
    public class AlumnoDAL
    {
        // Cadena de conexión para conectarse a la base de datos.
        string connectionString = "Data Source=L301-09\\SQLEXPRESS;Initial Catalog=Trabajo2;Integrated Security=True;";

        // Método para insertar un nuevo alumno en la base de datos.
        public void InsertarAlumno(AlumnosBOL alum)
        {
            // Usar 'using' garantiza que la conexión se cierre automáticamente al finalizar.
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open(); // Abrir la conexión a la base de datos.

                // Consulta SQL para insertar un nuevo registro en la tabla Alumno.
                string query = "INSERT INTO Alumno (Nombre, ApellidoPAt, ApellidoMat, Email, NumeroMatricula) " +
                               "VALUES (@Nombre, @ApellidoPAt, @ApellidoMat, @Email, @NumeroMatricula)";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Asignar valores a los parámetros de la consulta.
                    comando.Parameters.AddWithValue("@Nombre", alum.Nombre);
                    comando.Parameters.AddWithValue("@ApellidoPAt", alum.ApellidoPAt);
                    comando.Parameters.AddWithValue("@ApellidoMat", alum.ApellidoMat);
                    comando.Parameters.AddWithValue("@Email", alum.Email);
                    comando.Parameters.AddWithValue("@NumeroMatricula", alum.NumeroMatricula);

                    comando.ExecuteNonQuery(); // Ejecutar la consulta.
                }
            }
        }

        // Método para modificar un alumno existente en la base de datos.
        public void Modificar(AlumnosBOL alum)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open(); // Abrir la conexión.

                // Consulta SQL para actualizar la información del alumno.
                string query = "UPDATE Alumno " +
                               "SET Nombre = @Nombre, " +
                               "    ApellidoPAt = @ApellidoPAt, " +
                               "    ApellidoMat = @ApellidoMat, " +
                               "    Email = @Email, " +
                               "    NumeroMatricula = @NumeroMatricula " +
                               "WHERE IDAlumno = @IDAlumno";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Asignar valores a los parámetros de la consulta.
                    comando.Parameters.AddWithValue("@IDAlumno", alum.IDalumnos);
                    comando.Parameters.AddWithValue("@Nombre", alum.Nombre);
                    comando.Parameters.AddWithValue("@ApellidoPAt", alum.ApellidoPAt);
                    comando.Parameters.AddWithValue("@ApellidoMat", alum.ApellidoMat);
                    comando.Parameters.AddWithValue("@Email", alum.Email);
                    comando.Parameters.AddWithValue("@NumeroMatricula", alum.NumeroMatricula);

                    comando.ExecuteNonQuery(); // Ejecutar la consulta.
                }
            }
        }

        // Método para borrar un alumno de la base de datos usando su ID.
        public int Borrar(int IDAlumno)
        {
            int res = 0; // Variable para almacenar el resultado de la operación.
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open(); // Abrir la conexión.

                // Consulta SQL para eliminar un registro de la tabla Alumno.
                string query = "DELETE FROM Alumno WHERE IDAlumno = @IDAlumno";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@IDAlumno", IDAlumno); // Añadir el ID del alumno a eliminar.
                    res = comando.ExecuteNonQuery(); // Ejecutar la consulta y almacenar el número de filas afectadas.
                }
            }
            return res; // Retornar el número de filas eliminadas.
        }

        // Método para seleccionar todos los alumnos de la base de datos.
        public List<AlumnosBOL> SelecionarTodo()
        {
            List<AlumnosBOL> alumnos = new List<AlumnosBOL>(); // Lista para almacenar los alumnos.

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open(); // Abrir la conexión.

                // Consulta SQL para seleccionar todos los registros de la tabla Alumno.
                string query = "SELECT IDAlumno, Nombre, ApellidoPAt, ApellidoMat, Email, NumeroMatricula " +
                               "FROM Alumno";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader leer = comando.ExecuteReader()) // Ejecutar la consulta y obtener un lector.
                    {
                        while (leer.Read()) // Leer cada registro.
                        {
                            AlumnosBOL alumnosBOLs = new AlumnosBOL(); // Crear un nuevo objeto AlumnosBOL.
                            alumnosBOLs.IDalumnos = leer.GetInt32(0); // Asignar el ID.
                            alumnosBOLs.Nombre = leer.GetString(1); // Asignar el nombre.
                            alumnosBOLs.ApellidoPAt = leer.GetString(2); // Asignar el apellido paterno.
                            alumnosBOLs.ApellidoMat = leer.GetString(3); // Asignar el apellido materno.    
                            alumnosBOLs.Email = leer.GetString(4); // Asignar el email.
                            alumnosBOLs.NumeroMatricula = leer.GetString(5); // Asignar el número de matrícula.

                            alumnos.Add(alumnosBOLs); // Añadir el alumno a la lista.
                        }
                    }
                }
            }
            return alumnos; // Retornar la lista de alumnos.
        }

        // Método para seleccionar un alumno específico usando su ID.
        public AlumnosBOL SeleccionarUno(int IDAlumno)
        {
            AlumnosBOL obj = null; // Inicializar el objeto a null.
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open(); // Abrir la conexión.

                // Consulta SQL para seleccionar un registro específico de la tabla Alumno.
                string query = "SELECT IDAlumno, Nombre, ApellidoPAt, ApellidoMat, Email, NumeroMatricula " +
                               "FROM Alumno WHERE IDAlumno = @IDAlumno";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@IDAlumno", IDAlumno); // Añadir el ID del alumno a seleccionar.
                    using (SqlDataReader leer = comando.ExecuteReader()) // Ejecutar la consulta y obtener un lector.
                    {
                        if (leer.Read()) // Si se encuentra un registro.
                        {
                            obj = new AlumnosBOL(); // Crear un nuevo objeto AlumnosBOL.
                            obj.IDalumnos = leer.GetInt32(0); // Asignar el ID.
                            obj.Nombre = leer.GetString(1); // Asignar el nombre.
                            obj.ApellidoPAt = leer.GetString(2); // Asignar el apellido paterno.
                            obj.ApellidoMat = leer.GetString(3); // Asignar el apellido materno.
                            obj.Email = leer.GetString(4); // Asignar el email.
                            obj.NumeroMatricula = leer.GetString(5); // Asignar el número de matrícula.
                        }
                    }
                }
            }
            return obj; // Retornar el objeto del alumno encontrado, o null si no se encontró.
        }

        // Método para contar registros de alumnos que tienen datos repetidos (mismo email o número de matrícula).
        public int DatosRepetidos(AlumnosBOL alum)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open(); // Abrir la conexión.

                // Consulta SQL para contar los registros que coinciden con el email o número de matrícula proporcionados.
                string query = "SELECT COUNT(*) FROM Alumno WHERE Email = @Email OR NumeroMatricula = @Numeromatricula";
                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    // Asignar valores a los parámetros de la consulta, usando DBNull.Value si son nulos.
                    cmd.Parameters.AddWithValue("@Email", alum.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@NumeroMatricula", alum.NumeroMatricula ?? (object)DBNull.Value);

                    // Ejecutar la consulta y convertir el resultado a un entero.
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result; // Retornar el conteo de registros encontrados.
                }
            }
        }
    }


}
