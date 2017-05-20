using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class FormCadastroClientes : Form
    {

        public FormCadastroClientes()
        {
            InitializeComponent();
            carregarCidades();
        }

        private void comboBoxPessoa_SelectedValueChanged(object sender, EventArgs e)
        {
            string itemPessoa = comboBoxPessoa.Text;
            if (itemPessoa == "Juridica")
            {
                txtBoxCPF_CNPJ.Mask = "00.000.000/0000-00";
                lblPessoa.Text = "CNPJ";
                lblRG_IE.Text = "IE";
            }
            else
            {
                txtBoxCPF_CNPJ.Mask = "000.000.000-00";
                lblPessoa.Text = "CPF";
                lblRG_IE.Text = "RG";
            }

        }    

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            if (validarCadastro())
            {
                try
                {
                    ClienteDAO dao = new ClienteDAO();
                    Cliente cliente = new Cliente()
                    {
                        tipoPessoa = comboBoxPessoa.Text,
                        nome = txtBoxNome.Text,
                        dataNascimento = Convert.ToDateTime(Regex.Replace(txtBoxDataNascimento.Text, "  /  /", "")),
                        rgIe = txtBoxRG_IE.Text,
                        cpfCnpj = txtBoxCPF_CNPJ.Text,
                        email = txtBoxEmail.Text,
                        cidadeid = 3,
                        telefonePrincipal = txtBoxTelefonePrincipal.Text,
                        telefoneSecundario = txtBoxTelefoneSecundario.Text,
                        cep = txtBoxCEP.Text,
                        logradouro = txtBoxLogradouro.Text,
                        numero = txtBoxNumero.Text,
                        complemento = txtBoxComplemento.Text
                    };
                    dao.salvarCliente(cliente);

                    MessageBox.Show("Cadastro efetuado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex);
                }
            }
            
        }

        public bool validarCadastro ()
        {
            if (txtBoxNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Campo 'Nome' de preenchimento obrigatório!");
                txtBoxNome.Focus();
                return false;
            } else
            if (Regex.Replace(txtBoxDataNascimento.Text, "  /  /", "").Equals("") )
            {
                MessageBox.Show("Campo 'Data de Nascimento' de preenchimento obrigatório!");
                txtBoxDataNascimento.Focus();
                return false;
            }
            else if (txtBoxDataNascimento.Text.Length < 10)
            {
                MessageBox.Show("Insira uma data de nascimento válida!");
                txtBoxDataNascimento.Focus();
                return false;
            } else
            /*if (txtBoxCPF_CNPJ.Text.Trim().Equals("___,___,___-__") || txtBoxCPF_CNPJ.Text.Trim().Equals("__,___,___/____-__"))
            {
                MessageBox.Show("Campo 'CPF/CNPJ' de preenchimento obrigatório!");
                txtBoxCPF_CNPJ.Focus();
                return false;
            }
            else*/
            {
                return true;
            }
        }

        private void carregarCidades()
        {
            CidadeDAO cidades = new CidadeDAO();
            try
            {
                IList<Cidade> resultado = cidades.obterCidades();
                foreach (var c in resultado)
                {
                    comboBoxCidades.Items.Add(c.nome);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
          
            
        }

        private void comboBoxCidades_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Esconda o formulario atual
                this.Hide();
                // Crie apenas o segundo form
                FormListagemClientes listagem = new FormListagemClientes();
                //Mostre o segundo form
                listagem.ShowDialog();
            }
            finally
            {
                // ao fechar, mostre novamente o inicial, ou feche this.Close();
                this.Show();
            }
            
        }
    }
}
