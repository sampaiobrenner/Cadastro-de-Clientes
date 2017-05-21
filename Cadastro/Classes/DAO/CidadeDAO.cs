using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class CidadeDAO
    {
        private EntidadeContext contexto;

        public CidadeDAO()
        {
            contexto = new EntidadeContext();
        }


        public IList<Cidade> obterCidades()
        {
            var busca = (from c in contexto.Cidades.Include(e => e.estado)
                        //join e in contexto.Estados on c.estadoid equals e.id
                        orderby c.nome
                        select c);
            IList<Cidade> resultado = busca.ToList();
            return resultado;
        }

    }
}
