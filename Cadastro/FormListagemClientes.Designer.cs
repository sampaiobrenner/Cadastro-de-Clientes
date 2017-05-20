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
            this.buttonExluirCliente.Location = new System.Drawing.Point(403, 379);
            this.buttonExluirCliente.Name = "buttonExluirCliente";
            this.buttonExluirCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonExluirCliente.TabIndex = 0;
            this.buttonExluirCliente.Text = "Excluir";
            this.buttonExluirCliente.UseVisualStyleBackColor = true;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(494, 379);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(75, 23);
            this.buttonFechar.TabIndex = 1;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            // 
            // FormListagemClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 414);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonExluirCliente);
            this.MaximizeBox = false;
            this.Name = "FormListagemClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource cadastroDataSetBindingSource;
        private CadastroDataSet cadastroDataSet;
        private System.Windows.Forms.Button buttonExluirCliente;
        private System.Windows.Forms.Button buttonFechar;
    }
}