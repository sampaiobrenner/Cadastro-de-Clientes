using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class Estado
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Sigla { get; set; }
        public virtual IList<Cidade> Cidades { get; set; }
    }
}
