namespace Sistema_de_Suporte
{
    partial class GTecnicoCadastro
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
            this.textBoxEspecialidade = new System.Windows.Forms.TextBox();
            this.labelEspec = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxEspecialidade
            // 
            this.textBoxEspecialidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEspecialidade.Location = new System.Drawing.Point(395, 332);
            this.textBoxEspecialidade.Name = "textBoxEspecialidade";
            this.textBoxEspecialidade.Size = new System.Drawing.Size(189, 20);
            this.textBoxEspecialidade.TabIndex = 22;
            // 
            // labelEspec
            // 
            this.labelEspec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEspec.AutoSize = true;
            this.labelEspec.Location = new System.Drawing.Point(316, 335);
            this.labelEspec.Name = "labelEspec";
            this.labelEspec.Size = new System.Drawing.Size(73, 13);
            this.labelEspec.TabIndex = 21;
            this.labelEspec.Text = "Especialidade";
            // 
            // buttonInsert
            // 
            this.buttonInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonInsert.Location = new System.Drawing.Point(319, 375);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 23;
            this.buttonInsert.Text = "Cadastrar";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSenha.Location = new System.Drawing.Point(357, 293);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.PasswordChar = '*';
            this.textBoxSenha.Size = new System.Drawing.Size(227, 20);
            this.textBoxSenha.TabIndex = 29;
            // 
            // labelSenha
            // 
            this.labelSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(316, 296);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 28;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.Location = new System.Drawing.Point(357, 254);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(227, 20);
            this.textBoxEmail.TabIndex = 27;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(316, 257);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 26;
            this.labelEmail.Text = "Email";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Location = new System.Drawing.Point(357, 215);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(227, 20);
            this.textBoxName.TabIndex = 25;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(316, 218);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 24;
            this.labelName.Text = "Nome";
            // 
            // GTecnicoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxEspecialidade);
            this.Controls.Add(this.labelEspec);
            this.Controls.Add(this.buttonInsert);
            this.Name = "GTecnicoCadastro";
            this.Size = new System.Drawing.Size(900, 612);
            this.Load += new System.EventHandler(this.GTecnicoCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEspecialidade;
        private System.Windows.Forms.Label labelEspec;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
    }
}
