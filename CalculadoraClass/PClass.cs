using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraClass
{
    class PClass
    {
        protected int Valor1 { get; set; }
        protected int Valor2 { get; set; }

        protected decimal Resultado { get; set; }


        public void obtener(int Aux1,int Aux2) {
            Valor1 =Aux1;
            Valor2 =Aux2;
        }


        public decimal Datos() {
            return Resultado;
        }
    }
}
