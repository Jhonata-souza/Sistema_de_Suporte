namespace Sistema_de_Suporte
{
    partial class UserControlChamados
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
            this.buttonNovosChamados = new System.Windows.Forms.Button();
            this.buttonChamados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNovosChamados
            // 
            this.buttonNovosChamados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNovosChamados.Location = new System.Drawing.Point(275, 270);
            this.buttonNovosChamados.Name = "buttonNovosChamados";
            this.buttonNovosChamados.Size = new System.Drawing.Size(217, 128);
            this.buttonNovosChamados.TabIndex = 0;
            this.buttonNovosChamados.Text = "Novo Chamado";
            this.buttonNovosChamados.UseVisualStyleBackColor = true;
            this.buttonNovosChamados.Click += new System.EventHandler(this.buttonNovosChamados_Click);
            // 
            // buttonChamados
            // 
            this.buttonChamados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChamados.Location = new System.Drawing.Point(275, 136);
            this.buttonChamados.Name = "buttonChamados";
            this.buttonChamados.Size = new System.Drawing.Size(217, 128);
            this.buttonChamados.TabIndex = 0;
            this.buttonChamados.Text = "Meus Chamados";
            this.buttonChamados.UseVisualStyleBackColor = true;
            this.buttonChamados.Click += new System.EventHandler(this.buttonChamados_Click);
            // 
            // UserControlChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonChamados);
            this.Controls.Add(this.buttonNovosChamados);
            this.Name = "UserControlChamados";
            this.Size = new System.Drawing.Size(766, 562);
            this.Load += new System.EventHandler(this.UserControlChamados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNovosChamados;
        private System.Windows.Forms.Button buttonChamados;
    }
}
