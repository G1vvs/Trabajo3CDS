using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoBOL;
using TrabajoDAL;

namespace TrabajoBL
{
    public class AlumnosBL
    {
        // Método para insertar un nuevo alumno en la base de datos.
        public static bool InsertarAlumno(AlumnosBOL alum, out string fallas)
        {
            try
            {
                // Crea una instancia de la clase AlumnoDAL para acceder a la base de datos.
                TrabajoDAL.AlumnoDAL obj = new TrabajoDAL.AlumnoDAL();
                // Llama al método InsertarAlumno de la capa de acceso a datos para insertar el alumno.
                obj.InsertarAlumno(alum);
                fallas = string.Empty; // Si la inserción es exitosa, no hay fallas.
                return true; // Retorna true para indicar éxito.
            }
            catch (Exception x)
            {
                // Captura cualquier excepción y almacena el mensaje de error en 'fallas'.
                fallas = x.Message;
                return false; // Retorna false para indicar un fallo en la inserción.
            }
        }

        // Método para modificar la información de un alumno existente.
        public static bool Modificar(AlumnosBOL alum, out string fallas)
        {
            try
            {
                // Crea una instancia de la clase AlumnoDAL.
                TrabajoDAL.AlumnoDAL obj = new TrabajoDAL.AlumnoDAL();
                // Llama al método Modificar de la capa de acceso a datos para actualizar el alumno.
                obj.Modificar(alum);
                fallas = string.Empty; // No hay fallas si la modificación es exitosa.
                return true; // Retorna true para indicar éxito.
            }
            catch (Exception x)
            {
                // Captura cualquier excepción y almacena el mensaje de error en 'fallas'.
                fallas = x.Message;
                return false; // Retorna false para indicar un fallo en la modificación.
            }
        }

        // Método para borrar un alumno de la base de datos utilizando su identificador.
        public static bool Borrar(int IDAlumno, out string fallas)
        {
            try
            {
                // Crea una instancia de la clase AlumnoDAL.
                TrabajoDAL.AlumnoDAL obj = new TrabajoDAL.AlumnoDAL();
                // Llama al método Borrar de la capa de acceso a datos para eliminar el alumno.
                obj.Borrar(IDAlumno);
                fallas = string.Empty; // No hay fallas si la eliminación es exitosa.
                return true; // Retorna true para indicar éxito.
            }
            catch (Exception x)
            {
                // Captura cualquier excepción y almacena el mensaje de error en 'fallas'.
                fallas = x.Message;
                return false; // Retorna false para indicar un fallo en la eliminación.
            }
        }

        // Método para seleccionar todos los alumnos de la base de datos.
        public static List<AlumnosBOL> SeleccionarTodo()
        {
            List<AlumnosBOL> lista = new List<AlumnosBOL>(); // Lista para almacenar los alumnos.
            try
            {
                // Crea una instancia de la clase AlumnoDAL.
                TrabajoDAL.AlumnoDAL obj = new TrabajoDAL.AlumnoDAL();
                // Llama al método SeleccionarTodo para obtener todos los alumnos.
                lista = obj.SelecionarTodo();
                return lista; // Retorna la lista de alumnos.
            }
            catch (Exception)
            {
                return null; // Retorna null si ocurre un error.
            }
        }

        // Método para seleccionar un alumno específico utilizando su identificador.
        public static AlumnosBOL SeleccionarUno(int IDAlumno)
        {
            AlumnosBOL alumno = new AlumnosBOL(); // Objeto para almacenar el alumno.
            try
            {
                // Crea una instancia de la clase AlumnoDAL.
                TrabajoDAL.AlumnoDAL obj = new TrabajoDAL.AlumnoDAL();
                // Llama al método SeleccionarUno para obtener el alumno específico.
                alumno = obj.SeleccionarUno(IDAlumno);
                return alumno; // Retorna el alumno encontrado.
            }
            catch (Exception)
            {
                return null; // Retorna null si ocurre un error.
            }
        }

        // Método para verificar si los datos de un alumno ya existen en la base de datos.
        public int DatosRepetidos(AlumnosBOL alumno)
        {
            AlumnoDAL dal = new AlumnoDAL(); // Crea una instancia de AlumnoDAL.
            int count = dal.DatosRepetidos(alumno); // Llama al método DatosRepetidos para contar registros.
            return count; // Retorna la cantidad de registros repetidos encontrados.
        }
    }



}
