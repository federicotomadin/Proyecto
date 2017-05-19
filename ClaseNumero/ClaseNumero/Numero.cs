using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNumero
{
    public class Numero
    {
        protected double _numero;


        public double NumeroProp
        {
            get 
            {
                return _numero;
            }
        }

        public Numero(double numero)
        {
            this._numero = numero;
        }


        public static double operator +(Numero num1, Numero num2)
        {
            return num1._numero + num2._numero;
        }

        public static double operator -(Numero num1, Numero num2)
        {
            return num1._numero - num2._numero;
        }

        public static double operator /(Numero num1, Numero num2)
        {
            if (num2._numero != 0) return num1._numero / num2._numero;

            else return 0;
        }


        public static double operator *(Numero num1, Numero num2)
        {
            return num1._numero * num2._numero;
 
        }


 
      














//        * protected _numero:double
//* -->prop. solo Lectura
//* const. 1 parametro
//* sobrecarga + (Numero, Numero) : double
//* sobrecarga - (Numero, Numero) : double
//* sobrecarga / (Numero, Numero) : double
//* sobrecarga * (Numero, Numero) : double



    }
}
