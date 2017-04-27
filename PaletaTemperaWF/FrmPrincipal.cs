using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;



namespace PaletaTemperaWF
{
    public partial class FrmPrincipal : Form
    {
        private List<Tempera> _lista;

        public FrmPrincipal()
        {
            InitializeComponent();
            this._lista = new List<Tempera>();
            this.Text = "Gestion de Temperas";
            this.WindowState = FormWindowState.Maximized;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmTempera tempera = new FrmTempera();
            tempera.StartPosition = FormStartPosition.CenterScreen;
           
            if (tempera.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                
                this._lista.Add(tempera.Tempera);
                MessageBox.Show("La tempera se guardo correctamente", "Se guardo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
 
            }
           
        }

        private void mostrarTemperasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(this._lista);

            mostrar.Show();
        }
    }
}
