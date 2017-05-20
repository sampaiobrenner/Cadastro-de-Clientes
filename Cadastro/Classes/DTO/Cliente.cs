using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class Cliente
    {
        public int id { get; set; }
        public String tipoPessoa { get; set; }
        public String nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public String rgIe { get; set; }
        public String cpfCnpj { get; set; }
        public String email { get; set; }
        public String telefonePrincipal { get; set; }
        public String telefoneSecundario { get; set; }
        public virtual Cidade cidade { get; set; }
        public int cidadeid { get; set; }
        public String cep { get; set; }
        public String logradouro { get; set; }
        public String numero { get; set; }
        public String complemento { get; set; }


    }
}
