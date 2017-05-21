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
            carregaClientes();
        }
      
        public void carregaClientes()
        {
            try
            {
                IList<Cliente> resultado = dao.obterClientes();
                foreach (var c in resultado)
                {
                    ListViewItem item = new ListViewItem("", 0);
                    item.Checked = false;
                    item.SubItems.Add(Convert.ToString(c.Id));
                    item.SubItems.Add(c.Nome);
                    item.SubItems.Add(c.TipoPessoa);
                    item.SubItems.Add(c.Email);
                    item.SubItems.Add(c.DataNascimento.ToString("dd/MM/yyyy"));

                    listagem.Items.AddRange(new ListViewItem[] { item });
                }

                listagem.Columns.Add("", -2, HorizontalAlignment.Center);
                listagem.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listagem.Columns.Add("Nome", 250, HorizontalAlignment.Left);
                listagem.Columns.Add("Tipo Pessoa", -2, HorizontalAlignment.Left);
                listagem.Columns.Add("E-mail", -2, HorizontalAlignment.Left);
                listagem.Columns.Add("Data de Nascimento", -2, HorizontalAlignment.Left);

                this.Controls.Add(listagem);

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
            int contador = listagem.Items.Count;
            if (contador > 0) {
                DialogResult dr = MessageBox.Show("Você tem certeza que deseja excluir o registro selecionado?", "Confirmação: Excluir cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        int id = Convert.ToInt32(listagem.SelectedItems[0].SubItems[1].Text);
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
            } else
            {
                MessageBox.Show("Você não possui clientes cadastrados!");
            }
           
           
            
        }
    }
}
