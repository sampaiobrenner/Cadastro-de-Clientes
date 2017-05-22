using Cadastro.Classes.DTO;
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
                txtBoxCPF_CNPJ.Text = "";
                txtBoxRG_IE.Text = "";
                lblPessoa.Text = "CNPJ";
                lblRG_IE.Text = "IE";
                lblNomeCompleto.Text = "Razão Social";
            }
            else
            {
                txtBoxCPF_CNPJ.Mask = "000.000.000-00";
                txtBoxCPF_CNPJ.Text = "";
                txtBoxRG_IE.Text = "";
                lblPessoa.Text = "CPF";
                lblRG_IE.Text = "RG";
                lblNomeCompleto.Text = "Nome Completo";
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
                        TipoPessoa = comboBoxPessoa.Text,
                        Nome = txtBoxNome.Text,
                        DataNascimento = Convert.ToDateTime(Regex.Replace(txtBoxDataNascimento.Text, "  /  /", "")),
                        RgIe = txtBoxRG_IE.Text,
                        CpfCnpj = txtBoxCPF_CNPJ.Text,
                        Email = txtBoxEmail.Text,
                        CidadeId = Convert.ToInt32((comboBoxCidades.SelectedItem as ItemDaComboBoxDeCidade).Id),
                        TelefonePrincipal = txtBoxTelefonePrincipal.Text,
                        TelefoneSecundario = txtBoxTelefoneSecundario.Text,
                        Cep = txtBoxCEP.Text,
                        Logradouro = txtBoxLogradouro.Text,
                        Numero = txtBoxNumero.Text,
                        Complemento = txtBoxComplemento.Text,
                        Bairro = txtBoxBairro.Text
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
             if (comboBoxCidades.Text.Trim().Equals(""))
            {
                MessageBox.Show("Campo 'Cidade' de preenchimento obrigatório!");
                comboBoxCidades.Focus();
                return false;
            }
            else
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
            if (txtBoxCPF_CNPJ.Text.Trim().Equals("___,___,___-__") || txtBoxCPF_CNPJ.Text.Trim().Equals("__,___,___/____-__"))
            {
                MessageBox.Show("Campo 'CPF/CNPJ' de preenchimento obrigatório!");
                txtBoxCPF_CNPJ.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void carregarCidades()
        {
            CidadeDAO cidades = new CidadeDAO();
            try
            {
                IList<ItemDaComboBoxDeCidade> resultado = cidades.obterCidades();
                foreach (var c in resultado)
                {
                    comboBoxCidades.Items.Add(c);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }
          
            
        }

        private void comboBoxCidades_SelectedValueChanged(object sender, EventArgs e)
        {

            int indice = Convert.ToInt32((comboBoxCidades.SelectedItem as ItemDaComboBoxDeCidade).Id);
            EstadoDAO dao = new EstadoDAO();
            txtBoxUf.Text = dao.obterEstado(indice);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormListagemClientes listagem = new FormListagemClientes();
                listagem.ShowDialog();
            }
            finally
            {
                this.Show();
            }
            
        }

        private void FormCadastroClientes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    btnCadastrarCliente_Click(sender, e);
                    break;
              
            }
        }
    }
}
