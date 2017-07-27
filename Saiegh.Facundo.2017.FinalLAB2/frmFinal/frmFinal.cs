using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Entidades;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace frmFinal
{
    public partial class frmFinal : Form
    {

        MEspecialista medicoEspecialista;
        MGeneral medicoGeneral;
        Thread mocker;
        Queue<Paciente> pacientesEnEspera;
        Paciente p1;
        Paciente p2;

        void AtenderPacientes(IMedico imed)
        {
            if (this.pacientesEnEspera.Count > 0)
            {
                imed.iniciarAtencion(pacientesEnEspera.Dequeue());
            }
        }

        void FinAtencion(Paciente p, Medico m)
        {
            MessageBox.Show("termino la atencion de " + p + " por " + m);
        }

        public frmFinal()
        {
            InitializeComponent();
            this.medicoEspecialista = new MEspecialista("jorge", "iglesias", MEspecialista.EEspecialidad.Traumatologo);
            this.medicoGeneral = new MGeneral("luis", "salinas");
        }

        
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.MockPacientes();
            //seruializar
          //  MessageBox.Show(this.pacientesEnEspera.Count.ToString());
            List<Paciente> serializableLIst = new List<Paciente>(this.pacientesEnEspera);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Paciente>));
        
            StreamWriter sw = new StreamWriter("serializacion.xml");
            serializer.Serialize(sw, serializableLIst);
            sw.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //med general
            AtenderPacientes(((IMedico)this.medicoGeneral));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //desserializar
            string filename = "serializacion.xml";
            XmlSerializer serializer = new      XmlSerializer(typeof(List<Paciente>));
        
            FileStream fs = new FileStream(filename, FileMode.Open);
            XmlReader reader = XmlReader.Create(fs);

            // Declare an object variable of the type to be deserialized.
            List<Paciente> lp;

            // Use the Deserialize method to restore the object's state.
            lp = (List<Paciente>)serializer.Deserialize(reader);
            fs.Close();
            this.pacientesEnEspera = new Queue<Paciente>(lp);  

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //med especialista
            AtenderPacientes(((IMedico)this.medicoEspecialista));
          
        }

        void MockPacientes()
        {
            this.pacientesEnEspera.Enqueue(p1);
            this.pacientesEnEspera.Enqueue(p2);
            Thread.Sleep(5000);
        }

        private void frmFinal_Load(object sender, EventArgs e)
        {
            this.p1 = new Paciente("juan", "perez");
            this.p2 = new Paciente("vladimir", "garcia");
            this.pacientesEnEspera = new Queue<Paciente>();

          //  this.pacientesEnEspera.Enqueue(p1);
          //  this.pacientesEnEspera.Enqueue(p2);
         //   this.mocker = new Thread(); //para q? con q?

            
        }
        private void frmFinal_FormClosing(object sender, EventArgs e)
        {
            if (this.mocker.IsAlive) this.mocker.Abort();
        }
    }
}
