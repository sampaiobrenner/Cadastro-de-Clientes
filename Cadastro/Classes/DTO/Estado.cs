using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class Estado
    {
        public int id { get; set; }
        public String nome { get; set; }
        public String sigla { get; set; }
        public virtual IList<Cidade> cidades { get; set; }
    }
}
