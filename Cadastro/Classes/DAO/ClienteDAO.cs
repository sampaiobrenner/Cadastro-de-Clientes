
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
                        where c.id == id
                        select c;
            IList<Cliente> resultado = busca.ToList();
            return resultado;
        }

        public IList<Cliente> obterClientes()
        {
            var busca = from c in contexto.Clientes
                        select c;
            IList<Cliente> resultado = busca.ToList();
            return resultado;
        }

    }
}
