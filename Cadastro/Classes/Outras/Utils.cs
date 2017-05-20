using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class Utils
    {
      
        /// <summary>
        /// Remove os principais caracteres especiais que uma string pode conter: |'&\'
        /// </summary>
        /// <param name="p_strPalavra">String X na qual se deseja remover os caracteres especiais</param>
        /// <returns>Retorna uma string X sem os caracteres epseciais</returns>
        public static string RemoveCaracteresEspeciais(string p_strPalavra)
        {
            string p_strRemover = "|'&\'";
            string strCaracterParaRemover;
            int intTamanho = p_strRemover.Length;

            for (int i = 0; i < intTamanho; i++)
            {
                strCaracterParaRemover = p_strRemover.Substring(i, 1);

                p_strPalavra = p_strPalavra.Replace(Convert.ToChar(strCaracterParaRemover), ' ');
            }

            return p_strPalavra;
        }

        /// <summary>
        /// Remove de uma string, caracteres especiais definidos pelo programados
        /// </summary>
        /// <param name="p_strPalavra">String na qual se deseja remover os caracteres especiais</param>
        /// <param name="p_strRemover">Caracteres a remover</param>
        /// <returns>Retorna a string sem os caracteres epseciais</returns>
        public static string RemoveCaracteresEspeciais(string p_strPalavra, string p_strRemover)
        {
            int intTamanho = p_strRemover.Length;
            string strCaracterParaRemover;

            for (int i = 0; i < intTamanho; i++)
            {
                strCaracterParaRemover = p_strRemover.Substring(i, 1);
                p_strPalavra = p_strPalavra.Replace(strCaracterParaRemover, string.Empty);
            }

            return p_strPalavra.Trim();
        }

    }
}
