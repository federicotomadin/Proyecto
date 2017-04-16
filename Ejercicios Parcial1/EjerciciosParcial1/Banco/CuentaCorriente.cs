using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class CuentaCorriente
    {
        private Usuario _duenio;
        private int _numeroCuenta;
        private double _saldo;

        public Usuario Duenio
        {
            get
            {
                return this._duenio;
            }
        }

        public double Saldo
        {
            get
            {
                return this._saldo;
            }

            set
            {
                this._saldo = this._saldo + value;
            }
        }

        public CuentaCorriente(string apellido, string nombre, double dni, int numero, double saldo)
        {
            this._duenio = new Usuario(apellido, nombre, dni);
            this._numeroCuenta = numero;
            this._saldo = saldo;
        }

       

        public CuentaCorriente(Usuario duenio, int numero, double saldo)
        {
            this._duenio = duenio;
            this._numeroCuenta = numero;
            this._saldo = saldo;
        }

        public static explicit operator double(CuentaCorriente CC)
        {
            return CC._saldo;
        }

        public static implicit operator CuentaCorriente(Usuario unUsuario)
        {
            return new CuentaCorriente(unUsuario, 0, 0);
        }

        public static bool operator ==(CuentaCorriente cc1, CuentaCorriente cc2)
        {
            if (cc1._duenio.Dni == cc2._duenio.Dni)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(CuentaCorriente cc1, CuentaCorriente cc2)
        {
            return !(cc1 == cc2);
        }



    }
}
