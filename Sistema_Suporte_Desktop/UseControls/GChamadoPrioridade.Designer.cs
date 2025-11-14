namespace Sistema_de_Suporte
{
    partial class GChamadoPrioridade
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
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonAtt = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.comboBoxPrioridade = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(352, 294);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(83, 13);
            this.labelEmail.TabIndex = 26;
            this.labelEmail.Text = "Nova Prioridade";
            // 
            // buttonAtt
            // 
            this.buttonAtt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAtt.Location = new System.Drawing.Point(355, 328);
            this.buttonAtt.Name = "buttonAtt";
            this.buttonAtt.Size = new System.Drawing.Size(109, 23);
            this.buttonAtt.TabIndex = 28;
            this.buttonAtt.Text = "Atualizar Prioridade";
            this.buttonAtt.UseVisualStyleBackColor = true;
            this.buttonAtt.Click += new System.EventHandler(this.buttonAtt_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Location = new System.Drawing.Point(439, 253);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(87, 20);
            this.textBoxID.TabIndex = 25;
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(352, 256);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(81, 13);
            this.labelID.TabIndex = 24;
            this.labelID.Text = "ID do Chamado";
            // 
            // comboBoxPrioridade
            // 
            this.comboBoxPrioridade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPrioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrioridade.FormattingEnabled = true;
            this.comboBoxPrioridade.Items.AddRange(new object[] {
            "Baixa",
            "Media",
            "Alta"});
            this.comboBoxPrioridade.Location = new System.Drawing.Point(439, 294);
            this.comboBoxPrioridade.Name = "comboBoxPrioridade";
            this.comboBoxPrioridade.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrioridade.TabIndex = 29;
            // 
            // GChamadoPrioridade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxPrioridade);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonAtt);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Name = "GChamadoPrioridade";
            this.Size = new System.Drawing.Size(913, 604);
            this.Load += new System.EventHandler(this.GChamadoPrioridade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonAtt;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox comboBoxPrioridade;
    }
}
