using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class CalculadorDeDescontos
    {
        public double Calcula (Orcamento orcamento)
        {

            // mais de 5 itens

            /*
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }
            else if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }
            return 0;

            */

            //double desconto = new DescontoPorCincoItems().Desconta(orcamento);

            Desconto d1 = new DescontoPorCincoItems();
            Desconto d2 = new DescontoPorMaisDeQuinhentosReais();
            Desconto d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;

            return d1.Desconta(orcamento);

        }

    }
}
