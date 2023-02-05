using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_guia6_poo_ejercicio5.Entity
{
    internal class Cuenta
    {
        private int numeroCuenta;
        private long dni;
        private double saldoActual;

        public Cuenta()
        {
        }
        public Cuenta(int numeroCuenta, long dni, double saldoActual)
        {
            this.numeroCuenta = numeroCuenta;
            this.dni = dni;
            this.saldoActual = saldoActual;
        }

        public int getNumeroCuenta()
        {
            return this.numeroCuenta;
        }

        public void setNumeroCuenta(int numeroCuenta)
        {
            this.numeroCuenta = numeroCuenta;
        }

        public long getDNI()
        {
            return this.dni;
        }

        public void setDni(long dni)
        {
            this.dni = dni;
        }



        public double getSaldoActual()
        {
            return this.saldoActual;
        }

        public void setSaldoActual(double saldoActual)
        {
            this.saldoActual = saldoActual;
        }


        public override string ToString()
        {
            return "Numero de cuenta: " + this.numeroCuenta +
                ". Dni: " + this.dni +
                ". Saldo actual: " + this.saldoActual;
        }





    }
}
