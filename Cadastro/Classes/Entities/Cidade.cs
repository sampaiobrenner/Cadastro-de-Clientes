using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class Cidade
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public virtual Estado Estado { get; set; }
        public int EstadoId { get; set; }
        public virtual IList<Cliente> Clientes { get; set; }
    }
}
