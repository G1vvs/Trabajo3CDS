using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoBL;
using TrabajoBOL;

namespace Trabajo_2
{
    // Definición de la clase Asignaturas que hereda de Form (forma de Windows)
    public partial class Asignaturas : Form
    {
        // Variable para almacenar el ID de la asignatura que se está modificando
        string IDGlobal = "";

        // Constructor de la clase Asignaturas
        public Asignaturas()
        {
            InitializeComponent(); // Inicializa los componentes de la interfaz de usuario
        }

        // Método que se ejecuta al cargar el formulario
        private void Asignaturas_Load(object sender, EventArgs e)
        {
            listar(); // matisacowea
        }

        // Método que se ejecuta al hacer clic en el botón de guardar (BT_guardarA)
        private void BT_guardarA_Click(object sender, EventArgs e)
        {
            // Instancias de la lógica de negocio y objeto de asignatura
            AsignaturaBL asignaturaBL = new AsignaturaBL();
            AsignaturaBOL asignatura = new AsignaturaBOL();

            // Validación del campo Nombre de Asignatura
            if (string.IsNullOrWhiteSpace(Tb_nomasig.Text))
            {
                MessageBox.Show("El campo Nombre de Asignatura no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Tb_nomasig.Focus(); // Coloca el foco en el campo Nombre de Asignatura
                return; // Sale del método si hay error
            }

            // Validación del campo Cantidad de Créditos
            if (string.IsNullOrWhiteSpace(Tb_creditos.Text))
            {
                MessageBox.Show("El campo Cantidad de Creditos no puede estar vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Tb_creditos.Focus(); // Coloca el foco en el campo Cantidad de Créditos
                return; // Sale del método si hay error
            }

            // Si IDGlobal está vacío, se considera que es una nueva inserción
            if (string.IsNullOrEmpty(IDGlobal))
            {
                // Crear un nuevo objeto AsignaturaBOL
                AsignaturaBOL asig = new AsignaturaBOL();
                asig.NombreAsignatura = Tb_nomasig.Text; // Asigna el nombre de la asignatura
                asig.Creditos = Convert.ToInt32(Tb_creditos.Text); // Asigna los créditos
                AlumnoAsignatura.MiWS ws = new AlumnoAsignatura.MiWS();
                ws.GuardarAsig(Tb_nomasig.Text, Convert.ToInt32(Tb_creditos.Text));

                string falla; // Variable para capturar errores
                int cont = Convert.ToInt32(asignaturaBL.DatosRepetidos(asig)); // Verifica si la asignatura ya existe

                // Si no hay asignaturas repetidas
                if (cont == 0)
                {
                    // Llama al método de inserción y pasa el objeto asig
                    bool res = AsignaturaBL.InsertarAsigna(asig, out falla);
                    if (res) // Si la inserción fue exitosa
                    {
                        MessageBox.Show("Registro insertado"); // Mensaje de éxito
                        listar(); // Actualiza el DataGridView llamando al método listar
                        Tb_nomasig.Text = ""; // Limpia el campo Nombre de Asignatura
                        Tb_creditos.Text = ""; // Limpia el campo Cantidad de Créditos
                    }
                    else // Si hubo un error al guardar
                    {
                        MessageBox.Show($"Ocurrió un error al guardar la asignatura: {falla}"); // Mensaje de error
                    }
                }
                else // Si la asignatura ya existe
                {
                    MessageBox.Show("Los datos que intentas ingresar ya se encuentran registrados"); // Mensaje de advertencia
                }
            }
            else // Si hay un IDGlobal, significa que se está modificando un registro existente
            {
                string falla; // Variable para capturar errores
                int Id = Convert.ToInt32(IDGlobal); // Convierte IDGlobal a entero
                AsignaturaBOL asignaturaBOL = AsignaturaBL.SeleccionarUno(Id); // Obtiene el registro actual

                // Actualiza el objeto con los nuevos datos ingresados
                asignaturaBOL.NombreAsignatura = Tb_nomasig.Text; // Actualiza el nombre
                asignaturaBOL.Creditos = Convert.ToInt32(Tb_creditos.Text); // Actualiza los créditos

                // Llama a la función para modificar el registro en la base de datos
                bool mod = AsignaturaBL.Modificar(asignaturaBOL, out falla);
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

                Tb_nomasig.Text = ""; // Limpia el campo Nombre de Asignatura
                Tb_creditos.Text = ""; // Limpia el campo Cantidad de Créditos
            }
        }

        // Método para listar todas las asignaturas en el DataGridView
        private void listar()
        {
            List<AsignaturaBOL> asignatura = AsignaturaBL.SeleccionarTodo(); // Obtiene todas las asignaturas
            DG_asignatura.DataSource = asignatura; // Asigna la lista al DataGridView
        }

        // Método que se ejecuta al seleccionar la opción de modificar en el menú
        private void modificarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(DG_asignatura.SelectedRows[0].Cells[0].Value); // Obtiene el ID de la fila seleccionada
            IDGlobal = Convert.ToString(ID); // Almacena el ID en IDGlobal
            AsignaturaBOL asignaturaBOL = AsignaturaBL.SeleccionarUno(ID); // Obtiene los datos de la asignatura
            Tb_nomasig.Text = asignaturaBOL.NombreAsignatura; // Muestra el nombre en el campo de texto
            Tb_creditos.Text = asignaturaBOL.Creditos.ToString(); // Muestra los créditos en el campo de texto
        }

        // Método que se ejecuta al seleccionar la opción de eliminar en el menú
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string falla; // Variable para capturar errores
            int ID = Convert.ToInt32(DG_asignatura.SelectedRows[0].Cells[0].Value); // Obtiene el ID de la fila seleccionada
            bool Borrar = AsignaturaBL.Borrar(ID, out falla); // Llama al método para borrar la asignatura
            if (Borrar) // Si la eliminación fue exitosa
            {
                MessageBox.Show("Asignatura eliminada"); // Mensaje de éxito
            }
            else // Si hubo un error al borrar
            {
                MessageBox.Show("Error" + falla); // Mensaje de error
            }
            listar(); // Actualiza el DataGridView
        }



        private void BT_descargaAsig_Click(object sender, EventArgs e)
        {
            AlumnoAsignatura.MiWS ws = new AlumnoAsignatura.MiWS();
            List<AlumnoAsignatura.Asignatura> lista = new List<AlumnoAsignatura.Asignatura>();
            lista = ws.Listarasignatura().ToList();
            string fallas;
            foreach (var item in lista)
            {
                AsignaturaBOL asig = new AsignaturaBOL
                {
                    NombreAsignatura = item.NombreAsignatura,
                    Creditos = item.Creditos
                    
                };
                AsignaturaBL.InsertarAsigna(asig, out fallas);

                listar();
            }
        }
    }

}
