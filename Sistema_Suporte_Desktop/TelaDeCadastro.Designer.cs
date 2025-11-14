namespace Sistema_de_Suporte
{
    partial class TelaDeCadastro
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.checkBoxTermos = new System.Windows.Forms.CheckBox();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(275, 170);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nome";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Location = new System.Drawing.Point(316, 167);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(227, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonInsert.Location = new System.Drawing.Point(278, 338);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 7;
            this.buttonInsert.Text = "Cadastrar";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.Location = new System.Drawing.Point(316, 205);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(227, 20);
            this.textBoxEmail.TabIndex = 3;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(275, 208);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Location = new System.Drawing.Point(316, 245);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(227, 20);
            this.textBoxPassword.TabIndex = 5;
            // 
            // labelSenha
            // 
            this.labelSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(275, 248);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 4;
            this.labelSenha.Text = "Senha";
            // 
            // checkBoxTermos
            // 
            this.checkBoxTermos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxTermos.AutoSize = true;
            this.checkBoxTermos.Location = new System.Drawing.Point(278, 295);
            this.checkBoxTermos.Name = "checkBoxTermos";
            this.checkBoxTermos.Size = new System.Drawing.Size(123, 17);
            this.checkBoxTermos.TabIndex = 6;
            this.checkBoxTermos.Text = "Termos e Condições";
            this.checkBoxTermos.UseVisualStyleBackColor = true;
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.Location = new System.Drawing.Point(277, 367);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(116, 13);
            this.linkLabelLogin.TabIndex = 8;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Já possui conta? Login";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // TelaDeCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(819, 547);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.checkBoxTermos);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "TelaDeCadastro";
            this.Text = "Tela de Cadastro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.CheckBox checkBoxTermos;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
    }
}

