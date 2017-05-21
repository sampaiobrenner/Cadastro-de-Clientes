using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class EstadoDAO
    {
        private EntidadeContext contexto;

        public EstadoDAO ()
        {
            contexto = new EntidadeContext();
        }

        public String obterEstado (int id)
        {
            
            var busca = from c in contexto.Cidades.Include(e => e.Estado)
                        where c.Id == id
                        select c.Estado.Sigla;

            String sigla = busca.FirstOrDefault();
            return sigla;
        }
    }
}
