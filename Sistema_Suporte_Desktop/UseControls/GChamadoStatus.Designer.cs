namespace Sistema_de_Suporte
{
    partial class GChamadoStatus
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
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(381, 301);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(66, 13);
            this.labelEmail.TabIndex = 19;
            this.labelEmail.Text = "Novo Status";
            // 
            // buttonAtt
            // 
            this.buttonAtt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAtt.Location = new System.Drawing.Point(384, 335);
            this.buttonAtt.Name = "buttonAtt";
            this.buttonAtt.Size = new System.Drawing.Size(91, 23);
            this.buttonAtt.TabIndex = 23;
            this.buttonAtt.Text = "Atualizar Status";
            this.buttonAtt.UseVisualStyleBackColor = true;
            this.buttonAtt.Click += new System.EventHandler(this.buttonAtt_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Location = new System.Drawing.Point(468, 260);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(70, 20);
            this.textBoxID.TabIndex = 18;
            // 
            // labelID
            // 
            this.labelID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(381, 263);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(81, 13);
            this.labelID.TabIndex = 17;
            this.labelID.Text = "ID do Chamado";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Aberto",
            "Atendimento",
            "Resolvido",
            "Fechado"});
            this.comboBoxStatus.Location = new System.Drawing.Point(453, 301);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 24;
            // 
            // GChamadoStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonAtt);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelID);
            this.Name = "GChamadoStatus";
            this.Size = new System.Drawing.Size(954, 619);
            this.Load += new System.EventHandler(this.GChamadoStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonAtt;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}
