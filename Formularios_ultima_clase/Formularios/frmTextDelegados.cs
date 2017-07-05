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
    public partial class frmTextDelegados : Form
    {
        public frmTextDelegados()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ((frmPrincipal)this.Owner).variable(this.textBox1.Text);
            }

            catch (Exception)
            {
                MessageBox.Show("Hubo un error ");
            }
            
        }

      
    }
}
