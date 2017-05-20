
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

        public void excluirCliente (Cliente cliente)
        {
            contexto.Clientes.Remove(cliente);
            contexto.SaveChanges();
        }

        public void alterarCliente (Cliente cliente)
        {
            contexto.Clientes.Update(cliente);
            contexto.SaveChanges();
        }

        public Cliente buscarClientePorId (int id)
        {
            // retorna o primeiro id encontrado
            return contexto.Clientes.FirstOrDefault(c => c.id == id);
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
