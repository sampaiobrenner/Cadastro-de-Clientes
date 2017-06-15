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
        private bool alteracao;
        int idCliente;

        public FormCadastroClientes()
        {
            InitializeComponent();
            carregarCidades();
        }

        public FormCadastroClientes(Cliente cliente)
        {
            InitializeComponent();
            alteracao = true;
            carregarCidades();

            idCliente = cliente.Id;

            comboBoxPessoa.Text = cliente.TipoPessoa;
            txtBoxNome.Text = cliente.Nome;
            txtBoxDataNascimento.Text = Convert.ToString(cliente.DataNascimento);
            txtBoxRG_IE.Text = cliente.RgIe;
            txtBoxCPF_CNPJ.Text = cliente.CpfCnpj;
            txtBoxEmail.Text = cliente.Email;
            comboBoxCidades.Text = cliente.Cidade.Nome;
            txtBoxUf.Text = cliente.Cidade.Estado.Sigla;
            txtBoxTelefonePrincipal.Text = cliente.TelefonePrincipal;
            txtBoxTelefoneSecundario.Text = cliente.TelefoneSecundario;
            txtBoxCEP.Text = cliente.Cep;
            txtBoxLogradouro.Text = cliente.Logradouro;
            txtBoxNumero.Text = cliente.Numero;
            txtBoxComplemento.Text = cliente.Complemento;
            txtBoxBairro.Text = cliente.Bairro;
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
                        Id = idCliente,
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

                    if(alteracao)
                    {
                        dao.alterarCliente(cliente);
                        MessageBox.Show("Cadastro alterado com sucesso!");
                    } else
                    {
                        dao.salvarCliente(cliente);
                        MessageBox.Show("Cadastro efetuado com sucesso!");
                    }
                    
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex);
                }
            }
            
        }

        public bool validarCadastro ()
        {
            if(comboBoxPessoa.Text.Trim().Equals(""))
            {
                MessageBox.Show("Campo 'Tipo de Pessoa' de preenchimento obrigatório!");
                comboBoxPessoa.Focus();
                return false;
            }
            else if (txtBoxNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Campo 'Nome' de preenchimento obrigatório!");
                txtBoxNome.Focus();
                return false;
            }
            else if (Regex.Replace(txtBoxDataNascimento.Text, "  /  /", "").Equals(""))
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
            }
            else if (txtBoxCPF_CNPJ.Text.Trim().Equals("___,___,___-__") || txtBoxCPF_CNPJ.Text.Trim().Equals("__,___,___/____-__"))
            {
                MessageBox.Show("Campo 'CPF/CNPJ' de preenchimento obrigatório!");
                txtBoxCPF_CNPJ.Focus();
                return false;
            }
            else if (comboBoxCidades.Text.Trim().Equals(""))
            {
                MessageBox.Show("Campo 'Cidade' de preenchimento obrigatório!");
                comboBoxCidades.Focus();
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

        private void carregarCidades(String nome)
        {
            CidadeDAO cidades = new CidadeDAO();
            try
            {
                IList<ItemDaComboBoxDeCidade> resultado = cidades.obterCidades(nome);
                
                foreach (var c in resultado)
                {
                    comboBoxCidades.Items.Add(c);
                }
            }
            catch (Exception ex)
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
                case Keys.Escape:
                    btnFechar_Click(sender, e);
                    break;
            }

            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.Delete:
                        btnLimparCampos(sender, e);
                        break;
                }
            }
        }

        private void btnLimparCampos(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Você tem certeza que limpar os campos?", "Confirmação: Limpar campos?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    Utils.ClearForm(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex);
                }
            }
            else if (dr == DialogResult.Cancel)
            {

            }
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Você tem certeza que deseja sair sem gravar as alterações?", "Confirmação: Fechar cadastro de cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex);
                }
            }
            else if (dr == DialogResult.Cancel)
            {

            }
        }
    }
}
