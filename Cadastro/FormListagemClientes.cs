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

            // Create a new ListView control.

            ListView listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(10, 10), new Size(580, 350));

            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to edit item text.
            listView1.LabelEdit = true;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Display check boxes.
            listView1.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.Ascending;

            try
            {
                IList<Cliente> resultado = dao.obterClientes();
                foreach (var c in resultado)
                {
                    // Create three items and three sets of subitems for each item.
                    ListViewItem item1 = new ListViewItem("", 0);
                    item1.Checked = false;
                    item1.SubItems.Add(c.nome);
                    item1.SubItems.Add(c.tipoPessoa);
                    item1.SubItems.Add(Convert.ToString(c.dataNascimento));

                    //Add the items to the ListView.
                    listView1.Items.AddRange(new ListViewItem[] { item1 });
                }

                // Create columns for the items and subitems.
                // Width of -2 indicates auto-size.
                listView1.Columns.Add("", -2, HorizontalAlignment.Center);
                listView1.Columns.Add("Nome", -2, HorizontalAlignment.Left);
                listView1.Columns.Add("Tipo Pessoa", -2, HorizontalAlignment.Left);
                listView1.Columns.Add("Data de Nascimento", -2, HorizontalAlignment.Left);


                // Add the ListView to the control collection.
                this.Controls.Add(listView1);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex);
            }

        }

    }
}
