using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class texto
    {
        genero g = new genero();
        calcula c = new calcula();

        public string caso1 = "Sendo que o seu género é " + g.gen + " o seu Índice \n" +
                    "de Massa Corporal é " + c.resultado.ToString() + " com isto você está\n" +
                    "abaixo da média (Magro, Menos que 27.5Kg) \n";
    }
}
