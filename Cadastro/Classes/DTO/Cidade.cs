using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class Cidade
    {
        public int id { get; set; }
        public String nome { get; set; }
        public virtual Estado estado { get; set; }
        public int estadoid { get; set; }
        public virtual IList<Cliente> clientes { get; set; }

    }
}
