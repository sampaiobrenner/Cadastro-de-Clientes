using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500);

            CalculadorDeImpostos calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, icms);
            */

            CalculadorDeDescontos calculador = new CalculadorDeDescontos();
            Orcamento orcamento = new Orcamento(600);

            orcamento.AdicionarItem(new Item("Caneta", 250));
            orcamento.AdicionarItem(new Item("Lapis", 250));

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);
            Console.ReadKey();

        }
    }
}
