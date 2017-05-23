namespace Cadastro
{
    partial class FormListagemClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cadastroDataSet = new Cadastro.CadastroDataSet();
            this.cadastroDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonExluirCliente = new System.Windows.Forms.Button();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.listagem = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtBoxBuscaCliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroDataSetBindingSource
            // 
            this.cadastroDataSetBindingSource.DataSource = this.cadastroDataSet;
            this.cadastroDataSetBindingSource.Position = 0;
            // 
            // buttonExluirCliente
            // 
            this.buttonExluirCliente.Location = new System.Drawing.Point(391, 379);
            this.buttonExluirCliente.Name = "buttonExluirCliente";
            this.buttonExluirCliente.Size = new System.Drawing.Size(91, 23);
            this.buttonExluirCliente.TabIndex = 0;
            this.buttonExluirCliente.Text = "Excluir [Del]";
            this.buttonExluirCliente.UseVisualStyleBackColor = true;
            this.buttonExluirCliente.Click += new System.EventHandler(this.buttonExluirCliente_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(488, 379);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(104, 23);
            this.buttonFechar.TabIndex = 1;
            this.buttonFechar.Text = "Fechar [Esc]";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // listagem
            // 
            this.listagem.AllowColumnReorder = true;
            this.listagem.FullRowSelect = true;
            this.listagem.GridLines = true;
            this.listagem.Location = new System.Drawing.Point(12, 67);
            this.listagem.Name = "listagem";
            this.listagem.Size = new System.Drawing.Size(580, 295);
            this.listagem.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listagem.TabIndex = 2;
            this.listagem.UseCompatibleStateImageBehavior = false;
            this.listagem.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBoxBuscaCliente);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 34);
            this.panel1.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(476, 7);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(101, 23);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar [Enter]";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxBuscaCliente
            // 
            this.txtBoxBuscaCliente.Location = new System.Drawing.Point(3, 9);
            this.txtBoxBuscaCliente.Name = "txtBoxBuscaCliente";
            this.txtBoxBuscaCliente.Size = new System.Drawing.Size(467, 20);
            this.txtBoxBuscaCliente.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Novo Cadastro [F2]";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormListagemClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 414);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listagem);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonExluirCliente);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormListagemClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Clientes";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormListagemClientes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource cadastroDataSetBindingSource;
        private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.Button buttonExluirCliente;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.ListView listagem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtBoxBuscaCliente;
        private System.Windows.Forms.Button button1;
    }
}