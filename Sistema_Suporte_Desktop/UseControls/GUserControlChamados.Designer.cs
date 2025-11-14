namespace Sistema_de_Suporte
{
    partial class GUserControlChamados
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
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonPrioridade = new System.Windows.Forms.Button();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.panelChamados = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFechar
            // 
            this.buttonFechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFechar.Location = new System.Drawing.Point(912, 513);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(122, 57);
            this.buttonFechar.TabIndex = 5;
            this.buttonFechar.Text = "Fechar Chamado";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonPrioridade
            // 
            this.buttonPrioridade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPrioridade.Location = new System.Drawing.Point(477, 513);
            this.buttonPrioridade.Name = "buttonPrioridade";
            this.buttonPrioridade.Size = new System.Drawing.Size(122, 57);
            this.buttonPrioridade.TabIndex = 6;
            this.buttonPrioridade.Text = "Definir Prioridade";
            this.buttonPrioridade.UseVisualStyleBackColor = true;
            this.buttonPrioridade.Click += new System.EventHandler(this.buttonPrioridade_Click);
            // 
            // buttonStatus
            // 
            this.buttonStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStatus.Location = new System.Drawing.Point(42, 513);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(122, 57);
            this.buttonStatus.TabIndex = 7;
            this.buttonStatus.Text = "Atualizar Status";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // panelChamados
            // 
            this.panelChamados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelChamados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChamados.Location = new System.Drawing.Point(1086, 64);
            this.panelChamados.Name = "panelChamados";
            this.panelChamados.Size = new System.Drawing.Size(316, 429);
            this.panelChamados.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(993, 429);
            this.dataGridView1.TabIndex = 3;
            // 
            // GUserControlChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.buttonPrioridade);
            this.Controls.Add(this.buttonStatus);
            this.Controls.Add(this.panelChamados);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GUserControlChamados";
            this.Size = new System.Drawing.Size(1440, 635);
            this.Load += new System.EventHandler(this.GUserControlChamados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonPrioridade;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.Panel panelChamados;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
