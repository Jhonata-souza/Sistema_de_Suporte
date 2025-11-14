namespace Sistema_de_Suporte
{
    partial class TelaDeLogin
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.linkLabelCadastro = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Location = new System.Drawing.Point(307, 177);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(227, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelSenha
            // 
            this.labelSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(266, 180);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEmail.Location = new System.Drawing.Point(307, 137);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(227, 20);
            this.textBoxEmail.TabIndex = 1;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(266, 140);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.Location = new System.Drawing.Point(269, 270);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Entrar";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // linkLabelCadastro
            // 
            this.linkLabelCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelCadastro.AutoSize = true;
            this.linkLabelCadastro.Location = new System.Drawing.Point(269, 300);
            this.linkLabelCadastro.Name = "linkLabelCadastro";
            this.linkLabelCadastro.Size = new System.Drawing.Size(144, 13);
            this.linkLabelCadastro.TabIndex = 5;
            this.linkLabelCadastro.TabStop = true;
            this.linkLabelCadastro.Text = "Não possui conta? Cadastrar";
            this.linkLabelCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCadastro_LinkClicked);
            // 
            // TelaDeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelCadastro);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonLogin);
            this.Name = "TelaDeLogin";
            this.Text = "Tela de Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaDeLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.LinkLabel linkLabelCadastro;
    }
}