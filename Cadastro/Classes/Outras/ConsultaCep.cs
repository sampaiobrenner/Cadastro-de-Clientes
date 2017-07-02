using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Correios.Net;

namespace Cadastro.Classes
{
    public class ConsultaCep
    {
        public bool consultarCep(string cep)
        {
            if (!string.IsNullOrWhiteSpace(cep))
            {
                Address endereco = SearchZip.GetAddress(cep);
                if (endereco.Zip != null)
                {
                    // Conseguiu buscar
                    return true;
                   
                }
                else
                {
                    // Ocorreu um erro na busca
                    return false;
                }
            }
            else
            {
                // Ocorreu um erro na busca - Cep Inválido
                return false;
            }
        }

        /*
         * Como usar?
         * 
            txtEstado.Text = endereco.State;
            txtCidade.Text = endereco.City;
            txtBairro.Text = endereco.District;
            txtRua.Text = endereco.Street;
        *
        */

    }
}
