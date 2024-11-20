using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoBOL;

namespace Trabajo_2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

      

        private void integracionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumno formalumnos = new Alumno();
            formalumnos.MdiParent = this.MdiParent;
            formalumnos.Show();
        }

        private void asignaturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Asignaturas formasigna = new Asignaturas();
            formasigna.MdiParent = this.MdiParent;
            formasigna.Show();
        }
    }
}
