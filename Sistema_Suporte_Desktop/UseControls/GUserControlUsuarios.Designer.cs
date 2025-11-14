namespace Sistema_de_Suporte
{
    partial class GUserControlUsuarios
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelUsuarios = new System.Windows.Forms.Panel();
            this.buttonCadastro = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonTecnico = new System.Windows.Forms.Button();
            this.buttonSenha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(775, 429);
            this.dataGridView1.TabIndex = 0;
            // 
            // panelUsuarios
            // 
            this.panelUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsuarios.Location = new System.Drawing.Point(844, 25);
            this.panelUsuarios.Name = "panelUsuarios";
            this.panelUsuarios.Size = new System.Drawing.Size(316, 429);
            this.panelUsuarios.TabIndex = 1;
            // 
            // buttonCadastro
            // 
            this.buttonCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCadastro.Location = new System.Drawing.Point(30, 474);
            this.buttonCadastro.Name = "buttonCadastro";
            this.buttonCadastro.Size = new System.Drawing.Size(122, 57);
            this.buttonCadastro.TabIndex = 2;
            this.buttonCadastro.Text = "Cadastra novo Usuario";
            this.buttonCadastro.UseVisualStyleBackColor = true;
            this.buttonCadastro.Click += new System.EventHandler(this.buttonCadastro_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEdit.Location = new System.Drawing.Point(356, 474);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(122, 57);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Editar Informações";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.Location = new System.Drawing.Point(682, 474);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(122, 57);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Ativar/Desativar Usuario";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonTecnico
            // 
            this.buttonTecnico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTecnico.Location = new System.Drawing.Point(193, 474);
            this.buttonTecnico.Name = "buttonTecnico";
            this.buttonTecnico.Size = new System.Drawing.Size(122, 57);
            this.buttonTecnico.TabIndex = 3;
            this.buttonTecnico.Text = "Alterar Tipo de Usuario";
            this.buttonTecnico.UseVisualStyleBackColor = true;
            this.buttonTecnico.Click += new System.EventHandler(this.buttonTecnico_Click);
            // 
            // buttonSenha
            // 
            this.buttonSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSenha.Location = new System.Drawing.Point(519, 474);
            this.buttonSenha.Name = "buttonSenha";
            this.buttonSenha.Size = new System.Drawing.Size(122, 57);
            this.buttonSenha.TabIndex = 4;
            this.buttonSenha.Text = "Mudar Senha";
            this.buttonSenha.UseVisualStyleBackColor = true;
            this.buttonSenha.Click += new System.EventHandler(this.buttonSenha_Click);
            // 
            // GUserControlUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSenha);
            this.Controls.Add(this.buttonTecnico);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCadastro);
            this.Controls.Add(this.panelUsuarios);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GUserControlUsuarios";
            this.Size = new System.Drawing.Size(1186, 601);
            this.Load += new System.EventHandler(this.GUserControlUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelUsuarios;
        private System.Windows.Forms.Button buttonCadastro;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonTecnico;
        private System.Windows.Forms.Button buttonSenha;
    }
}
