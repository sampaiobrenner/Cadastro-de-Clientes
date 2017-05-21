using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Classes.DTO
{
    public class ItemDaComboBoxDeCidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string SiglaDaUf { get; set; }

        public string NomeCompleto
        {
            get
            {
                //return Nome + " - " + SiglaDaUf; ou
                return $"{Nome} - {SiglaDaUf}";

            }
        }
    }
}
