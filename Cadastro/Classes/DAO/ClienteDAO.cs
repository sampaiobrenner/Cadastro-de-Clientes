
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
            contexto.Clientes.Update(cliente);
            contexto.SaveChanges();
        }

        public IList<Cliente> buscarClientePorId (int id)
        {
            var busca = from c in contexto.Clientes
                        where c.Id == id
                        select c;
            IList<Cliente> resultado = busca.ToList();
            return resultado;
        }

        public IList<Cliente> obterClientes()
        {
            var busca = from c in contexto.Clientes.Include(c => c.Cidade)
                        select c;
            IList<Cliente> resultado = busca.ToList();
            return resultado;
        }

        public IList<Cliente> obterClientes(String cliente)
        {
            var busca = from c in contexto.Clientes.Include(c => c.Cidade)
                        where c.Nome.Contains(cliente)
                        select c;
            IList<Cliente> resultado = busca.ToList();
            return resultado;
        }

    }
}
