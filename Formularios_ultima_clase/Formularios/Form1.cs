using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmPrincipal : Form
    {
        public delegate void actualizarNombrePorDelegado(string dato);
        public actualizarNombrePorDelegado variable;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTextDelegados frm = new frmTextDelegados();
            frm.Show(this);

        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos frm = new frmDatos();
            //actualizarNombrePorDelegado del = new actualizarNombrePorDelegado(frm.ActualizarNombre);
            this.variable += frm.ActualizarNombre;
            frm.Show(this);
        }
    }
}
