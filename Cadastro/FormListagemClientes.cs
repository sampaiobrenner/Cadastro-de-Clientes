using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class FormListagemClientes : Form
    {

        private ClienteDAO dao;

        public FormListagemClientes()
        {
            InitializeComponent();
            dao = new ClienteDAO();
            criarLista();
        }

        public void criarLista()
        {

            listagem.Columns.Add("Id", 30, HorizontalAlignment.Left);
            listagem.Columns.Add("Tipo de Pessoa", 90, HorizontalAlignment.Left);
            listagem.Columns.Add("Nome Completo", 180, HorizontalAlignment.Left);
            listagem.Columns.Add("Data de Nascimento", 130, HorizontalAlignment.Left);
            listagem.Columns.Add("RG/IE", 100, HorizontalAlignment.Left);
            listagem.Columns.Add("CPF/CNPJ", 100, HorizontalAlignment.Left);
            listagem.Columns.Add("E-mail", 240, HorizontalAlignment.Left);
            listagem.Columns.Add("Telefone Principal", 120, HorizontalAlignment.Left);
            listagem.Columns.Add("Telefone Secundário", 120, HorizontalAlignment.Left);
            listagem.Columns.Add("Cidade", 100, HorizontalAlignment.Left);
            listagem.Columns.Add("CEP", 100, HorizontalAlignment.Left);
            listagem.Columns.Add("Logradouro", 200, HorizontalAlignment.Left);
            listagem.Columns.Add("Número", 100, HorizontalAlignment.Left);
            listagem.Columns.Add("Complemento", 150, HorizontalAlignment.Left);
            listagem.Columns.Add("Bairro", 150, HorizontalAlignment.Left);

            this.Controls.Add(listagem);
        }

        public void carregaClientes()
        {
            try
            {
                String busca = txtBoxBuscaCliente.Text;

                IList<Cliente> resultado;

                if (busca == "")
                {
                   resultado = dao.obterClientes();
                }
                else
                {
                    resultado = dao.obterClientes(busca);
                }

                listagem.Items.Clear();

                foreach (var c in resultado)
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(c.Id));

                    item.SubItems.Add(c.TipoPessoa);
                    item.SubItems.Add(c.Nome);
                    item.SubItems.Add(c.DataNascimento.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(c.RgIe);
                    item.SubItems.Add(c.CpfCnpj);
                    item.SubItems.Add(c.Email);
                    item.SubItems.Add(c.TelefonePrincipal);
                    item.SubItems.Add(c.TelefoneSecundario);
                    item.SubItems.Add(c.Cidade.Nome);
                    item.SubItems.Add(c.Cep);
                    item.SubItems.Add(c.Logradouro);
                    item.SubItems.Add(c.Numero);
                    item.SubItems.Add(c.Complemento);
                    item.SubItems.Add(c.Bairro);

                    listagem.Items.AddRange(new ListViewItem[] { item });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }

        }

        

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExluirCliente_Click(object sender, EventArgs e)
        {
            if (listagem.Items.Count == 0)
            {
                MessageBox.Show("Você não possui clientes cadastrados!");
            } else if (listagem.SelectedItems.Count == 0)
            {
                MessageBox.Show("Você deve selecionar um registro para excluir!");
            } else {

                DialogResult dr = MessageBox.Show("Você tem certeza que deseja excluir o registro selecionado?", "Confirmação: Excluir cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(listagem.SelectedItems[0].SubItems[0].Text);
                        dao.excluirCliente(id);
                        listagem.Items.RemoveAt(listagem.SelectedIndices[0]);

                        MessageBox.Show("Registro excluido com sucesso!");
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

        private void FormListagemClientes_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    buttonExluirCliente_Click(sender, e);
                    break;
                case Keys.Escape:
                    buttonFechar_Click(sender, e);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                carregaClientes();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                FormCadastroClientes formCadastroClientes = new FormCadastroClientes();
                formCadastroClientes.ShowDialog();
            }
            finally
            {
                this.Show();
            }
        }
    }
}
