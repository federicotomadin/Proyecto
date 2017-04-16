using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Banco
    {
        private DateTime _fechaInicio;
        private List<CuentaCorriente> _listaCuentasCorrientes=new List<CuentaCorriente>();
        private string _razonSocial;

        public Banco(string razon, DateTime fechaInicio)
        {
            
            this._razonSocial = razon;
            this._fechaInicio = fechaInicio;
        }

        public void MostrarBanco()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Fecha:" + this._fechaInicio + "\n");
            sb.Append("Razon Social:" + this._razonSocial + "\n");

            

            foreach (CuentaCorriente item in this._listaCuentasCorrientes)
            {
               sb.Append("Saldo:" + item.Saldo + "\n");
                sb.Append(Usuario.Mostrar(item.Duenio) + "\n");
                
            }

            Console.WriteLine(sb.ToString());



         }

        public static Banco operator +(Banco unBanco, CuentaCorriente unaCuenta)
        {
            bool flag = false;

            foreach (CuentaCorriente item in unBanco._listaCuentasCorrientes)
            {
                if (item == unaCuenta)
                {
                    flag = true;
                    break;
                }
            }

            if (flag == false)
            {
                unBanco._listaCuentasCorrientes.Add(unaCuenta);
                Console.WriteLine("Se ha agregado una cuenta Corriente!!!");
            }
            else
            {
                 Console.WriteLine("LA Cuenta corriente ya existe!!!");
            }

            return unBanco;
        }

        public static Banco operator -(Banco unBanco, CuentaCorriente unaCuenta)
        {
            bool flag = false;

            foreach (CuentaCorriente item in unBanco._listaCuentasCorrientes)
            {
                if (item == unaCuenta)
                {
                    flag = true;
                    break;
                }
            }

            if (flag == true)
            {
                unBanco._listaCuentasCorrientes.Remove(unaCuenta);
                Console.WriteLine("Se ha eliminado laCuenta corriente!!!");
            }
            else
            {
                Console.WriteLine("La Cuenta corriente no existe!!!");
            }

            return unBanco;
        }


    }
}
