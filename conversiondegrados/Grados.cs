using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversiondegrados
{
    public class Grados
    {

        private double numero1;


        public void setNumero1(double valor)
        {
            this.numero1 = valor;
        }

        public double getNumero1()
        {
            return this.numero1;
        }

        public double convertir()
        {
            return ((this.getNumero1() *  9/5) + 32);
        }
    }
}
