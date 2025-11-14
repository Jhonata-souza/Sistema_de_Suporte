namespace Sistema_de_Suporte
{
    partial class UserChamados
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
            this.buttonChamado = new System.Windows.Forms.Button();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChamado
            // 
            this.buttonChamado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChamado.AutoSize = true;
            this.buttonChamado.Location = new System.Drawing.Point(138, 486);
            this.buttonChamado.Name = "buttonChamado";
            this.buttonChamado.Size = new System.Drawing.Size(104, 44);
            this.buttonChamado.TabIndex = 1;
            this.buttonChamado.Text = "Criar Chamado";
            this.buttonChamado.UseVisualStyleBackColor = true;
            this.buttonChamado.Click += new System.EventHandler(this.buttonChamado_Click);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonVoltar.AutoSize = true;
            this.buttonVoltar.Location = new System.Drawing.Point(248, 486);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(51, 44);
            this.buttonVoltar.TabIndex = 1;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(138, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(691, 401);
            this.dataGridView1.TabIndex = 2;
            // 
            // UserChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.buttonChamado);
            this.Name = "UserChamados";
            this.Size = new System.Drawing.Size(967, 608);
            this.Load += new System.EventHandler(this.UserChamados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonChamado;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
