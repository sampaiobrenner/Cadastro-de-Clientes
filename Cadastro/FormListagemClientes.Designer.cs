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
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSetBindingSource)).BeginInit();
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
            this.buttonExluirCliente.Location = new System.Drawing.Point(368, 379);
            this.buttonExluirCliente.Name = "buttonExluirCliente";
            this.buttonExluirCliente.Size = new System.Drawing.Size(91, 23);
            this.buttonExluirCliente.TabIndex = 0;
            this.buttonExluirCliente.Text = "Excluir [Del]";
            this.buttonExluirCliente.UseVisualStyleBackColor = true;
            this.buttonExluirCliente.Click += new System.EventHandler(this.buttonExluirCliente_Click);
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(465, 379);
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
            this.listagem.Location = new System.Drawing.Point(12, 29);
            this.listagem.Name = "listagem";
            this.listagem.Size = new System.Drawing.Size(580, 333);
            this.listagem.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listagem.TabIndex = 2;
            this.listagem.UseCompatibleStateImageBehavior = false;
            this.listagem.View = System.Windows.Forms.View.Details;
            // 
            // FormListagemClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 414);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource cadastroDataSetBindingSource;
        private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.Button buttonExluirCliente;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.ListView listagem;
    }
}