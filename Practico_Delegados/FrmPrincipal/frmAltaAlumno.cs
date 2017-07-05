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
    public partial class frmAltaAlumno : Form
    {
        public frmAltaAlumno()
        {
            InitializeComponent();
        }

        private void textBox4_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            
            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            open.Title = "Seleccione una foto..";
            open.Multiselect = false;
            open.ShowDialog();

        }
    }
}
