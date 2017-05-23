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

        public static string NomeCompletoDaCidade(string nome, string uf)
        {
            return nome + " - " + uf;
        }

        public static void ClearForm(System.Windows.Forms.Control parent)
        {
            foreach (System.Windows.Forms.Control ctrControl in parent.Controls)
            {
                //Loop through all controls 
                if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
                {
                    //Check to see if it's a textbox 
                    ((System.Windows.Forms.TextBox)ctrControl).Text = string.Empty;
                    //If it is then set the text to String.Empty (empty textbox) 
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.MaskedTextBox)))
                {
                    //If its a RichTextBox clear the text
                    ((System.Windows.Forms.MaskedTextBox)ctrControl).Text = string.Empty;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.ComboBox)))
                {
                    //If its a RichTextBox clear the text
                    ((System.Windows.Forms.ComboBox)ctrControl).Text = string.Empty;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                {
                    //Next uncheck all checkboxes
                    ((System.Windows.Forms.CheckBox)ctrControl).Checked = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.RadioButton)))
                {
                    //Unselect all RadioButtons
                    ((System.Windows.Forms.RadioButton)ctrControl).Checked = false;
                }
                if (ctrControl.Controls.Count > 0)
                {
                    //Call itself to get all other controls in other containers 
                    ClearForm(ctrControl);
                }
            }
        }

    }
}
