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
        private ListView listagem;
        public FormListagemClientes()
        {
            InitializeComponent();
            dao = new ClienteDAO();
            listagem = new ListView();
            definirLista();
            carregaClientes();
        }

        public void definirLista()
        {
            listagem.Bounds = new Rectangle(new Point(10, 10), new Size(580, 350));

            // Set the view to show details.
            listagem.View = View.Details;
            // Allow the user to edit item text.
            listagem.LabelEdit = false;
            // Allow the user to rearrange columns.
            listagem.AllowColumnReorder = true;
            // Display check boxes.
            listagem.CheckBoxes = false;
            // Select the item and subitems when selection is made.
            listagem.FullRowSelect = true;
            // Display grid lines.
            listagem.GridLines = true;
            // Sort the items in the list in ascending order.
            listagem.Sorting = SortOrder.Ascending;
        }
        
        public void carregaClientes()
        {
            try
            {
                IList<Cliente> resultado = dao.obterClientes();
                foreach (var c in resultado)
                {
                    // Create three items and three sets of subitems for each item.
                    ListViewItem item = new ListViewItem("", 0);
                    item.Checked = false;
                    item.SubItems.Add(Convert.ToString(c.id));
                    item.SubItems.Add(c.nome);
                    item.SubItems.Add(c.tipoPessoa);
                    item.SubItems.Add(c.email);
                    item.SubItems.Add(c.dataNascimento.ToString("dd/MM/yyyy"));

                    //Add the items to the ListView.
                    listagem.Items.AddRange(new ListViewItem[] { item });
                }

                // Create columns for the items and subitems.
                // Width of -2 indicates auto-size.
                listagem.Columns.Add("", -2, HorizontalAlignment.Center);
                listagem.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listagem.Columns.Add("Nome", 250, HorizontalAlignment.Left);
                listagem.Columns.Add("Tipo Pessoa", -2, HorizontalAlignment.Left);
                listagem.Columns.Add("E-mail", -2, HorizontalAlignment.Left);
                listagem.Columns.Add("Data de Nascimento", -2, HorizontalAlignment.Left);


                // Add the ListView to the control collection.
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
