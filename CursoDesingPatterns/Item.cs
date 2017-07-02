using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class Item
    {
        public String Nome { get; set; }
        public double Valor { get; set; }

        public Item(string nome, double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}
