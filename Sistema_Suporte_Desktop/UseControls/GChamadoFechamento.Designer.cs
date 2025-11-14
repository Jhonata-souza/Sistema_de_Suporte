namespace Sistema_de_Suporte
{
    partial class GChamadoFechamento
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
            this.buttonFechamento = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFechamento
            // 
            this.buttonFechamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFechamento.Location = new System.Drawing.Point(363, 310);
            this.buttonFechamento.Name = "buttonFechamento";
            this.buttonFechamento.Size = new System.Drawing.Size(109, 23);
            this.buttonFechamento.TabIndex = 36;
            this.buttonFechamento.Text = "Fechar Chamado";
            this.buttonFechamento.UseVisualStyleBackColor = true;
            this.buttonFechamento.Click += new System.EventHandler(this.buttonFechamento_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Location = new System.Drawing.Point(447, 274);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(87, 20);
            this.textBoxID.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "ID do Chamado";
            // 
            // GChamadoFechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonFechamento);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Name = "GChamadoFechamento";
            this.Size = new System.Drawing.Size(895, 606);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFechamento;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
    }
}
