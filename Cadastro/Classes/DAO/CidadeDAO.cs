using Cadastro.Classes.DTO;
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


        public IList<ItemDaComboBoxDeCidade> obterCidades()
        {
            
            var busca = (from c in contexto.Cidades.Include(e => e.Estado)
                        orderby c.Nome
                        select c).ToList();
                        
            IList<ItemDaComboBoxDeCidade> resultado = new List<ItemDaComboBoxDeCidade>();

            busca.ForEach(c =>
            {
                resultado.Add(new ItemDaComboBoxDeCidade()
                {
                    Id = c.Id,
                    Nome = c.Nome,
                    SiglaDaUf = c.Estado.Sigla
                });
            });

            return resultado;
        }

        public IList<ItemDaComboBoxDeCidade> obterCidades(String nome)
        {

            var busca = (from c in contexto.Cidades.Include(e => e.Estado)
                         where c.Nome.Contains(nome)
                         orderby c.Nome
                         select c).Take(10).ToList();

            IList<ItemDaComboBoxDeCidade> resultado = new List<ItemDaComboBoxDeCidade>();

            busca.ForEach(c =>
            {
                resultado.Add(new ItemDaComboBoxDeCidade()
                {
                    Id = c.Id,
                    Nome = c.Nome,
                    SiglaDaUf = c.Estado.Sigla
                });
            });

            return resultado;
        }
    }
}
