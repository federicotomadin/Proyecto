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
    public partial class frmTestDelegados : Form
    {

        public event testDelegado actualizarNombrePorDelegado;

        public frmTestDelegados()
        {
            InitializeComponent();
            this.ConfigurarOpenSaveFileDialog();
                             
        }

        private void ConfigurarOpenSaveFileDialog()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            
            open.Title = "Seleccione una foto..";
            open.Multiselect = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.actualizarNombrePorDelegado(textBox1.Text);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
