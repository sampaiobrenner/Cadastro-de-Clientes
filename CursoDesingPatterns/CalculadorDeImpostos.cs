using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo (Orcamento orcamento, Imposto imposto)
        {
            /*
            if ("IMCS".Equals(imposto))
            {
                double icms = orcamento.Valor * 0.01;
                Console.WriteLine(icms);
            }

            if("ISS".Equals(imposto))
            {
                double iss = orcamento.Valor * 0.06;
                Console.WriteLine(iss);
            }
            */

            /*
            if ("IMCS".Equals(imposto))
            {
                double icms = new ICMS().CalculaICMS(orcamento);
                Console.WriteLine(icms);
            }

            if ("ISS".Equals(imposto))
            {
                double iss = new ISS().CalculaISS(orcamento);
                Console.WriteLine(iss);
            }
            */

            // o tipo de imposto pode variar passando pelo parametro
            double tributo = imposto.Calcula(orcamento);
            Console.WriteLine(tributo);

        }
    }
}
