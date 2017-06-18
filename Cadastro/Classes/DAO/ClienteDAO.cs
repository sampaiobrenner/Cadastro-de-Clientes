
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class ClienteDAO
    {
        private EntidadeContext contexto;

        public ClienteDAO ()
        {
            contexto = new EntidadeContext();
        }

        public void salvarCliente (Cliente cliente)
        {
            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();
        }

        public void excluirCliente (int idCliente)
        {
            IList<Cliente> cliente = buscarClientePorId(idCliente);
            Cliente obj = cliente.First();
            contexto.Clientes.Remove(obj);
            contexto.SaveChanges();
        }

        public void alterarCliente (Cliente cliente)
        {
            Cliente alteracao = contexto.Clientes.First(c => c.Id == cliente.Id);
            alteracao.Nome = cliente.Nome;
            alteracao.Numero = cliente.Numero;
            alteracao.Logradouro = cliente.Logradouro;
            alteracao.RgIe = cliente.RgIe;
            alteracao.TelefonePrincipal = cliente.TelefonePrincipal;
            alteracao.TipoPessoa = cliente.TipoPessoa;
            alteracao.TelefoneSecundario = cliente.TelefoneSecundario;
            alteracao.CidadeId = cliente.CidadeId;
            alteracao.Email = cliente.Email;
   
            contexto.SaveChanges();
        }

        public IList<Cliente> buscarClientePorId (int id)
        {
            var busca = from c in contexto.Clientes.Include(c => c.Cidade).Include(e => e.Cidade.Estado)
                        where c.Id == id
                        select c;

            IList<Cliente> resultado = busca.ToList();
            return resultado;
        }

        public IList<Cliente> obterClientes()
        {
            var busca = (from c in contexto.Clientes.Include(c => c.Cidade)
                        orderby c.Id descending
                        select c).Take(50);
            IList<Cliente> resultado = busca.ToList();
            return resultado;
        }

        public IList<Cliente> obterClientes(String cliente)
        {
            var busca = from c in contexto.Clientes.Include(c => c.Cidade)
                        orderby c.Id descending
                        where c.Nome.Contains(cliente)
                        select c;
            IList<Cliente> resultado = busca.ToList();
            return resultado;
        }

        public IList<Cliente> obterUltimoCliente()
        {
            var busca = (from c in contexto.Clientes.Include(c => c.Cidade).Include(e => e.Cidade.Estado)
                         orderby c.Id descending
                        select c).Take(1);
            IList<Cliente> resultado = busca.ToList();
            return resultado;
        }

    }
}
