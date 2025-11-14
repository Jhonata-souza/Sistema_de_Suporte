namespace Sistema_de_Suporte
{
    partial class GUsuarioSenha
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
            this.buttonSenha = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNovaSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSenha
            // 
            this.buttonSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSenha.Location = new System.Drawing.Point(376, 339);
            this.buttonSenha.Name = "buttonSenha";
            this.buttonSenha.Size = new System.Drawing.Size(79, 29);
            this.buttonSenha.TabIndex = 26;
            this.buttonSenha.Text = "Mudar Senha";
            this.buttonSenha.UseVisualStyleBackColor = true;
            this.buttonSenha.Click += new System.EventHandler(this.buttonSenha_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Location = new System.Drawing.Point(444, 263);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(37, 20);
            this.textBoxID.TabIndex = 25;
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(373, 266);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 24;
            this.labelID.Text = "ID";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nova Senha";
            // 
            // textBoxNovaSenha
            // 
            this.textBoxNovaSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNovaSenha.Location = new System.Drawing.Point(444, 289);
            this.textBoxNovaSenha.Name = "textBoxNovaSenha";
            this.textBoxNovaSenha.Size = new System.Drawing.Size(96, 20);
            this.textBoxNovaSenha.TabIndex = 25;
            // 
            // GUsuarioSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSenha);
            this.Controls.Add(this.textBoxNovaSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Name = "GUsuarioSenha";
            this.Size = new System.Drawing.Size(913, 631);
            this.Load += new System.EventHandler(this.GUsuarioSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSenha;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNovaSenha;
    }
}
