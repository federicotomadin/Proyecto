using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbreria
{
   public class Goma:Utiles
    {
        private bool _soloLapiz;

        public Goma()
        { }

        public Goma(bool soloLapiz)
            : base()
        {

            this._soloLapiz = soloLapiz;
        }

        public bool SoloLapiz
        {
            get { return this._soloLapiz; }
            set { this._soloLapiz = value; }
        }


        public override int Precio
        {
            get;
            set;
        }

        public override string Marca
        {
            get;
            set;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.UtilesToString());
            sb.AppendLine("Solo Lapiz " + this._soloLapiz);

            return sb.ToString();
        }
    }
}
