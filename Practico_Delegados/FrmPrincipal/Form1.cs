using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FrmPrincipal
{
    public partial class Form1 : Form
    {
        public event testDelegado actualizarNombrePorDelegado;

        public Form1()
        {
            InitializeComponent();
           
        }


        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados dele = new frmTestDelegados();
            dele.Show();

            //frmTestDelegados testDelegados = new frmTestDelegados();
            ////testDelegados+=new frmTestDelegados.testDelegado()
        }

 

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos datos = new frmDatos();
            datos.Show();
        }

        private void alumnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAltaAlumno alta = new frmAltaAlumno();
            alta.
            alta.Show();
        }
    }
}
