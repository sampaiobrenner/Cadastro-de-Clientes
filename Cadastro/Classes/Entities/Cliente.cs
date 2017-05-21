using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class Cliente
    {
        public int Id { get; set; }
        public String TipoPessoa { get; set; }
        public String Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public String RgIe { get; set; }
        public String CpfCnpj { get; set; }
        public String Email { get; set; }
        public String TelefonePrincipal { get; set; }
        public String TelefoneSecundario { get; set; }
        public virtual Cidade Cidade { get; set; }
        public int CidadeId { get; set; }
        public String Cep { get; set; }
        public String Logradouro { get; set; }
        public String Numero { get; set; }
        public String Complemento { get; set; }
        public String Bairro { get; set; }


    }
}
