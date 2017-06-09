using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18_deposito_autos
{
    public class Bicicleta
    {
        public string marca;
        public float rodado;
        public float precio;


        public Bicicleta(string marca, float rodado, float precio)
        {
            this.marca = marca;
            this.rodado = rodado;
            this.precio = precio;
        }


        public override bool Equals(object obj)
        {
            if (obj is Bicicleta && (Bicicleta)obj == this) return true;
            else return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Marca " + this.marca);
            sb.AppendLine("Rodado " + this.rodado);
            sb.AppendLine("Precio " + this.precio);

            return sb.ToString();
        }
    }
}
