using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3.Racionales.Racionales.Model
{
    class Racionales
    {
        private int numerador;
        private int denominador;

        public Racionales(int numerador, int denominador)
        {
            this.numerador = numerador;
            this.denominador = denominador;
        }

        public int getNumerador()
        {
            return numerador;
        }

        public int getDenominador()
        {
            return denominador;
        }

        public void setNumerador()
        {
            this.numerador = numerador;
        }

        public void setDenominador()
        {
            if (denominador == 0)
            {
                throw new Exception("Forbbiden value");
            }
            
            this.denominador = denominador;
        }

        public Racionales multiplicar(Racionales r)
        {
            int numerador = this.numerador * r.getNumerador();
            int denominador = this.denominador * r.getDenominador();

            return new Racionales(numerador, denominador);
        }

        public Racionales dividir(Racionales r)
        {
            int numerador = this.numerador * r.getDenominador();
            int denominador = this.denominador * r.getNumerador();

            return new Racionales(numerador, denominador);
        }
    }
}
