using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class frmDatos : Form
    {
        private string ruta = "";

        public frmDatos()
        {
            InitializeComponent();

        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            frmTestDelegados testDelegado = new frmTestDelegados();
            testDelegado.actualizarNombrePorDelegado += new frmTestDelegados.testDelegado(ActualizarNombre);
            testDelegado.Show();
        }

        public void ActualizarNombre(string dato)
        {
            label1.Text = dato;
        }

        public void ActualizarFoto(string dato)
        {
            pictureBox1.ImageLocation = ruta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                ruta = open.FileName;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.ActualizarFoto(ruta);
        }
    }
}
