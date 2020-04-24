using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraClass;

namespace CalculadoraClass
{
    class SClass : PClass
    {
        public void suma()  {
            Resultado = Valor1 + Valor2;

        }

        public void Resta()
        {
            Resultado = Valor1 - Valor2;

        }

        public void Multi()
        {
            Resultado = Valor1 * Valor2;

        }
        public void Division()
        {
            Resultado = Valor1 / Valor2;

        }

    }
}
