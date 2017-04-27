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
    public partial class FrmMostrar : Form
    {
        private List<Tempera> _temperas;

        public  List<Tempera> RefrescarLista(List<Tempera> tempera)
        {
           
            foreach (Tempera item in _temperas)
            {
                this.listMostrar.Items.Add(Tempera.Mostrar(item));
            }
            return _temperas;
        }

        public FrmMostrar()
        {
            InitializeComponent();
           
        }


        public FrmMostrar(List<Tempera> temperas):this()
        {
            this._temperas = temperas;
            foreach (Tempera item in _temperas)
            {
                this.listMostrar.Items.Add(Tempera.Mostrar(item));
            }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {

        }

        private void listMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.listMostrar.SelectedIndex != -1)
            {
                this._temperas.RemoveAt(this.listMostrar.SelectedIndex);
            }
            this.listMostrar.Items.Clear();
            this.RefrescarLista(_temperas);
            
        }

       

    }
}
