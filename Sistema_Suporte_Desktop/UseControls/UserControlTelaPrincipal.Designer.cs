namespace Sistema_de_Suporte
{
    partial class UserControlTelaPrincipal
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
            this.buttonChamados = new System.Windows.Forms.Button();
            this.buttonConta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChamados
            // 
            this.buttonChamados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChamados.Location = new System.Drawing.Point(352, 172);
            this.buttonChamados.Name = "buttonChamados";
            this.buttonChamados.Size = new System.Drawing.Size(245, 148);
            this.buttonChamados.TabIndex = 0;
            this.buttonChamados.Text = "Chamados";
            this.buttonChamados.UseVisualStyleBackColor = true;
            this.buttonChamados.Click += new System.EventHandler(this.buttonChamados_Click);
            // 
            // buttonConta
            // 
            this.buttonConta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConta.Location = new System.Drawing.Point(352, 326);
            this.buttonConta.Name = "buttonConta";
            this.buttonConta.Size = new System.Drawing.Size(245, 148);
            this.buttonConta.TabIndex = 0;
            this.buttonConta.Text = "Conta";
            this.buttonConta.UseVisualStyleBackColor = true;
            this.buttonConta.Click += new System.EventHandler(this.buttonConta_Click);
            // 
            // UserControlTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonConta);
            this.Controls.Add(this.buttonChamados);
            this.Name = "UserControlTelaPrincipal";
            this.Size = new System.Drawing.Size(948, 646);
            this.Load += new System.EventHandler(this.UserControlTelaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChamados;
        private System.Windows.Forms.Button buttonConta;
    }
}
