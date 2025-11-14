namespace Sistema_de_Suporte
{
    partial class UserControlTecnicoAtendimento
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
            this.buttonConcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIDChamado = new System.Windows.Forms.TextBox();
            this.textBoxSolucao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonConcluir
            // 
            this.buttonConcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonConcluir.Location = new System.Drawing.Point(361, 332);
            this.buttonConcluir.Name = "buttonConcluir";
            this.buttonConcluir.Size = new System.Drawing.Size(92, 47);
            this.buttonConcluir.TabIndex = 0;
            this.buttonConcluir.Text = "Concluir Atendimento";
            this.buttonConcluir.UseVisualStyleBackColor = true;
            this.buttonConcluir.Click += new System.EventHandler(this.buttonConcluir_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID do Chamado";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Solução";
            // 
            // textBoxIDChamado
            // 
            this.textBoxIDChamado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIDChamado.Location = new System.Drawing.Point(445, 213);
            this.textBoxIDChamado.Name = "textBoxIDChamado";
            this.textBoxIDChamado.Size = new System.Drawing.Size(22, 20);
            this.textBoxIDChamado.TabIndex = 3;
            // 
            // textBoxSolucao
            // 
            this.textBoxSolucao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSolucao.Location = new System.Drawing.Point(364, 261);
            this.textBoxSolucao.Multiline = true;
            this.textBoxSolucao.Name = "textBoxSolucao";
            this.textBoxSolucao.Size = new System.Drawing.Size(173, 65);
            this.textBoxSolucao.TabIndex = 3;
            // 
            // UserControlTecnicoAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxSolucao);
            this.Controls.Add(this.textBoxIDChamado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConcluir);
            this.Name = "UserControlTecnicoAtendimento";
            this.Size = new System.Drawing.Size(894, 593);
            this.Load += new System.EventHandler(this.UserControlTecnicoAtendimento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIDChamado;
        private System.Windows.Forms.TextBox textBoxSolucao;
    }
}
