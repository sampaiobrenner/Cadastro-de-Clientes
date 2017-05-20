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
            var busca = from c in contexto.Cidades
                        select c;
            IList<Cidade> resultado = busca.ToList();
            return resultado;
        }

        public String obterUf(int id)
        {
            var busca = from e in contexto.Estados
                        join c in contexto.Cidades on e.id equals c.id
                        where c.id == id
                        select e.nome;
            return busca.ToString();            
        }

    }
}
