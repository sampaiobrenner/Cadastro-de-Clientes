﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesingPatterns
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public List<Item> Itens { get; private set; }

        public Orcamento(Double valor)
        {
            this.Itens = new List<Item>();
            this.Valor = valor;
        }

        public void AdicionarItem (Item item)
        {
            Itens.Add(item);
        }
    }
}
