using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verduleria
{
    class Fruta
    {
        public float peso;
        public int volumen;

        public Fruta()
        {
            Random random=new Random();

            this.peso = random.Next(1, 5);
            this.volumen = random.Next(1, 10);
            
         }
    }
}
