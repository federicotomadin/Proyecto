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
    public partial class FrmTempera : Form
    {
        private Tempera _tempera;

        public FrmTempera()
        {
            InitializeComponent();

          
           foreach(ConsoleColor item in  Enum.GetValues(typeof(ConsoleColor))) 
           {

               cmbColor.Items.Add(item);
           }


               
            
        }


       

        public Tempera Tempera
        {
            get { return this._tempera; }
           
        }
        

        private void FrmTempera_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Realmente quiere salir del programa ?", "Para salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
       
            
        
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtCantidad.Text != "" && this.txtMarca.Text != "")
            {
 
            }
            
            
            
            this._tempera= new Tempera((ConsoleColor)cmbColor.SelectedItem,this.txtMarca.Text,Int32.Parse(txtCantidad.Text));
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            MessageBox.Show("La tempera se guardo correctamente", "Se guardo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

             this.Close();
            
        }
    }
}
