namespace Sistema_de_Suporte
{
    partial class UserControlConta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonConfiguracao = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxSenhaAtual = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxNovaSenha = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonConta = new System.Windows.Forms.Button();
            this.buttonSenha = new System.Windows.Forms.Button();
            this.buttonEmail = new System.Windows.Forms.Button();
            this.buttonNome = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNova = new System.Windows.Forms.Label();
            this.labelAtual = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Senha";
            // 
            // buttonConfiguracao
            // 
            this.buttonConfiguracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConfiguracao.Location = new System.Drawing.Point(314, 397);
            this.buttonConfiguracao.Name = "buttonConfiguracao";
            this.buttonConfiguracao.Size = new System.Drawing.Size(75, 23);
            this.buttonConfiguracao.TabIndex = 1;
            this.buttonConfiguracao.Text = "Configurar";
            this.buttonConfiguracao.UseVisualStyleBackColor = true;
            this.buttonConfiguracao.Click += new System.EventHandler(this.buttonConfiguracao_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Location = new System.Drawing.Point(258, 248);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(147, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.Location = new System.Drawing.Point(255, 286);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(150, 20);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSenha.Location = new System.Drawing.Point(261, 324);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.ReadOnly = true;
            this.textBoxSenha.Size = new System.Drawing.Size(144, 20);
            this.textBoxSenha.TabIndex = 2;
            // 
            // textBoxSenhaAtual
            // 
            this.textBoxSenhaAtual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSenhaAtual.Location = new System.Drawing.Point(507, 324);
            this.textBoxSenhaAtual.Name = "textBoxSenhaAtual";
            this.textBoxSenhaAtual.Size = new System.Drawing.Size(100, 20);
            this.textBoxSenhaAtual.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(507, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBoxNovaSenha
            // 
            this.textBoxNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNovaSenha.Location = new System.Drawing.Point(507, 350);
            this.textBoxNovaSenha.Name = "textBoxNovaSenha";
            this.textBoxNovaSenha.Size = new System.Drawing.Size(100, 20);
            this.textBoxNovaSenha.TabIndex = 9;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNome.Location = new System.Drawing.Point(507, 248);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 10;
            // 
            // buttonConta
            // 
            this.buttonConta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConta.AutoSize = true;
            this.buttonConta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonConta.Location = new System.Drawing.Point(536, 397);
            this.buttonConta.Name = "buttonConta";
            this.buttonConta.Size = new System.Drawing.Size(79, 23);
            this.buttonConta.TabIndex = 3;
            this.buttonConta.Text = "Excluir Conta";
            this.buttonConta.UseVisualStyleBackColor = true;
            this.buttonConta.Click += new System.EventHandler(this.buttonConta_Click);
            // 
            // buttonSenha
            // 
            this.buttonSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSenha.AutoSize = true;
            this.buttonSenha.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSenha.Location = new System.Drawing.Point(630, 347);
            this.buttonSenha.Name = "buttonSenha";
            this.buttonSenha.Size = new System.Drawing.Size(81, 23);
            this.buttonSenha.TabIndex = 4;
            this.buttonSenha.Text = "Mudar Senha";
            this.buttonSenha.UseVisualStyleBackColor = true;
            this.buttonSenha.Click += new System.EventHandler(this.buttonSenha_Click);
            // 
            // buttonEmail
            // 
            this.buttonEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEmail.AutoSize = true;
            this.buttonEmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEmail.Location = new System.Drawing.Point(630, 286);
            this.buttonEmail.Name = "buttonEmail";
            this.buttonEmail.Size = new System.Drawing.Size(75, 23);
            this.buttonEmail.TabIndex = 5;
            this.buttonEmail.Text = "Mudar Email";
            this.buttonEmail.UseVisualStyleBackColor = true;
            this.buttonEmail.Click += new System.EventHandler(this.buttonEmail_Click);
            // 
            // buttonNome
            // 
            this.buttonNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNome.AutoSize = true;
            this.buttonNome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonNome.Location = new System.Drawing.Point(630, 248);
            this.buttonNome.Name = "buttonNome";
            this.buttonNome.Size = new System.Drawing.Size(78, 23);
            this.buttonNome.TabIndex = 6;
            this.buttonNome.Text = "Mudar Nome";
            this.buttonNome.UseVisualStyleBackColor = true;
            this.buttonNome.Click += new System.EventHandler(this.buttonNome_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(438, 289);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(61, 13);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "Novo Email";
            // 
            // labelNova
            // 
            this.labelNova.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNova.AutoSize = true;
            this.labelNova.Location = new System.Drawing.Point(438, 353);
            this.labelNova.Name = "labelNova";
            this.labelNova.Size = new System.Drawing.Size(67, 13);
            this.labelNova.TabIndex = 12;
            this.labelNova.Text = "Nova Senha";
            // 
            // labelAtual
            // 
            this.labelAtual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAtual.AutoSize = true;
            this.labelAtual.Location = new System.Drawing.Point(438, 327);
            this.labelAtual.Name = "labelAtual";
            this.labelAtual.Size = new System.Drawing.Size(65, 13);
            this.labelAtual.TabIndex = 13;
            this.labelAtual.Text = "Senha Atual";
            // 
            // labelNome
            // 
            this.labelNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(438, 251);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(62, 13);
            this.labelNome.TabIndex = 14;
            this.labelNome.Text = "Novo nome";
            // 
            // UserControlConta
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNova);
            this.Controls.Add(this.labelAtual);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxSenhaAtual);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxNovaSenha);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.buttonConta);
            this.Controls.Add(this.buttonSenha);
            this.Controls.Add(this.buttonEmail);
            this.Controls.Add(this.buttonNome);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonConfiguracao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UserControlConta";
            this.Size = new System.Drawing.Size(929, 627);
            this.Load += new System.EventHandler(this.UserControlConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonConfiguracao;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxSenhaAtual;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxNovaSenha;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonConta;
        private System.Windows.Forms.Button buttonSenha;
        private System.Windows.Forms.Button buttonEmail;
        private System.Windows.Forms.Button buttonNome;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNova;
        private System.Windows.Forms.Label labelAtual;
        private System.Windows.Forms.Label labelNome;
    }
}
