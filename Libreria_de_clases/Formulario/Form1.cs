using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria_de_clases;

namespace Formulario
{
    public partial class Form1 : Form
    {
        static void ManejadorEvent()
        {
            MessageBox.Show("Se ha superado el limite de sueldo");
        }

        void ManejadorEvent2()
        {
            MessageBox.Show("Otro manejador de eventos");
        }

        static void empleado_sueldoMejorado(object sender,EventArgs e)
        {   

            MessageBox.Show("Empleado " + sender.ToString() + "Supero el limite de sueldo");
        }


        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado(txtNombre.Text, txtApellido.Text, (int.Parse(txtLegajo.Text)));
            emp.sueldoEventMejorado += Form1.empleado_sueldoMejorado;
            emp.sueldoEvent += Form1.ManejadorEvent;
            try
            {
           
            emp.Sueldo=int.Parse(txtSueldo.Text);
           
            
            }
            catch(Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
