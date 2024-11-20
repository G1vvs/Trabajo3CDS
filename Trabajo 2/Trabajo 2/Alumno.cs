using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoBL;
using TrabajoBOL;

namespace Trabajo_2
{
    // Definición de la clase Alumno que hereda de Form (forma de Windows)
    public partial class Alumno : Form
    {
        // Variable para almacenar el ID del alumno que se está modificando
        string IDGlobal = "";

        // Constructor de la clase Alumno
        public Alumno()
        {
            InitializeComponent(); // Inicializa los componentes de la interfaz de usuario
        }

        // Método que se ejecuta al hacer clic en el botón de guardar (BT_guardar)
        private void BT_guardar_Click(object sender, EventArgs e)
        {
            // Instancias de la lógica de negocio y objeto de alumno
            AlumnosBL alumnosBL = new AlumnosBL();
            AlumnosBOL alumno = new AlumnosBOL();

            // Validación del campo Nombre
            if (string.IsNullOrWhiteSpace(Tb_nom.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Tb_nom.Focus(); // Coloca el foco en el campo Nombre
                return; // Sale del método si hay error
            }
            // Validación del campo Apellido Paterno
            if (string.IsNullOrWhiteSpace(Tb_apepa.Text))
            {
                MessageBox.Show("El campo Apellido Paterno no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Tb_apepa.Focus(); // Coloca el foco en el campo Apellido Paterno
                return; // Sale del método si hay error
            }
            // Validación del campo Apellido Materno
            if (string.IsNullOrWhiteSpace(Tb_apema.Text))
            {
                MessageBox.Show("El campo Apellido Materno no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Tb_apema.Focus(); // Coloca el foco en el campo Apellido Materno
                return; // Sale del método si hay error
            }
            // Validación del campo Email
            if (string.IsNullOrWhiteSpace(Tb_email.Text))
            {
                MessageBox.Show("El campo Email no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Tb_email.Focus(); // Coloca el foco en el campo Email
                return; // Sale del método si hay error
            }
            // Validación del campo Matrícula
            if (string.IsNullOrWhiteSpace(Tb_matricula.Text))
            {
                MessageBox.Show("El campo Matrícula no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Tb_matricula.Focus(); // Coloca el foco en el campo Matrícula
                return; // Sale del método si hay error
            }

            // Si IDGlobal está vacío, se considera que es una nueva inserción
            if (string.IsNullOrEmpty(IDGlobal))
            {
                // Crear un nuevo objeto AlumnosBOL
                AlumnosBOL alum = new AlumnosBOL();
                alum.Nombre = Tb_nom.Text; // Asigna el nombre
                alum.ApellidoPAt = Tb_apepa.Text; // Asigna el apellido paterno
                alum.ApellidoMat = Tb_apema.Text; // Asigna el apellido materno
                alum.Email = Tb_email.Text; // Asigna el email
                alum.NumeroMatricula = Tb_matricula.Text; // Asigna el número de matrícula
                AlumnoAsignatura.MiWS ws = new AlumnoAsignatura.MiWS();
                ws.GuardarAlumn(Tb_nom.Text, Tb_apepa.Text, Tb_apema.Text, Tb_email.Text, Tb_matricula.Text);



                string falla; // Variable para capturar errores
                int cont = Convert.ToInt32(alumnosBL.DatosRepetidos(alum)); // Verifica si el alumno ya existe

                // Si no hay alumnos repetidos
                if (cont == 0)
                {
                    // Llama al método de inserción y pasa el objeto alum
                    bool res = AlumnosBL.InsertarAlumno(alum, out falla);
                    if (res) // Si la inserción fue exitosa
                    {
                        MessageBox.Show("Registro insertado"); // Mensaje de éxito
                        listar(); // Llama a listar para actualizar el DataGridView
                                  // Limpia los campos de entrada
                        Tb_nom.Text = "";
                        Tb_apepa.Text = "";
                        Tb_apema.Text = "";
                        Tb_email.Text = "";
                        Tb_matricula.Text = "";
                    }
                    else // Si hubo un error al guardar
                    {
                        MessageBox.Show($"Ocurrió un error al guardar el alumno: {falla}"); // Mensaje de error
                    }
                }
                else // Si el alumno ya existe
                {
                    MessageBox.Show("Los datos que intentas ingresar ya se encuentran registrados"); // Mensaje de advertencia
                }
            }
            else // Si hay un IDGlobal, significa que se está modificando un registro existente
            {
                string falla; // Variable para capturar errores
                int Id = Convert.ToInt32(IDGlobal); // Convierte IDGlobal a entero
                AlumnosBOL alumnosBOL = AlumnosBL.SeleccionarUno(Id); // Obtiene el registro actual

                // Actualiza el objeto con los nuevos datos ingresados
                alumnosBOL.Nombre = Tb_nom.Text; // Actualiza el nombre
                alumnosBOL.ApellidoPAt = Tb_apepa.Text; // Actualiza el apellido paterno
                alumnosBOL.ApellidoMat = Tb_apema.Text; // Actualiza el apellido materno
                alumnosBOL.Email = Tb_email.Text; // Actualiza el email
                alumnosBOL.NumeroMatricula = Tb_matricula.Text; // Actualiza la matrícula

                // Llama a la función para modificar el registro en la base de datos
                bool mod = AlumnosBL.Modificar(alumnosBOL, out falla);
                if (mod) // Si la modificación fue exitosa
                {
                    MessageBox.Show("Se ha modificado correctamente"); // Mensaje de éxito
                }
                else // Si hubo un error al modificar
                {
                    MessageBox.Show("No hemos podido modificar los datos: " + falla); // Mensaje de error
                }
                IDGlobal = ""; // Reinicia IDGlobal
                listar(); // Actualiza el DataGridView

                // Limpia los campos de entrada
                Tb_nom.Text = "";
                Tb_apepa.Text = "";
                Tb_apema.Text = "";
                Tb_email.Text = "";
                Tb_matricula.Text = "";
            }
        }

        // Método que se ejecuta al cargar el formulario
        private void Alumno_Load(object sender, EventArgs e)
        {
            listar(); // Llama al método listar para llenar el DataGridView con alumnos
        }

        // Método para listar todos los alumnos en el DataGridView
        private void listar()
        {
            List<AlumnosBOL> alumnos = AlumnosBL.SeleccionarTodo(); // Obtiene todos los alumnos
            DG_alumno.DataSource = alumnos; // Asigna la lista al DataGridView
        }

        // Método que se ejecuta al seleccionar la opción de modificar en el menú
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(DG_alumno.SelectedRows[0].Cells[0].Value); // Obtiene el ID de la fila seleccionada
            IDGlobal = Convert.ToString(ID); // Almacena el ID en IDGlobal
            AlumnosBOL alumnosBOL = AlumnosBL.SeleccionarUno(ID); // Obtiene los datos del alumno
                                                                  // Muestra los datos en los campos de texto
            Tb_nom.Text = alumnosBOL.Nombre;
            Tb_apepa.Text = alumnosBOL.ApellidoPAt;
            Tb_apema.Text = alumnosBOL.ApellidoMat;
            Tb_email.Text = alumnosBOL.Email;
            Tb_matricula.Text = alumnosBOL.NumeroMatricula;
        }

        // Método que se ejecuta al seleccionar la opción de eliminar en el menú
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string falla; // Variable para capturar errores
            int ID = Convert.ToInt32(DG_alumno.SelectedRows[0].Cells[0].Value); // Obtiene el ID de la fila seleccionada
            bool Borrar = AlumnosBL.Borrar(ID, out falla); // Llama al método para borrar el alumno
            if (Borrar) // Si la eliminación fue exitosa
            {
                MessageBox.Show("Alumno eliminado"); // Mensaje de éxito
            }
            else // Si hubo un error al borrar
            {
                MessageBox.Show("Error" + falla); // Mensaje de error
            }
            listar(); // Actualiza el DataGridView
        }

        private void BT_descarga_Click(object sender, EventArgs e)
        {
            AlumnoAsignatura.MiWS ws = new AlumnoAsignatura.MiWS();
            List<AlumnoAsignatura.Alumno> lista = new List<AlumnoAsignatura.Alumno>();
            lista = ws.Listaralumno().ToList();
            string fallas;
            foreach (var item in lista)
            {
                AlumnosBOL alumno = new AlumnosBOL
                {
                    Nombre = item.Nombre,
                    ApellidoPAt = item.ApellidoPAt,
                    ApellidoMat = item.ApellidoMat,
                    Email = item.Email,
                    NumeroMatricula = item.NumeroMatricula
                };
                AlumnosBL.InsertarAlumno(alumno, out fallas);
            }
           listar();
        }

    }
}

