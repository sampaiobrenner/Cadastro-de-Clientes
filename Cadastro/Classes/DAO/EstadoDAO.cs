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
            
            var busca = from e in contexto.Estados.Include(c => c.cidades)
                        where e.id == id
                        select e.sigla;

            String sigla = busca.FirstOrDefault();
            return sigla;
        }
    }
}
